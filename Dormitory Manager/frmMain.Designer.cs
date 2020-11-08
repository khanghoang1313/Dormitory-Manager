namespace Dormitory_Manager
{
    partial class frmMain
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.r = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceRoom = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceRoominfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceService = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCustomerinfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHistory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceStaffinfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTenancy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTenacyList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDesposit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCheck = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceInvoid = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceInvoidList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBillofmonth = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.fluentMain = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Disabled.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Pressed.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Disabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.r});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(204, 608);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // r
            // 
            this.r.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceRoom,
            this.aceCustomer,
            this.aceStaff,
            this.aceTenancy,
            this.aceInvoid,
            this.accordionControlElement6});
            this.r.Expanded = true;
            this.r.Name = "r";
            this.r.Text = "Menu Quản Lý";
            // 
            // aceRoom
            // 
            this.aceRoom.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceRoominfo,
            this.aceService});
            this.aceRoom.Expanded = true;
            this.aceRoom.Name = "aceRoom";
            this.aceRoom.Text = "Phòng Trọ";
            // 
            // aceRoominfo
            // 
            this.aceRoominfo.Name = "aceRoominfo";
            this.aceRoominfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceRoominfo.Text = "Phòng";
            this.aceRoominfo.Click += new System.EventHandler(this.aceRoominfo_Click);
            // 
            // aceService
            // 
            this.aceService.Name = "aceService";
            this.aceService.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceService.Text = "Dịch Vụ";
            this.aceService.Click += new System.EventHandler(this.aceService_Click);
            // 
            // aceCustomer
            // 
            this.aceCustomer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceCustomerinfo,
            this.aceHistory});
            this.aceCustomer.Expanded = true;
            this.aceCustomer.Name = "aceCustomer";
            this.aceCustomer.Text = "Khách Hàng";
            // 
            // aceCustomerinfo
            // 
            this.aceCustomerinfo.Name = "aceCustomerinfo";
            this.aceCustomerinfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceCustomerinfo.Text = "Thông Tin Khách Hàng";
            this.aceCustomerinfo.Click += new System.EventHandler(this.aceCustomerinfo_Click);
            // 
            // aceHistory
            // 
            this.aceHistory.Name = "aceHistory";
            this.aceHistory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHistory.Text = "Lịch Sử Thuê";
            this.aceHistory.Click += new System.EventHandler(this.aceHistory_Click);
            // 
            // aceStaff
            // 
            this.aceStaff.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceStaffinfo});
            this.aceStaff.Expanded = true;
            this.aceStaff.Name = "aceStaff";
            this.aceStaff.Text = "Nhân Viên";
            // 
            // aceStaffinfo
            // 
            this.aceStaffinfo.Name = "aceStaffinfo";
            this.aceStaffinfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceStaffinfo.Text = "Thông Tin Nhân Viên";
            this.aceStaffinfo.Click += new System.EventHandler(this.aceStaffinfo_Click);
            // 
            // aceTenancy
            // 
            this.aceTenancy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceTenacyList,
            this.aceDesposit,
            this.aceCheck});
            this.aceTenancy.Expanded = true;
            this.aceTenancy.Name = "aceTenancy";
            this.aceTenancy.Text = "Hợp Đồng";
            // 
            // aceTenacyList
            // 
            this.aceTenacyList.Name = "aceTenacyList";
            this.aceTenacyList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTenacyList.Text = "Danh Sách Hợp Đồng";
            this.aceTenacyList.Click += new System.EventHandler(this.aceTenacyList_Click);
            // 
            // aceDesposit
            // 
            this.aceDesposit.Name = "aceDesposit";
            this.aceDesposit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDesposit.Text = "Đặt Cọc Giữ Phòng";
            this.aceDesposit.Click += new System.EventHandler(this.aceDesposit_Click);
            // 
            // aceCheck
            // 
            this.aceCheck.Name = "aceCheck";
            this.aceCheck.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceCheck.Text = "Trả Phòng";
            this.aceCheck.Click += new System.EventHandler(this.aceCheck_Click);
            // 
            // aceInvoid
            // 
            this.aceInvoid.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceInvoidList,
            this.aceBillofmonth});
            this.aceInvoid.Expanded = true;
            this.aceInvoid.Name = "aceInvoid";
            this.aceInvoid.Text = "Hoá Đơn";
            // 
            // aceInvoidList
            // 
            this.aceInvoidList.Name = "aceInvoidList";
            this.aceInvoidList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceInvoidList.Text = "Danh Sách Hoá Đơn";
            // 
            // aceBillofmonth
            // 
            this.aceBillofmonth.Name = "aceBillofmonth";
            this.aceBillofmonth.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceBillofmonth.Text = "Phiếu Ghi Điện Nước";
            this.aceBillofmonth.Click += new System.EventHandler(this.aceBillofmonth_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Thống Kê";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1038, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.StatusBar = this.bar1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // fluentMain
            // 
            this.fluentMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentMain.Location = new System.Drawing.Point(204, 31);
            this.fluentMain.Margin = new System.Windows.Forms.Padding(4);
            this.fluentMain.Name = "fluentMain";
            this.fluentMain.Size = new System.Drawing.Size(834, 608);
            this.fluentMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 639);
            this.ControlContainer = this.fluentMain;
            this.Controls.Add(this.fluentMain);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.InactiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Phòng Trọ";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement r;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceRoom;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceService;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTenancy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceRoominfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCustomerinfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHistory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTenacyList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDesposit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCheck;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentMain;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceStaffinfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInvoid;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInvoidList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceBillofmonth;
    }
}