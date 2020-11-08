namespace Dormitory_Manager
{
    partial class UC_Electron_Water
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Electron_Water));
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
            this.gtg = new System.Windows.Forms.GroupBox();
            this.txtGetDate = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOldNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEW_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.gtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).BeginInit();
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
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1200, 57);
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
            this.ribbonPage1.Text = "Danh Sách Hóa Đơn";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 704);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1200, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(422, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm Tên Khách";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(324, 32);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchControl1.MenuManager = this.ribbonControl;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(94, 20);
            this.searchControl1.TabIndex = 25;
            // 
            // gtg
            // 
            this.gtg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtg.BackColor = System.Drawing.Color.White;
            this.gtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gtg.Controls.Add(this.txtGetDate);
            this.gtg.Controls.Add(this.textStatus);
            this.gtg.Controls.Add(this.label10);
            this.gtg.Controls.Add(this.textTotal);
            this.gtg.Controls.Add(this.label8);
            this.gtg.Controls.Add(this.textPrice);
            this.gtg.Controls.Add(this.txtUsed);
            this.gtg.Controls.Add(this.label9);
            this.gtg.Controls.Add(this.txtOldNumber);
            this.gtg.Controls.Add(this.label7);
            this.gtg.Controls.Add(this.txtNewNumber);
            this.gtg.Controls.Add(this.label6);
            this.gtg.Controls.Add(this.label5);
            this.gtg.Controls.Add(this.label4);
            this.gtg.Controls.Add(this.txtEW_Name);
            this.gtg.Controls.Add(this.label3);
            this.gtg.Controls.Add(this.txtRoomID);
            this.gtg.Controls.Add(this.label2);
            this.gtg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gtg.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtg.Location = new System.Drawing.Point(717, 61);
            this.gtg.Margin = new System.Windows.Forms.Padding(2);
            this.gtg.Name = "gtg";
            this.gtg.Padding = new System.Windows.Forms.Padding(2);
            this.gtg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gtg.Size = new System.Drawing.Size(483, 638);
            this.gtg.TabIndex = 28;
            this.gtg.TabStop = false;
            this.gtg.Text = "Thông Tin Phiếu Điện";
            // 
            // txtGetDate
            // 
            this.txtGetDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetDate.Location = new System.Drawing.Point(217, 151);
            this.txtGetDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetDate.Name = "txtGetDate";
            this.txtGetDate.ReadOnly = true;
            this.txtGetDate.Size = new System.Drawing.Size(183, 25);
            this.txtGetDate.TabIndex = 46;
            // 
            // textStatus
            // 
            this.textStatus.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(215, 447);
            this.textStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(183, 25);
            this.textStatus.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Trạng Thái";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(215, 400);
            this.textTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(183, 25);
            this.textTotal.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Thành Tiền";
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.Location = new System.Drawing.Point(215, 350);
            this.textPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(183, 25);
            this.textPrice.TabIndex = 41;
            // 
            // txtUsed
            // 
            this.txtUsed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsed.Location = new System.Drawing.Point(215, 301);
            this.txtUsed.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.ReadOnly = true;
            this.txtUsed.Size = new System.Drawing.Size(183, 25);
            this.txtUsed.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số Tiêu Thụ";
            // 
            // txtOldNumber
            // 
            this.txtOldNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldNumber.Location = new System.Drawing.Point(217, 203);
            this.txtOldNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldNumber.Name = "txtOldNumber";
            this.txtOldNumber.ReadOnly = true;
            this.txtOldNumber.Size = new System.Drawing.Size(183, 25);
            this.txtOldNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Cũ";
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNumber.Location = new System.Drawing.Point(215, 253);
            this.txtNewNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.ReadOnly = true;
            this.txtNewNumber.Size = new System.Drawing.Size(183, 25);
            this.txtNewNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Giá";
            // 
            // txtEW_Name
            // 
            this.txtEW_Name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEW_Name.Location = new System.Drawing.Point(217, 100);
            this.txtEW_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtEW_Name.Name = "txtEW_Name";
            this.txtEW_Name.ReadOnly = true;
            this.txtEW_Name.Size = new System.Drawing.Size(183, 25);
            this.txtEW_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Phiếu";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(217, 51);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(183, 25);
            this.txtRoomID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // dgridView
            // 
            this.dgridView.AllowUserToAddRows = false;
            this.dgridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView.Location = new System.Drawing.Point(2, 61);
            this.dgridView.Margin = new System.Windows.Forms.Padding(2);
            this.dgridView.MultiSelect = false;
            this.dgridView.Name = "dgridView";
            this.dgridView.ReadOnly = true;
            this.dgridView.RowHeadersWidth = 51;
            this.dgridView.RowTemplate.Height = 24;
            this.dgridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridView.Size = new System.Drawing.Size(710, 638);
            this.dgridView.TabIndex = 12;
            this.dgridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerinfo_CellClick);
            // 
            // UC_Electron_Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgridView);
            this.Controls.Add(this.gtg);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Electron_Water";
            this.Size = new System.Drawing.Size(1200, 731);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.gtg.ResumeLayout(false);
            this.gtg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).EndInit();
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
        private System.Windows.Forms.GroupBox gtg;
        private System.Windows.Forms.TextBox txtOldNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEW_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgridView;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox txtGetDate;
    }
}
