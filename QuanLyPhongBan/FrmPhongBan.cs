using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongBan
{
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgv_load.DataSource = Database.Query("select * from PhongBan");
            btn_update.Enabled = btn_delete.Enabled = dgv_load.Rows.Count > 0;
        }

        private bool Check()
        {
            bool check = true;
            erp_loi.Clear();
            if (String.IsNullOrEmpty(txt_id.Text))
            {
                erp_loi.SetError(txt_id, "ID khong dc de trong");
                check = false;
            }
            if (String.IsNullOrEmpty(txt_name.Text))
            {
                erp_loi.SetError(txt_name, "Ten khong duoc de trong");
                check = false;
            }
            if (String.IsNullOrEmpty(txt_add_on.Text))
            {
                erp_loi.SetError(txt_add_on, "Phu cap khong duoc de trong");
                check = false;
            }
            return check;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            string sql = "EXEC ThemPhongBan @MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            dictionary.Add("@TenPhongBan", txt_name.Text);
            dictionary.Add("@NgayThanhLap", dtp_birth.Value.ToString("yyyy-MM-dd"));
            dictionary.Add("@PhuCap", txt_add_on.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            string sql = "EXEC SuaPhongBan @MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            dictionary.Add("@TenPhongBan", txt_name.Text);
            dictionary.Add("@NgayThanhLap", dtp_birth.Value.ToString("yyyy-MM-dd"));
            dictionary.Add("@PhuCap", txt_add_on.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaPhongBan @MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaPhongBan", txt_id.Text);
            try
            {
                DialogResult result = MessageBox.Show(
                    "Co chac muon xoa khong",
                    "Thong Bao",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    Database.Execute(sql, dictionary);
                    LoadDgv();
                    txt_id.Text = txt_name.Text = txt_add_on.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_load.Rows[e.RowIndex].Cells["colMaPhongBan"].Value.ToString();
            txt_name.Text = dgv_load.Rows[e.RowIndex].Cells["colTenPhongBan"].Value.ToString();
            dtp_birth.Value = Convert.ToDateTime(
                dgv_load.Rows[e.RowIndex].Cells["colNgayThanhLap"].Value.ToString()
            );
            txt_add_on.Text = dgv_load.Rows[e.RowIndex].Cells["colPhuCap"].Value.ToString();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TimKiemPhongBan(@TuKhoa)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_find.Checked)
            {
                dictionary.Add("@TuKhoa", txt_find.Text);
            }
            else
            {
                dictionary.Add("@TuKhoa", DBNull.Value);
            }
            dgv_load.DataSource = Database.Query(sql, dictionary);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (
                txt_id.Text.Length >= 3
                || char.IsPunctuation(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
                || !char.IsLetterOrDigit(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (
                char.IsLetter(e.KeyChar)
                || char.IsControl(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
            )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_add_on_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
