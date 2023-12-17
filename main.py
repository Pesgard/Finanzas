
from server.server_manager import Server

if __name__ == "__main__":
    host = '127.0.0.1'
    port = 5000
    server_name = '(local)'
    database_name = 'DB4'
    username = 'Sa'
    password = 'admin'

    server_instance = Server(host, port, server_name, database_name, username, password)
    try:
        server_instance.start()
    except KeyboardInterrupt:
        print("\n[INFO] Servidor detenido manualmente.")
    finally:
        server_instance.user_manager.close_connection()
