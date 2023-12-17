# server.py
import socket
import threading
from server.user_manager import UserManager
import datetime  # Agregar importación para manejar fechas


class Server:
    def __init__(self, host, port, server, database, username, password):
        self.host = host
        self.port = port
        self.user_manager = UserManager(server, database, username, password)
        self.expense_manager = None  # Inicializar a None

    def start(self):
        server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server.bind((self.host, self.port))
        server.listen(5)

        print(f'[INFO] Servidor escuchando en el puerto {self.port}...')

        while True:
            client, addr = server.accept()
            print(f'[INFO] Conexión aceptada desde {addr[0]}:{addr[1]}')

            # Iniciar un nuevo hilo para manejar al cliente
            client_handler = threading.Thread(target=self.handle_client, args=(client,))
            client_handler.start()

    def handle_client(self, client_socket):
        try:
            while True:
                request = client_socket.recv(1024).decode('utf-8')
                if not request:
                    break  # Salir del bucle si no hay datos

                self.handle_request(client_socket, request)
        except Exception as e:
            print(f'[ERROR] Error de cliente: {e}')
        finally:
            client_socket.close()

    def handle_request(self, client_socket, request):
        parts = request.split()
        command = parts[0]

        if command == 'login':
            username, password = parts[1], parts[2]
            user_id = self.user_manager.get_user_id(username, password)
            self.expense_manager = self.user_manager.create_expense_manager(user_id)
            self.handle_login(client_socket, username, password)
        elif command == 'registro':
            username, password = parts[1], parts[2]
            self.handle_register(client_socket, username, password)
        elif command == 'historial':
            self.handle_transaction_history(client_socket)
        elif command == 'gasto':
            movement_type, amount, description, = parts[0], float(parts[1]), parts[2]
            self.handle_expense(client_socket, description, amount,movement_type)
        elif command == 'ingreso':
            movement_type, amount,description, = parts[0], float(parts[1]), parts[2]
            self.handle_income(client_socket, description, amount, movement_type)
        elif command == 'balance':
            self.handle_balance(client_socket)
        else:
            client_socket.send('Comando no reconocido'.encode('utf-8'))

    def handle_login(self, client_socket, username, password):
        user_id = self.user_manager.get_user_id(username, password)
        if user_id:
            # Crear una nueva instancia de ExpenseManager
            self.expense_manager = self.user_manager.create_expense_manager(user_id)
            client_socket.send('Login exitoso'.encode('utf-8'))
        else:
            client_socket.send('Credenciales incorrectas'.encode('utf-8'))

    def handle_register(self, client_socket, username, password):
        if self.user_manager.register_user(username, password):
            client_socket.send('Registro exitoso'.encode('utf-8'))
        else:
            client_socket.send('Error durante el registro'.encode('utf-8'))

    def handle_transaction_history(self, client_socket):
        transactions = self.expense_manager.get_transaction_history()
        response = '\n'.join(transactions)
        client_socket.send(response.encode('utf-8'))

    def handle_expense(self, client_socket, description, amount, movement_type):
        if self.expense_manager:
            timestamp = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
            if movement_type.lower() == 'gasto':
                user_id = self.expense_manager.user_id
                amount = -amount
                self.expense_manager.record_expense(user_id,description, amount, timestamp)
                client_socket.send('Gasto registrado exitosamente'.encode('utf-8'))

    def handle_income(self, client_socket, description, amount, movement_type):
        if self.expense_manager:
            # Generar automáticamente la fecha actual
            timestamp = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

            if movement_type.lower() == 'ingreso':
                # Utiliza user_id del ExpenseManager actual
                user_id = self.expense_manager.user_id
                self.expense_manager.record_income(user_id, description, amount, timestamp)
                client_socket.send('Ingreso registrado exitosamente'.encode('utf-8'))
            else:
                client_socket.send('Error: Tipo de movimiento no reconocido'.encode('utf-8'))
        else:
            client_socket.send('Error: No se ha iniciado sesión'.encode('utf-8'))

    def handle_balance(self, client_socket):
        if self.expense_manager:
            balance = self.expense_manager.get_balance()
            client_socket.send(f'Balance actual: {balance}'.encode('utf-8'))
        else:
            client_socket.send('Error: No se ha iniciado sesión'.encode('utf-8'))
