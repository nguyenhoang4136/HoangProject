namespace Hoang_Project
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Header = new Panel();
            pb_MenuControl = new PictureBox();
            pb_Minimize = new PictureBox();
            pb_Maximize = new PictureBox();
            pb_Exit = new PictureBox();
            panel_Menu = new Panel();
            lbl_QuanLyChiTieu = new Label();
            pb_QuanLyChiTieu = new PictureBox();
            pb_Background = new PictureBox();
            panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_MenuControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Exit).BeginInit();
            panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QuanLyChiTieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.SkyBlue;
            panel_Header.Controls.Add(pb_MenuControl);
            panel_Header.Controls.Add(pb_Minimize);
            panel_Header.Controls.Add(pb_Maximize);
            panel_Header.Controls.Add(pb_Exit);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1582, 30);
            panel_Header.TabIndex = 0;
            // 
            // pb_MenuControl
            // 
            pb_MenuControl.BackColor = Color.SkyBlue;
            pb_MenuControl.Dock = DockStyle.Left;
            pb_MenuControl.Location = new Point(0, 0);
            pb_MenuControl.Name = "pb_MenuControl";
            pb_MenuControl.Size = new Size(30, 30);
            pb_MenuControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_MenuControl.TabIndex = 3;
            pb_MenuControl.TabStop = false;
            pb_MenuControl.Click += pb_MenuControl_Click;
            // 
            // pb_Minimize
            // 
            pb_Minimize.BackColor = Color.FromArgb(224, 224, 224);
            pb_Minimize.Dock = DockStyle.Right;
            pb_Minimize.Image = Properties.Resources.Minimize;
            pb_Minimize.Location = new Point(1492, 0);
            pb_Minimize.Name = "pb_Minimize";
            pb_Minimize.Size = new Size(30, 30);
            pb_Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Minimize.TabIndex = 2;
            pb_Minimize.TabStop = false;
            pb_Minimize.Click += pb_Minimize_Click;
            // 
            // pb_Maximize
            // 
            pb_Maximize.BackColor = Color.FromArgb(224, 224, 224);
            pb_Maximize.Dock = DockStyle.Right;
            pb_Maximize.ErrorImage = null;
            pb_Maximize.Image = Properties.Resources.Maximize;
            pb_Maximize.Location = new Point(1522, 0);
            pb_Maximize.Name = "pb_Maximize";
            pb_Maximize.Size = new Size(30, 30);
            pb_Maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Maximize.TabIndex = 1;
            pb_Maximize.TabStop = false;
            pb_Maximize.Click += pb_Maximize_Click;
            // 
            // pb_Exit
            // 
            pb_Exit.BackColor = Color.FromArgb(224, 224, 224);
            pb_Exit.Dock = DockStyle.Right;
            pb_Exit.Image = Properties.Resources.Close;
            pb_Exit.Location = new Point(1552, 0);
            pb_Exit.Name = "pb_Exit";
            pb_Exit.Size = new Size(30, 30);
            pb_Exit.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Exit.TabIndex = 0;
            pb_Exit.TabStop = false;
            pb_Exit.Click += pb_Exit_Click;
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.FloralWhite;
            panel_Menu.Controls.Add(lbl_QuanLyChiTieu);
            panel_Menu.Controls.Add(pb_QuanLyChiTieu);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 30);
            panel_Menu.Margin = new Padding(4, 3, 4, 3);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(193, 823);
            panel_Menu.TabIndex = 2;
            // 
            // lbl_QuanLyChiTieu
            // 
            lbl_QuanLyChiTieu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_QuanLyChiTieu.ForeColor = Color.Red;
            lbl_QuanLyChiTieu.Location = new Point(46, 10);
            lbl_QuanLyChiTieu.Name = "lbl_QuanLyChiTieu";
            lbl_QuanLyChiTieu.Size = new Size(141, 30);
            lbl_QuanLyChiTieu.TabIndex = 1;
            lbl_QuanLyChiTieu.Text = "Quản lý chi tiêu";
            lbl_QuanLyChiTieu.TextAlign = ContentAlignment.MiddleLeft;
            lbl_QuanLyChiTieu.Click += lbl_QuanLyChiTieu_Click;
            // 
            // pb_QuanLyChiTieu
            // 
            pb_QuanLyChiTieu.Image = Properties.Resources.Expense;
            pb_QuanLyChiTieu.Location = new Point(10, 10);
            pb_QuanLyChiTieu.Name = "pb_QuanLyChiTieu";
            pb_QuanLyChiTieu.Size = new Size(30, 30);
            pb_QuanLyChiTieu.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_QuanLyChiTieu.TabIndex = 0;
            pb_QuanLyChiTieu.TabStop = false;
            pb_QuanLyChiTieu.Click += pb_QuanLyChiTieu_Click;
            // 
            // pb_Background
            // 
            pb_Background.Dock = DockStyle.Fill;
            pb_Background.Location = new Point(193, 30);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(1389, 823);
            pb_Background.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Background.TabIndex = 5;
            pb_Background.TabStop = false;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(pb_Background);
            Controls.Add(panel_Menu);
            Controls.Add(panel_Header);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainApp";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoàng's Application";
            Load += MainApp_Load;
            panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_MenuControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Exit).EndInit();
            panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_QuanLyChiTieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Header;
        private Panel panel_Menu;
        private PictureBox pb_Exit;
        private PictureBox pb_Maximize;
        private PictureBox pb_Minimize;
        private PictureBox pb_QuanLyChiTieu;
        private PictureBox pb_MenuControl;
        private PictureBox pb_Background;
        private Label lbl_QuanLyChiTieu;
    }
}
