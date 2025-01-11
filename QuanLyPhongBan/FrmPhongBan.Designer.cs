namespace QuanLyPhongBan
{
    partial class FrmPhongBan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.cb_find = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_add_on = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_load = new System.Windows.Forms.DataGridView();
            this.erp_loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_find);
            this.groupBox1.Controls.Add(this.cb_find);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 700);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim Kiem";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(16, 241);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(217, 56);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(16, 179);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(217, 56);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(15, 117);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(217, 56);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "TimKiem";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(6, 68);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(281, 24);
            this.txt_find.TabIndex = 1;
            // 
            // cb_find
            // 
            this.cb_find.AutoSize = true;
            this.cb_find.Location = new System.Drawing.Point(16, 29);
            this.cb_find.Name = "cb_find";
            this.cb_find.Size = new System.Drawing.Size(89, 22);
            this.cb_find.TabIndex = 0;
            this.cb_find.Text = "TimKiem";
            this.cb_find.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_birth);
            this.groupBox2.Controls.Add(this.txt_add_on);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(346, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong Tin";
            // 
            // dtp_birth
            // 
            this.dtp_birth.Location = new System.Drawing.Point(145, 112);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(274, 24);
            this.dtp_birth.TabIndex = 8;
            // 
            // txt_add_on
            // 
            this.txt_add_on.Location = new System.Drawing.Point(145, 176);
            this.txt_add_on.Name = "txt_add_on";
            this.txt_add_on.Size = new System.Drawing.Size(281, 24);
            this.txt_add_on.TabIndex = 7;
            this.txt_add_on.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_add_on_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(145, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(281, 24);
            this.txt_name.TabIndex = 5;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(145, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(281, 24);
            this.txt_id.TabIndex = 4;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "PhuCap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NgayThanhLap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenPhongBan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaPhongBan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(346, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc Nang";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(289, 25);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 36);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xoa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(151, 25);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 36);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Sua";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 36);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Them";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_load);
            this.groupBox4.Location = new System.Drawing.Point(346, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(852, 338);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Du Lieu";
            // 
            // dgv_load
            // 
            this.dgv_load.AllowUserToAddRows = false;
            this.dgv_load.AllowUserToDeleteRows = false;
            this.dgv_load.AllowUserToResizeColumns = false;
            this.dgv_load.AllowUserToResizeRows = false;
            this.dgv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colNgayThanhLap,
            this.colPhuCap});
            this.dgv_load.Location = new System.Drawing.Point(10, 22);
            this.dgv_load.Name = "dgv_load";
            this.dgv_load.ReadOnly = true;
            this.dgv_load.RowHeadersWidth = 51;
            this.dgv_load.RowTemplate.Height = 24;
            this.dgv_load.Size = new System.Drawing.Size(828, 302);
            this.dgv_load.TabIndex = 0;
            this.dgv_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_RowEnter);
            // 
            // erp_loi
            // 
            this.erp_loi.ContainerControl = this;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaPhongBan.DataPropertyName = "MaPhongBan";
            this.colMaPhongBan.HeaderText = "MaPhongBan";
            this.colMaPhongBan.MinimumWidth = 6;
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.ReadOnly = true;
            this.colMaPhongBan.Width = 127;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTenPhongBan.DataPropertyName = "TenPhongBan";
            this.colTenPhongBan.HeaderText = "TenPhongBan";
            this.colTenPhongBan.MinimumWidth = 6;
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.ReadOnly = true;
            this.colTenPhongBan.Width = 131;
            // 
            // colNgayThanhLap
            // 
            this.colNgayThanhLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colNgayThanhLap.DataPropertyName = "NgayThanhLap";
            this.colNgayThanhLap.HeaderText = "NgayThanhLap";
            this.colNgayThanhLap.MinimumWidth = 6;
            this.colNgayThanhLap.Name = "colNgayThanhLap";
            this.colNgayThanhLap.ReadOnly = true;
            this.colNgayThanhLap.Width = 136;
            // 
            // colPhuCap
            // 
            this.colPhuCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhuCap.DataPropertyName = "PhuCap";
            this.colPhuCap.HeaderText = "PhuCap";
            this.colPhuCap.MinimumWidth = 6;
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.ReadOnly = true;
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 748);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_find;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.TextBox txt_add_on;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_load;
        private System.Windows.Forms.ErrorProvider erp_loi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThanhLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuCap;
    }
}