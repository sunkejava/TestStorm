using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalReportDemo
{
    public partial class FrmPrint : Form
    {
        private int pageCount;
        private int nowPage;
        private string sfxs;
        public object rpst
        {
            get;set;
        }
        public FrmPrint()
        {
            InitializeComponent();
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            rptView.ReportSource = rpst;
            rptView.ShowLastPage();
            pageCount = rptView.GetCurrentPageNumber();
            nowPage = 1;
            sfxs = "100%";
            Console.WriteLine("pageCount:{0}", rptView.GetCurrentPageNumber());
            rptView.ShowFirstPage();
            UpdateState();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine("点击item名称：{0}", e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "btnFirst":
                    FirstSub();
                    break;
                case "btnBack":
                    BackSub();
                    break;
                case "btnNext":
                    NextSub();
                    break;
                case "btnLast":
                    LastSub();
                    break;
                case "btnGoto":
                    GotoSub();
                    break;
                case "btnRefresh":
                    RefreshSub();
                    break;
                case "btnPrint":
                    PrintSub();
                    break;
                case "btnExport":
                    ExportSub();
                    break;
                case "btnQuery":
                    QuerySub();
                    break;
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        #region 自定义过程

        private void FirstSub()
        {
            rptView.ShowFirstPage();
            nowPage = 1;
            UpdateState();
        }

        private void BackSub()
        {
            nowPage--;
            rptView.ShowPreviousPage();
            UpdateState();
        }

        private void NextSub()
        {
            nowPage++;
            rptView.ShowNextPage();
            UpdateState();
        }

        private void LastSub()
        {
            nowPage = pageCount;
            rptView.ShowLastPage();
            UpdateState();
        }

        private void GotoSub()
        {
            int pageNum;
            if (goPageNum.SelectedItem == null)
            {
                MessageBox.Show(this, "请指定页码！");
                return;
            }
            try
            {
                pageNum = goPageNum.SelectedIndex;
                if (pageNum > pageCount)
                {
                    MessageBox.Show(this, "页码超出范围！");
                }
                rptView.ShowNthPage(pageNum);
                nowPage = pageNum;
            }
            catch
            {
                MessageBox.Show(this, "(" + goPageNum.SelectedIndex + ")不是有效的数字！");
            }
            UpdateState();
        }

        private void PrintSub()
        {
            rptView.PrintReport();
        }

        private void ExportSub()
        {
            rptView.ExportReport();
        }

        private void RefreshSub()
        {
            rptView.RefreshReport();
            rptView.Refresh();
        }

        private void QuerySub()
        {
            if (queryTxt.Text == null)
            {
                MessageBox.Show(this, "请输入查找的文本！");
                return;
            }
            if (!rptView.SearchForText(queryTxt.Text.ToString()))
            {
                MessageBox.Show(this, "没有找到指定的文本！");
            }
        }

        private void ZoomSub(string zoomBl)
        {
            switch (zoomBl)
            {
                case "1":
                    sfxs = "页宽";
                    break;
                case "2":
                    sfxs = "整页";
                    break;
                default:
                    sfxs = zoomBl + "%";
                    break;
            }
            rptView.Zoom(int.Parse(zoomBl));
        }
        private void UpdateState()
        {
            btnFirst.Enabled = rptView.GetCurrentPageNumber() > 1;
            btnBack.Enabled = rptView.GetCurrentPageNumber() > 1;
            btnNext.Enabled = rptView.GetCurrentPageNumber() < pageCount;
            btnLast.Enabled = rptView.GetCurrentPageNumber() < pageCount;
            btnGoto.Enabled = pageCount > 1;
            goPageNum.Items.Clear();
            for (int i = 1; i <= pageCount; i++)
            {
                goPageNum.Items.Add(i);
            }
            //lbnowPage.Text = "当前页码："+ nowPage;
            //lbcountPage.Text = "总页数："+ pageCount;
            //lbsfxs.Text = "缩放系数："+sfxs;
        }

        #endregion

        private void btnZoomyk_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemBtn = sender as ToolStripMenuItem;
            Console.WriteLine("点击item名称：{0}", itemBtn.Name);
            switch (itemBtn.Name)
            {
                case "btnZoomyk":
                    ZoomSub("1");
                    break;
                case "btnZoomzy":
                    ZoomSub("2");
                    break;
                case "btnZoom200":
                    ZoomSub("200");
                    break;
                case "btnZoom150":
                    ZoomSub("150");
                    break;
                case "btnZoom100":
                    ZoomSub("100");
                    break;
                case "btnZoom75":
                    ZoomSub("75");
                    break;
                case "btnZoom50":
                    ZoomSub("50");
                    break;
                default:
                    break;
            }
        }
    }
}
