using System.Data.SqlClient;

namespace Cafeteria
{
    internal class MySqlCommand
    {
        private string v;
        private SqlConnection conectar;

        public MySqlCommand(string v, SqlConnection conectar)
        {
            this.v = v;
            this.conectar = conectar;
        }
    }
}