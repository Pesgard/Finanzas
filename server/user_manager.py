# user_manager.py
import pyodbc
from server.expense_manager import ExpenseManager  # Asumiendo que ExpenseManager está en el mismo directorio

class UserManager:
    def __init__(self, server, database, username, password):
        self.connection_string = f'DRIVER={{SQL Server}};SERVER={server};DATABASE={database};UID={username};PWD={password}'
        self.conn = pyodbc.connect(self.connection_string)
        self.cursor = self.conn.cursor()

    def check_credentials(self, username, password):
        self.cursor.execute("SELECT * FROM Usuarios WHERE Username = ? AND Password = ?", (username, password))
        return self.cursor.fetchone() is not None

    def register_user(self, username, password):
        try:
            self.cursor.execute("INSERT INTO Usuarios (Username, Password) VALUES (?, ?)", (username, password))
            self.conn.commit()
            return True
        except Exception as e:
            print(f"Error during user registration: {e}")
            return False

    def get_user_id(self, username, password):
        try:
            self.cursor.execute("SELECT ID FROM Usuarios WHERE Username = ? AND Password = ?", (username, password))
            user_id = self.cursor.fetchone()
            return user_id[0] if user_id else None
        except Exception as e:
            print(f"Error obtaining user ID: {e}")
            return None

    def create_expense_manager(self, user_id):
        return ExpenseManager(self.conn, user_id)
    def close_connection(self):
        self.conn.close()
