namespace Dormitory_Manager
{
    partial class UC_TenacyList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TenacyList));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gtg = new System.Windows.Forms.GroupBox();
            this.lsvService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRoomname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeposits = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddrCus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDCus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddrStaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenacyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTenacylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenacylist)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1600, 68);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "In";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPrintPreview.ImageOptions.SvgImage")));
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm Mới";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNew.ImageOptions.SvgImage")));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Chỉnh Sửa";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xoá";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Làm Mới";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Sách Hợp Đồng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Công Cụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 867);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1600, 33);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(563, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm Hợp Đồng";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(432, 40);
            this.searchControl1.MenuManager = this.ribbonControl;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(125, 22);
            this.searchControl1.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.gtg);
            this.groupBox2.Controls.Add(this.dgvTenacylist);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1600, 799);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // gtg
            // 
            this.gtg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtg.AutoSize = true;
            this.gtg.BackColor = System.Drawing.Color.White;
            this.gtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gtg.Controls.Add(this.lsvService);
            this.gtg.Controls.Add(this.txtRoomname);
            this.gtg.Controls.Add(this.label16);
            this.gtg.Controls.Add(this.txtEnd);
            this.gtg.Controls.Add(this.label15);
            this.gtg.Controls.Add(this.txtStart);
            this.gtg.Controls.Add(this.label14);
            this.gtg.Controls.Add(this.txtDeposits);
            this.gtg.Controls.Add(this.label13);
            this.gtg.Controls.Add(this.label12);
            this.gtg.Controls.Add(this.txtAddrCus);
            this.gtg.Controls.Add(this.label11);
            this.gtg.Controls.Add(this.txtIDCus);
            this.gtg.Controls.Add(this.label10);
            this.gtg.Controls.Add(this.txtCustomerName);
            this.gtg.Controls.Add(this.label9);
            this.gtg.Controls.Add(this.label8);
            this.gtg.Controls.Add(this.label6);
            this.gtg.Controls.Add(this.txtDate);
            this.gtg.Controls.Add(this.label4);
            this.gtg.Controls.Add(this.txtAddrStaff);
            this.gtg.Controls.Add(this.label7);
            this.gtg.Controls.Add(this.txtIDStaff);
            this.gtg.Controls.Add(this.label5);
            this.gtg.Controls.Add(this.txtStaffName);
            this.gtg.Controls.Add(this.label3);
            this.gtg.Controls.Add(this.txtTenacyID);
            this.gtg.Controls.Add(this.label2);
            this.gtg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gtg.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtg.Location = new System.Drawing.Point(644, 21);
            this.gtg.Name = "gtg";
            this.gtg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gtg.Size = new System.Drawing.Size(940, 772);
            this.gtg.TabIndex = 22;
            this.gtg.TabStop = false;
            this.gtg.Text = "Thông Tin Hợp Đồng";
            // 
            // lsvService
            // 
            this.lsvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvService.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvService.FullRowSelect = true;
            this.lsvService.GridLines = true;
            this.lsvService.HideSelection = false;
            this.lsvService.Location = new System.Drawing.Point(286, 545);
            this.lsvService.Name = "lsvService";
            this.lsvService.Size = new System.Drawing.Size(450, 172);
            this.lsvService.TabIndex = 32;
            this.lsvService.UseCompatibleStateImageBehavior = false;
            this.lsvService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Dịch Vụ";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Giá";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Vị Tính";
            this.columnHeader3.Width = 150;
            // 
            // txtRoomname
            // 
            this.txtRoomname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomname.Location = new System.Drawing.Point(203, 481);
            this.txtRoomname.Name = "txtRoomname";
            this.txtRoomname.ReadOnly = true;
            this.txtRoomname.Size = new System.Drawing.Size(221, 29);
            this.txtRoomname.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(71, 485);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 30;
            this.label16.Text = "Tên Phòng";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(619, 114);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(215, 29);
            this.txtEnd.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(486, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 21);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ngày Kết Thúc";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(203, 114);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(221, 29);
            this.txtStart.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ngày Bắt Đầu";
            // 
            // txtDeposits
            // 
            this.txtDeposits.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposits.Location = new System.Drawing.Point(619, 481);
            this.txtDeposits.Name = "txtDeposits";
            this.txtDeposits.ReadOnly = true;
            this.txtDeposits.Size = new System.Drawing.Size(215, 29);
            this.txtDeposits.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(487, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tiền Đặt Cọc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(199, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Dịch Vụ";
            // 
            // txtAddrCus
            // 
            this.txtAddrCus.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrCus.Location = new System.Drawing.Point(619, 346);
            this.txtAddrCus.Multiline = true;
            this.txtAddrCus.Name = "txtAddrCus";
            this.txtAddrCus.ReadOnly = true;
            this.txtAddrCus.Size = new System.Drawing.Size(215, 105);
            this.txtAddrCus.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Địa Chỉ";
            // 
            // txtIDCus
            // 
            this.txtIDCus.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCus.Location = new System.Drawing.Point(619, 284);
            this.txtIDCus.Name = "txtIDCus";
            this.txtIDCus.ReadOnly = true;
            this.txtIDCus.Size = new System.Drawing.Size(215, 29);
            this.txtIDCus.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "CMND ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(619, 231);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(215, 29);
            this.txtCustomerName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(487, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bên Thuê (Bên B) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bên Cho Thuê (Bên A) :";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(619, 56);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(215, 29);
            this.txtDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày Lập";
            // 
            // txtAddrStaff
            // 
            this.txtAddrStaff.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrStaff.Location = new System.Drawing.Point(205, 346);
            this.txtAddrStaff.Multiline = true;
            this.txtAddrStaff.Name = "txtAddrStaff";
            this.txtAddrStaff.ReadOnly = true;
            this.txtAddrStaff.Size = new System.Drawing.Size(219, 105);
            this.txtAddrStaff.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(205, 288);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.ReadOnly = true;
            this.txtIDStaff.Size = new System.Drawing.Size(219, 29);
            this.txtIDStaff.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "CMND ";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(205, 231);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(219, 29);
            this.txtStaffName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // txtTenacyID
            // 
            this.txtTenacyID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenacyID.Location = new System.Drawing.Point(205, 60);
            this.txtTenacyID.Name = "txtTenacyID";
            this.txtTenacyID.ReadOnly = true;
            this.txtTenacyID.Size = new System.Drawing.Size(219, 29);
            this.txtTenacyID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hợp Đồng";
            // 
            // dgvTenacylist
            // 
            this.dgvTenacylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTenacylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTenacylist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTenacylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenacylist.Location = new System.Drawing.Point(16, 14);
            this.dgvTenacylist.MultiSelect = false;
            this.dgvTenacylist.Name = "dgvTenacylist";
            this.dgvTenacylist.ReadOnly = true;
            this.dgvTenacylist.RowHeadersWidth = 51;
            this.dgvTenacylist.RowTemplate.Height = 24;
            this.dgvTenacylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenacylist.Size = new System.Drawing.Size(608, 779);
            this.dgvTenacylist.TabIndex = 25;
            this.dgvTenacylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenacylist_CellClick);
            // 
            // UC_TenacyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "UC_TenacyList";
            this.Size = new System.Drawing.Size(1600, 900);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gtg.ResumeLayout(false);
            this.gtg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenacylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gtg;
        private System.Windows.Forms.TextBox txtAddrStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenacyID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTenacylist;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDCus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddrCus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDeposits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRoomname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView lsvService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
