using Npgsql;
using System.Data;

namespace ProyekResponsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IDepartemenRepo departemenRepo = new DepartemenRepo();
            List<Departemen> listDepartemen = departemenRepo.Get();
            List<String> namaDepartemen = new List<String>();
            for (int i = 0; i < listDepartemen.Count; i++)
            {
                namaDepartemen.Add(listDepartemen[i].Id);
            }
            comboBox_Dep.DataSource = namaDepartemen;
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        void loadData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                int i = 0;
                int max = 0;
                while (rd.Read())
                {
                    int temp = Convert.ToInt32(rd["id_karyawan"]);
                    if (temp > max)
                    {
                        max = temp;
                    }
                }
                max++;
                conn.Close();
                conn.Open();
                sql = @"select * from st_insert(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", max.ToString());
                cmd.Parameters.AddWithValue("_nama", txt_Karyawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", comboBox_Dep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    loadData();
                    txt_Karyawan.Text = comboBox_Dep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txt_Karyawan.Text = r.Cells["nama_karyawan"].Value.ToString();
                comboBox_Dep.Text = r.Cells["id_departemen"].Value.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_update(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", txt_Karyawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", comboBox_Dep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diupdate!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    loadData();
                    txt_Karyawan.Text = comboBox_Dep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data" + r.Cells["nama_karyawan"].Value.ToString() + "?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users Berhasil dihapus!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        loadData();
                        txt_Karyawan.Text = comboBox_Dep.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
        }
    }
}
