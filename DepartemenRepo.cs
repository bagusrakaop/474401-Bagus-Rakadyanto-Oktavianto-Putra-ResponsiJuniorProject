using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyekResponsi
{
    public interface IDepartemenRepo
    {
        internal List<Departemen> Get();
    }
    internal class DepartemenRepo : IDepartemenRepo
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi";
        public static NpgsqlCommand cmd;
        private string sql = null;

        public List<Departemen> Get()
        {
            List<Departemen> listDepartemen = new List<Departemen>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from st_select_departemen()";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Departemen departemen = new Departemen((string)rd["id"], (string)rd["nama_departemen"]);
                listDepartemen.Add(departemen);
            }
            conn.Close();
            return listDepartemen;
        }
    }
}
