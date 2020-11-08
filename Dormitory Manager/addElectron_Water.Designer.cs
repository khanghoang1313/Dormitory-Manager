namespace Dormitory_Manager
{
    partial class addElectron_Water
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpGetDate = new System.Windows.Forms.DateTimePicker();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOldNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEW_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.cboRoomID = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(660, 348);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 27);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 348);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 27);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpGetDate
            // 
            this.dtpGetDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGetDate.Location = new System.Drawing.Point(181, 125);
            this.dtpGetDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGetDate.Name = "dtpGetDate";
            this.dtpGetDate.Size = new System.Drawing.Size(181, 25);
            this.dtpGetDate.TabIndex = 52;
            // 
            // txtUsed
            // 
            this.txtUsed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsed.Location = new System.Drawing.Point(179, 276);
            this.txtUsed.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.ReadOnly = true;
            this.txtUsed.Size = new System.Drawing.Size(183, 25);
            this.txtUsed.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Số Tiêu Thụ";
            // 
            // txtOldNumber
            // 
            this.txtOldNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldNumber.Location = new System.Drawing.Point(181, 178);
            this.txtOldNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldNumber.Name = "txtOldNumber";
            this.txtOldNumber.ReadOnly = true;
            this.txtOldNumber.Size = new System.Drawing.Size(183, 25);
            this.txtOldNumber.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Số Cũ";
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNumber.Location = new System.Drawing.Point(179, 228);
            this.txtNewNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(183, 25);
            this.txtNewNumber.TabIndex = 47;
            this.txtNewNumber.TextChanged += new System.EventHandler(this.txtNewNumber_TextChanged);
            this.txtNewNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số Mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ngày Lập";
            // 
            // txtEW_Name
            // 
            this.txtEW_Name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEW_Name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEW_Name.Location = new System.Drawing.Point(181, 75);
            this.txtEW_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtEW_Name.Name = "txtEW_Name";
            this.txtEW_Name.ReadOnly = true;
            this.txtEW_Name.Size = new System.Drawing.Size(183, 25);
            this.txtEW_Name.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã Phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Trạng Thái";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(567, 228);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(183, 25);
            this.txtTotal.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Thành Tiền";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(567, 178);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 25);
            this.txtPrice.TabIndex = 54;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Đơn Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Loại Phiếu";
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Phiếu Điện",
            "Phiếu Nước"});
            this.cbo_type.Location = new System.Drawing.Point(566, 29);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(184, 21);
            this.cbo_type.TabIndex = 60;
            this.cbo_type.SelectedIndexChanged += new System.EventHandler(this.cbo_type_SelectedIndexChanged);
            // 
            // cboRoomID
            // 
            this.cboRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomID.FormattingEnabled = true;
            this.cboRoomID.Items.AddRange(new object[] {
            "Phiếu Điện",
            "Phiếu Nước"});
            this.cboRoomID.Location = new System.Drawing.Point(179, 29);
            this.cboRoomID.Name = "cboRoomID";
            this.cboRoomID.Size = new System.Drawing.Size(184, 21);
            this.cboRoomID.TabIndex = 61;
            this.cboRoomID.SelectedIndexChanged += new System.EventHandler(this.cboRoomID_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cboStatus.Location = new System.Drawing.Point(566, 279);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(184, 21);
            this.cboStatus.TabIndex = 62;
            // 
            // addElectron_Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 399);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboRoomID);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGetDate);
            this.Controls.Add(this.txtUsed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOldNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEW_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addElectron_Water";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Điện Nước";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpGetDate;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOldNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEW_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.ComboBox cboRoomID;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}