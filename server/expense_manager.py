class ExpenseManager:
    def __init__(self, conn, user_id):
        self.conn = conn
        self.user_id = user_id
        self.cursor = conn.cursor()

    def record_expense(self, user_id, description, amount, timestamp):
        try:
            # Insertar el nuevo ingreso
            with self.conn.cursor() as cursor:
                cursor.execute(
                    "INSERT INTO HistorialGastos (UsuarioID, Descripcion, FechaHora, TipoTransaccion, Monto, BalanceUsuario) "
                    "VALUES (?, ?, ?, ?, ?, (SELECT ISNULL(BalanceUsuario, 0) + ? FROM (SELECT TOP 1 BalanceUsuario FROM HistorialGastos WHERE UsuarioID = ? ORDER BY FechaHora DESC) AS subquery))",
                    (user_id, description, timestamp, 'Ingreso', amount, amount, user_id)
                )

            # Obtener el balance actualizado
            balance = self.get_balance()

            return balance
        except Exception as e:
            print(f"Error durante el registro del ingreso: {e}")
            return None

    # Asumiendo que `timestamp` es un parámetro necesario
    def record_income(self, user_id, description, amount, timestamp):
        try:
            # Insertar el nuevo ingreso
            with self.conn.cursor() as cursor:
                cursor.execute(
                    "INSERT INTO HistorialGastos (UsuarioID, Descripcion, FechaHora, TipoTransaccion, Monto, BalanceUsuario) "
                    "VALUES (?, ?, ?, ?, ?, (SELECT ISNULL(BalanceUsuario, 0) + ? FROM (SELECT TOP 1 BalanceUsuario FROM HistorialGastos WHERE UsuarioID = ? ORDER BY FechaHora DESC) AS subquery))",
                    (user_id, description, timestamp, 'Ingreso', amount, amount, user_id)
                )

            # Obtener el balance actualizado
            balance = self.get_balance()

            return balance
        except Exception as e:
            print(f"Error durante el registro del ingreso: {e}")
            return None


    def get_transaction_history(self, user_id):
        try:
            self.cursor.execute(
                "SELECT Fecha, Descripcion, TipoTransaccion, Monto, BalanceUsuario FROM HistorialGastos WHERE UsuarioId = ? ORDER BY FechaHora",
                (user_id,)
            )
            rows = self.cursor.fetchall()
            history = [
                f"{row.Fecha} - {row.Descripcion}: {row.TipoTransaccion} - Monto: {row.Monto} - Balance: {row.BalanceUsuario}"
                for row in rows
            ]
            return history
        except Exception as e:
            print(f"Error during the retrieval of transaction history: {e}")
            return []

    def get_balance(self):
        try:
            with self.conn.cursor() as cursor:
                cursor.execute(
                    """
                    SELECT TOP 1 ISNULL(BalanceUsuario, 0) 
                    FROM HistorialGastos 
                    WHERE UsuarioID = ? 
                    ORDER BY FechaHora DESC
                    """
                    , (self.user_id,)
                )
                balance = cursor.fetchone()[0]
            return balance
        except Exception as e:
            print(f"Error during the retrieval of balance: {e}")
            return 0
