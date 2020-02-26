namespace CrystalReportDemo
{
    partial class FrmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.goPageNum = new System.Windows.Forms.ToolStripComboBox();
            this.btnGoto = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.queryTxt = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnZoom = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnZoomyk = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomzy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom150 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom75 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom50 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnBack,
            this.btnNext,
            this.btnLast,
            this.goPageNum,
            this.btnGoto,
            this.btnRefresh,
            this.btnExport,
            this.btnPrint,
            this.queryTxt,
            this.btnQuery,
            this.btnZoom,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::CrystalReportDemo.Properties.Resources.首张;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(52, 22);
            this.btnFirst.Text = "首页";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::CrystalReportDemo.Properties.Resources.上张;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 22);
            this.btnBack.Text = "上一页";
            // 
            // btnNext
            // 
            this.btnNext.Image = global::CrystalReportDemo.Properties.Resources.下张;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 22);
            this.btnNext.Text = "下一页";
            // 
            // btnLast
            // 
            this.btnLast.Image = global::CrystalReportDemo.Properties.Resources.末张;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(52, 22);
            this.btnLast.Text = "尾页";
            // 
            // goPageNum
            // 
            this.goPageNum.Name = "goPageNum";
            this.goPageNum.Size = new System.Drawing.Size(121, 25);
            this.goPageNum.Text = "选择页码";
            // 
            // btnGoto
            // 
            this.btnGoto.Image = global::CrystalReportDemo.Properties.Resources.下页;
            this.btnGoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(52, 22);
            this.btnGoto.Text = "转到";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::CrystalReportDemo.Properties.Resources.刷新;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 22);
            this.btnRefresh.Text = "刷新";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::CrystalReportDemo.Properties.Resources.导出;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(52, 22);
            this.btnExport.Text = "导出";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::CrystalReportDemo.Properties.Resources.打印;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 22);
            this.btnPrint.Text = "打印";
            // 
            // queryTxt
            // 
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(100, 25);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = global::CrystalReportDemo.Properties.Resources.查找;
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查找";
            // 
            // btnZoom
            // 
            this.btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomyk,
            this.btnZoomzy,
            this.btnZoom200,
            this.btnZoom150,
            this.btnZoom100,
            this.btnZoom75,
            this.btnZoom50});
            this.btnZoom.Image = global::CrystalReportDemo.Properties.Resources.文本框帮助;
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(61, 22);
            this.btnZoom.Text = "缩放";
            // 
            // btnZoomyk
            // 
            this.btnZoomyk.Name = "btnZoomyk";
            this.btnZoomyk.Size = new System.Drawing.Size(108, 22);
            this.btnZoomyk.Text = "页宽";
            this.btnZoomyk.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoomzy
            // 
            this.btnZoomzy.Name = "btnZoomzy";
            this.btnZoomzy.Size = new System.Drawing.Size(108, 22);
            this.btnZoomzy.Text = "整页";
            this.btnZoomzy.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoom200
            // 
            this.btnZoom200.Name = "btnZoom200";
            this.btnZoom200.Size = new System.Drawing.Size(108, 22);
            this.btnZoom200.Text = "200%";
            this.btnZoom200.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoom150
            // 
            this.btnZoom150.Name = "btnZoom150";
            this.btnZoom150.Size = new System.Drawing.Size(108, 22);
            this.btnZoom150.Text = "150%";
            this.btnZoom150.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(108, 22);
            this.btnZoom100.Text = "100%";
            this.btnZoom100.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoom75
            // 
            this.btnZoom75.Name = "btnZoom75";
            this.btnZoom75.Size = new System.Drawing.Size(108, 22);
            this.btnZoom75.Text = "75%";
            this.btnZoom75.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnZoom50
            // 
            this.btnZoom50.Name = "btnZoom50";
            this.btnZoom50.Size = new System.Drawing.Size(108, 22);
            this.btnZoom50.Text = "50%";
            this.btnZoom50.Click += new System.EventHandler(this.btnZoomyk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CrystalReportDemo.Properties.Resources.退出;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 22);
            this.btnClose.Text = "关闭";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "查找.ico");
            this.imageList1.Images.SetKeyName(1, "打印.ico");
            this.imageList1.Images.SetKeyName(2, "导出.ico");
            this.imageList1.Images.SetKeyName(3, "末张.ico");
            this.imageList1.Images.SetKeyName(4, "上张.ico");
            this.imageList1.Images.SetKeyName(5, "首张.ico");
            this.imageList1.Images.SetKeyName(6, "刷新.ico");
            this.imageList1.Images.SetKeyName(7, "退出.ico");
            this.imageList1.Images.SetKeyName(8, "文本框帮助.ico");
            this.imageList1.Images.SetKeyName(9, "下页.ico");
            this.imageList1.Images.SetKeyName(10, "下张.ico");
            // 
            // rptView
            // 
            this.rptView.ActiveViewIndex = -1;
            this.rptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptView.DisplayGroupTree = false;
            this.rptView.DisplayToolbar = false;
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptView.Location = new System.Drawing.Point(0, 0);
            this.rptView.Name = "rptView";
            this.rptView.SelectionFormula = "";
            this.rptView.Size = new System.Drawing.Size(927, 586);
            this.rptView.TabIndex = 0;
            this.rptView.ViewTimeSelectionFormula = "";
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 586);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rptView);
            this.Name = "FrmPrint";
            this.Text = "FrmPrint";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripComboBox goPageNum;
        private System.Windows.Forms.ToolStripButton btnGoto;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripTextBox queryTxt;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripDropDownButton btnZoom;
        private System.Windows.Forms.ToolStripMenuItem btnZoomyk;
        private System.Windows.Forms.ToolStripMenuItem btnZoomzy;
        private System.Windows.Forms.ToolStripMenuItem btnZoom200;
        private System.Windows.Forms.ToolStripMenuItem btnZoom150;
        private System.Windows.Forms.ToolStripMenuItem btnZoom100;
        private System.Windows.Forms.ToolStripMenuItem btnZoom75;
        private System.Windows.Forms.ToolStripMenuItem btnZoom50;
        private System.Windows.Forms.ToolStripButton btnClose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptView;
    }
}