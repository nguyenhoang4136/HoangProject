namespace Hoang_Project.ChildForm
{
    partial class QuanLyChiTieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label5 = new Label();
            cb_Filter = new ComboBox();
            btn_LamMoi = new Button();
            rtxt_GhiChu = new RichTextBox();
            btn_Nhap = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rbtn_TienVao = new RadioButton();
            rbtn_TienRa = new RadioButton();
            dtp_ChonNgay = new DateTimePicker();
            panel2 = new Panel();
            txt_SoTien = new TextBox();
            panel_Filter = new Panel();
            dgv = new DataGridView();
            panel2.SuspendLayout();
            panel_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1210, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý chi tiêu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(699, 6);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 26);
            label5.TabIndex = 16;
            label5.Text = "Tìm theo";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_Filter
            // 
            cb_Filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Filter.FormattingEnabled = true;
            cb_Filter.Items.AddRange(new object[] { "Tất cả", "Tiền vào", "Tiền ra" });
            cb_Filter.Location = new Point(779, 5);
            cb_Filter.Name = "cb_Filter";
            cb_Filter.Size = new Size(162, 27);
            cb_Filter.TabIndex = 15;
            cb_Filter.SelectedIndexChanged += cb_Filter_SelectedIndexChanged;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Location = new Point(158, 258);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(98, 36);
            btn_LamMoi.TabIndex = 10;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // rtxt_GhiChu
            // 
            rtxt_GhiChu.Location = new Point(94, 91);
            rtxt_GhiChu.Name = "rtxt_GhiChu";
            rtxt_GhiChu.Size = new Size(162, 113);
            rtxt_GhiChu.TabIndex = 4;
            rtxt_GhiChu.Text = "";
            // 
            // btn_Nhap
            // 
            btn_Nhap.Location = new Point(14, 258);
            btn_Nhap.Name = "btn_Nhap";
            btn_Nhap.Size = new Size(98, 36);
            btn_Nhap.TabIndex = 9;
            btn_Nhap.Text = "Thêm dữ liệu";
            btn_Nhap.UseVisualStyleBackColor = true;
            btn_Nhap.Click += btn_Nhap_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(14, 91);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 113);
            label4.TabIndex = 7;
            label4.Text = "Ghi chú";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(14, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 8;
            label3.Text = "Thời gian";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(14, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 26);
            label2.TabIndex = 6;
            label2.Text = "Số tiền";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbtn_TienVao
            // 
            rbtn_TienVao.ForeColor = Color.MediumBlue;
            rbtn_TienVao.Location = new Point(12, 51);
            rbtn_TienVao.Name = "rbtn_TienVao";
            rbtn_TienVao.RightToLeft = RightToLeft.Yes;
            rbtn_TienVao.Size = new Size(82, 26);
            rbtn_TienVao.TabIndex = 2;
            rbtn_TienVao.TabStop = true;
            rbtn_TienVao.Text = "Tiền vào";
            rbtn_TienVao.TextAlign = ContentAlignment.MiddleRight;
            rbtn_TienVao.UseVisualStyleBackColor = true;
            rbtn_TienVao.CheckedChanged += rbtn_TienVao_CheckedChanged;
            // 
            // rbtn_TienRa
            // 
            rbtn_TienRa.ForeColor = Color.MediumBlue;
            rbtn_TienRa.Location = new Point(178, 51);
            rbtn_TienRa.Name = "rbtn_TienRa";
            rbtn_TienRa.RightToLeft = RightToLeft.Yes;
            rbtn_TienRa.Size = new Size(78, 26);
            rbtn_TienRa.TabIndex = 3;
            rbtn_TienRa.TabStop = true;
            rbtn_TienRa.Text = "Tiền ra";
            rbtn_TienRa.TextAlign = ContentAlignment.MiddleRight;
            rbtn_TienRa.UseVisualStyleBackColor = true;
            rbtn_TienRa.CheckedChanged += rbtn_TienRa_CheckedChanged;
            // 
            // dtp_ChonNgay
            // 
            dtp_ChonNgay.CustomFormat = "dd/MM/yyyy";
            dtp_ChonNgay.Format = DateTimePickerFormat.Custom;
            dtp_ChonNgay.Location = new Point(94, 218);
            dtp_ChonNgay.Margin = new Padding(0);
            dtp_ChonNgay.MinDate = new DateTime(2025, 5, 24, 12, 56, 30, 0);
            dtp_ChonNgay.Name = "dtp_ChonNgay";
            dtp_ChonNgay.Size = new Size(162, 26);
            dtp_ChonNgay.TabIndex = 5;
            dtp_ChonNgay.Value = new DateTime(2025, 5, 24, 12, 56, 30, 0);
            dtp_ChonNgay.ValueChanged += dtp_ChonNgay_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_LamMoi);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtp_ChonNgay);
            panel2.Controls.Add(rtxt_GhiChu);
            panel2.Controls.Add(rbtn_TienRa);
            panel2.Controls.Add(rbtn_TienVao);
            panel2.Controls.Add(btn_Nhap);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_SoTien);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(5, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 638);
            panel2.TabIndex = 18;
            // 
            // txt_SoTien
            // 
            txt_SoTien.Location = new Point(94, 12);
            txt_SoTien.Name = "txt_SoTien";
            txt_SoTien.Size = new Size(162, 26);
            txt_SoTien.TabIndex = 12;
            txt_SoTien.TextChanged += txt_SoTien_TextChanged;
            txt_SoTien.KeyPress += txt_SoTien_KeyPress;
            // 
            // panel_Filter
            // 
            panel_Filter.Controls.Add(label5);
            panel_Filter.Controls.Add(cb_Filter);
            panel_Filter.Dock = DockStyle.Top;
            panel_Filter.Location = new Point(274, 37);
            panel_Filter.Name = "panel_Filter";
            panel_Filter.Size = new Size(941, 37);
            panel_Filter.TabIndex = 19;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(274, 74);
            dgv.Margin = new Padding(0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 20;
            dgv.Size = new Size(941, 601);
            dgv.TabIndex = 20;
            // 
            // QuanLyChiTieu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 680);
            Controls.Add(dgv);
            Controls.Add(panel_Filter);
            Controls.Add(panel2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyChiTieu";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chi tiêu";
            Load += QuanLyChiTieu_Load;
            Shown += QuanLyChiTieu_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_Filter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private ComboBox cb_Filter;
        private Label label5;
        private Button btn_LamMoi;
        private RichTextBox rtxt_GhiChu;
        private Button btn_Nhap;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rbtn_TienVao;
        private RadioButton rbtn_TienRa;
        private DateTimePicker dtp_ChonNgay;
        private Panel panel2;
        private Panel panel_Filter;
        private DataGridView dgv;
        private TextBox txt_SoTien;
    }
}