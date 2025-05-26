using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib = Hoang_Project.SupportLibs;

namespace Hoang_Project.ChildForm
{
    public partial class QuanLyChiTieu : Form
    {
        public QuanLyChiTieu()
        {
            InitializeComponent();
        }

        string conStr = "Host=aws-0-ap-southeast-1.pooler.supabase.com;Port=5432;Username=postgres.fsxrsgbghwmfyggxwjcn;Password=hoang207480201012;Database=postgres;SSL Mode=Require;Trust Server Certificate=true";
        private void QuanLyChiTieu_Load(object sender, EventArgs e)
        {
            cb_Filter.SelectedIndex = 0;
            KiemTraDieuKienChoPhepThem();
        }

        private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemTheoBoLoc();
        }

        private void TimKiemTheoBoLoc()
        {
            string sql = "select \"SoTien\" \"Số Tiền\", \"PhanLoai\" \"Phân loại\", \"GhiChu\" \"Ghi chú\", \"ThoiGian\" \"Thời gian\" from lichsuchitieu ";
            if (cb_Filter.SelectedIndex != 0)
            {
                sql += "where \"PhanLoai\" = '" + cb_Filter.Text + "'";
            }
            dgv.DataSource = Lib.ConSQL.connectSQL(sql, conStr);
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxt_GhiChu.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc là không cần ghi chú lại không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            string phanloai = rbtn_TienVao.Text;
            if (rbtn_TienRa.Checked)
            {
                phanloai = rbtn_TienRa.Text;
            }
            string sql = "insert into lichsuchitieu (\"SoTien\", \"PhanLoai\", \"GhiChu\", \"ThoiGian\") values ('"
                            + Convert.ToInt32(txt_SoTien.Text).ToString() + "', '"
                            + phanloai + "', '"
                            + rtxt_GhiChu.Text + "', '"
                            + dtp_ChonNgay.Value.ToString("dd/MM/yyyy HH:mm:ss") + "')";

            Lib.ConSQL.connectSQL(sql, conStr);
            TimKiemTheoBoLoc();
        }

        private void QuanLyChiTieu_Shown(object sender, EventArgs e)
        {
            txt_SoTien.Focus();
            txt_SoTien.SelectAll();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_SoTien.Text = string.Empty;
            rbtn_TienRa.Checked = false;
            rbtn_TienVao.Checked = false;
            rtxt_GhiChu.Text = string.Empty;
            dtp_ChonNgay.Value = DateTime.Now;
        }

        private void KiemTraDieuKienChoPhepThem()
        {
            if (string.IsNullOrWhiteSpace(txt_SoTien.Text) || (rbtn_TienRa.Checked == false && rbtn_TienVao.Checked == false) || dtp_ChonNgay.Text == string.Empty)
            {
                btn_Nhap.Enabled = false;
            }
            else
            {
                if(Convert.ToInt32(txt_SoTien.Text) <= 0)
                {
                    btn_Nhap.Enabled = false;
                }
                else
                {
                    btn_Nhap.Enabled = true;
                }
            }
        }

        private void rbtn_TienVao_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDieuKienChoPhepThem();
        }

        private void rbtn_TienRa_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDieuKienChoPhepThem();
        }

        private void dtp_ChonNgay_ValueChanged(object sender, EventArgs e)
        {
            KiemTraDieuKienChoPhepThem();
        }

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoTien_TextChanged(object sender, EventArgs e)
        {
            KiemTraDieuKienChoPhepThem();
        }
    }
}
