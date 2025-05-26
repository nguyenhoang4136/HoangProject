using Hoang_Project.ChildForm;
using System.Data;
using System.Security.Cryptography;
using anh = Hoang_Project.Properties.Resources;

namespace Hoang_Project
{
    public partial class MainApp : Form
    {
        private Form f_ChildForm;
        public MainApp()
        {
            InitializeComponent();
        }

        private void ShowMdiForm(Form form)
        {
            if (!CheckMdiForm(form.Name))
            {
                form.MdiParent = this;
                //form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private bool CheckMdiForm(string FormName)
        {
            bool hasForm = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == FormName)
                {
                    hasForm = true;
                }
            }
            return hasForm;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            pb_MenuControl.Image = anh.Hide;
            //pb_Background.Image = anh.bg_Pic;
        }

        private void pb_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn tắt chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isShowingMenu = true;
        private void pb_MenuControl_Click(object sender, EventArgs e)
        {
            if (isShowingMenu)
            {
                pb_MenuControl.Image = anh.Show;
                panel_Menu.Visible = false;
            }
            else
            {
                pb_MenuControl.Image = anh.Hide;
                panel_Menu.Visible = true;
            }

            isShowingMenu = !isShowingMenu;
        }

        private void lbl_QuanLyChiTieu_Click(object sender, EventArgs e)
        {
            pb_Background.SendToBack();
            f_ChildForm = new QuanLyChiTieu();
            ShowMdiForm(f_ChildForm);
        }

        private void pb_QuanLyChiTieu_Click(object sender, EventArgs e)
        {
            lbl_QuanLyChiTieu_Click(lbl_QuanLyChiTieu, EventArgs.Empty);
        }


    }
}
