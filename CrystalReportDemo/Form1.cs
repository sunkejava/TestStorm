﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CrystalReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReportPrint();
        }

        private void getRepoData(ref CrystalDecisions.CrystalReports.Engine.ReportClass repo,int l)
        {
            if (repo != null)
            {
                //repo.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)GetPagerSizeId("京东");//设置打印纸张
                string delivery_id = "JDVA01661244585";
                string packagecount = l.ToString();
                string weight = "5";
                string source_sort_center_name = "北京通州分拣中心";
                string source_cross_code = "10";
                string source_tabletrolley_code = "160-呼市";
                string target_sort_center_name = "呼和浩特分拨中心";
                string target_tabletrolley_code = "A10-9";
                string receive_address = "内蒙古呼和浩特市土默特左旗经济技术开发区金川区宽城小区";
                string receive_name = "朱银岭";
                string receive_mobile = "15335557302";
                string sender_address = "内蒙古呼和浩特市和林格尔县企业总部南300米云谷水岸小区东侧";
                string sender_name = "小致";
                string sender_mobile = "18301192819";
                string order_id = "B20200117155332304748390";
                string road = "8";
                string site_name = "*呼市金川宽城营业部";
                repo.DataDefinition.FormulaFields["bgydh"].Text = "'" + delivery_id + "-"+l.ToString()+"-" + packagecount + "-'";//包裹运单号(运单号 -包裹序号 -包裹总数 -)
                repo.DataDefinition.FormulaFields["bgzl"].Text = "'" + weight + "'";//包裹重量
                repo.DataDefinition.FormulaFields["sourcetSortCenterName"].Text = "'" + source_sort_center_name + "'";//始发分拣中心名称
                repo.DataDefinition.FormulaFields["originalCrossCode"].Text = "'" + source_cross_code + "'";//始发道口号
                repo.DataDefinition.FormulaFields["originalTabletrolleyCode"].Text = "'" + source_tabletrolley_code + "'";//始发车笼号
                repo.DataDefinition.FormulaFields["targetSortCenterName"].Text = "'" + target_sort_center_name + "'";//目的地分拣中心名称
                repo.DataDefinition.FormulaFields["destinationCrossCode"].Text = "'" + target_tabletrolley_code + "'";//目的道口号
                repo.DataDefinition.FormulaFields["destinationTabletrolleyCode"].Text = "'" + target_tabletrolley_code + "'";//目的车笼号
                repo.DataDefinition.FormulaFields["sjxx"].Text = "'" + receive_address + " " + receive_name + " " + receive_mobile + "'";//客户信息【黑体 9 号】：包含收件方姓名、电话、地址
                repo.DataDefinition.FormulaFields["ysje"].Text = "'0.00'";
                repo.DataDefinition.FormulaFields["ydh"].Text = "'" + delivery_id + "'";//运单号
                repo.DataDefinition.FormulaFields["khxx"].Text = "'" + receive_name + " " + receive_mobile + "'";//收件客户名称、电话
                repo.DataDefinition.FormulaFields["remark"].Text = "''";//备注 青岛啤酒（Tsingtao）黑啤 /n 500ml * 12听 / 箱 整箱装 包
                repo.DataDefinition.FormulaFields["jfkhxx"].Text = "'" + sender_address + " " + sender_name + " " + sender_mobile + "'";//寄方客户信息
                repo.DataDefinition.FormulaFields["sjid"].Text = "'202001151924001'";//商家ID
                repo.DataDefinition.FormulaFields["bsjddh"].Text = "'" + order_id + "'";//商家订单号
                repo.DataDefinition.FormulaFields["startCity"].Text = "'" + source_sort_center_name + "'";//始发城市
                repo.DataDefinition.FormulaFields["rode"].Text = "'" + road + "'";//路区
                repo.DataDefinition.FormulaFields["bgxl"].Text = "'"+l.ToString()+"/" + packagecount + "'";//包裹序列
                repo.DataDefinition.FormulaFields["siteName"].Text = "'" + site_name + "'";//站点名称
                repo.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;//纵向打印
            }

        }

        private void CrystalReportPrint()
        {
            try
            {
                CrystalDecisions.CrystalReports.Engine.ReportClass repo = (CrystalDecisions.CrystalReports.Engine.ReportClass)Assembly.Load("CrystalReportDemo").CreateInstance("CrystalReportDemo.rpt.CrystalReport1");
                if (repo != null)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        getRepoData(ref repo,i);
                        //repo.PrintToPrinter(1, false, 0, 0);//打印
                        //预览
                        FrmPrint frmPrint = new FrmPrint();
                        frmPrint.rpst = repo;
                        frmPrint.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private int GetPagerSizeId(string PagerName)
        {
            PrintDocument doc = new PrintDocument();
            int rawKind = 0;
            for (int i = 0; i <= doc.PrinterSettings.PaperSizes.Count - 1; i++)
            {
                Console.WriteLine("纸张名称:{0}",doc.PrinterSettings.PaperSizes[i].PaperName);
                if (doc.PrinterSettings.PaperSizes[i].PaperName.Contains(PagerName))
                {
                    rawKind = doc.PrinterSettings.PaperSizes[i].RawKind;
                    continue;
                }
            }
            return rawKind;
        }


        /// <summary>
        /// PrintDocument打印
        /// </summary>
        private void docPrint()
        {
            try
            {
                //#region 打印样式
                ////StringBuilder sb = new StringBuilder();
                ////sb.Append("分拣时间：" + od.sortTime + "\n");
                ////sb.Append("-----------------------------------------\n");
                ////sb.Append("订单来源：" + od.orderSource + "\n");
                ////sb.Append("来源地址：" + od.orderSourceDetail + "\n");
                ////sb.Append("-----------------------------------------\n");
                ////sb.Append("客户昵称：" + od.nickName + "\n");
                ////sb.Append("客户电话：" + od.userPhone + "\n");
                ////sb.Append("衣物数量：" + od.goodsCount + "\n");
                ////sb.Append("派送员：" + od.expressUser + "\n");
                ////sb.Append("派送员电话：" + od.expressPhone + "\n");
                ////sb.Append("-----------------------------------------\n");
                //#endregion
                ////sr = new StringReader(sb.ToString());//文本
                //PrintDocument pd = new PrintDocument();
                //pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                //pd.DefaultPageSettings.Margins.Top = 0;//上边距
                //pd.DefaultPageSettings.Margins.Left = 0;//左边距
                //pd.DefaultPageSettings.PaperSize = new PaperSize("customer", MM2Inch(100), MM2Inch(113));//设置打印区域
                //pd.PrinterSettings.PrinterName = pd.DefaultPageSettings.PrinterSettings.PrinterName;//默认打印机
                //pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
                //pd.Print();
                PrintView();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (sr != null)
                //    sr.Close();
            }
        }


        private static void Pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //注意：此方法不管是串口，并口，还是USB接口的打印机都可以调用，前提是一定要将打印机设为默认打印机。
            ev.Graphics.PageUnit = GraphicsUnit.Millimeter;//设置以毫米为单位进行画图
            Font printFont = new Font("Arial", 9);//普通字体
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);//加粗字体

            Pen colPen = new Pen(Color.Black,0.1F);
            

            #region 画表格

            //画表格横线
            ev.Graphics.DrawLine(colPen, new Point(0,0), new Point(100,0));//顶线
            ev.Graphics.DrawLine(colPen, new Point(0, 20), new Point(100, 20));
            ev.Graphics.DrawLine(colPen, new Point(0, 32), new Point(100, 32));
            ev.Graphics.DrawLine(colPen, new Point(0, 38), new Point(100, 38));
            ev.Graphics.DrawLine(colPen, new Point(64, 46), new Point(100, 46));
            ev.Graphics.DrawLine(colPen, new Point(0, 54), new Point(100, 54));
            ev.Graphics.DrawLine(colPen, new Point(0, 64), new Point(100, 64));
            ev.Graphics.DrawLine(colPen, new Point(0, 71), new Point(100, 71));
            ev.Graphics.DrawLine(colPen, new Point(0, 87), new Point(100, 87));
            ev.Graphics.DrawLine(colPen, new Point(0, 94), new Point(100, 94));
            ev.Graphics.DrawLine(colPen, new Point(0, 101), new Point(100, 101));
            ev.Graphics.DrawLine(colPen, new Point(0, 107), new Point(100, 107));
            //ev.Graphics.DrawLine(colPen, new Point(0, 113), new Point(100, 113));

            //画表格竖线
            ev.Graphics.DrawLine(colPen, new Point(0, 0), new Point(0, 113));
            ev.Graphics.DrawLine(colPen,new Point(5,20), new Point(5,54));
            ev.Graphics.DrawLine(colPen, new Point(47, 20), new Point(47, 32));
            ev.Graphics.DrawLine(colPen, new Point(52, 20), new Point(52, 38));
            ev.Graphics.DrawLine(colPen, new Point(64, 38), new Point(64, 54));
            ev.Graphics.DrawLine(colPen, new Point(74, 32), new Point(74, 54));
            ev.Graphics.DrawLine(colPen, new Point(30, 87), new Point(30, 94));
            ev.Graphics.DrawLine(colPen, new Point(60, 71), new Point(60, 107));
            ev.Graphics.DrawLine(colPen, new Point(80, 87), new Point(80, 94));
            ev.Graphics.DrawLine(colPen, new Point(100, 0), new Point(100, 113));
            #endregion

            #region 填充数据
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;  // 更正： 垂直居中
            format.Alignment = StringAlignment.Center;      // 水平居中
            RectangleF textSize = new Rectangle(new Point(0,14), new Size(100, 60));//文本区域

            //BarCode128 _code128 = new BarCode128();
            //_code128.ValueFont = new Font("黑体",9);
            //_code128.Magnify = 1;
            //_code128.Height = 14;
            //Image img = _code128.GetCodeImage("VA39002434914-1-1-",BarCode128.Encode.Code128A); //96*14
            Image img = BarCodeClass.GenerateBarCode("VA39002434914-1-1-",100,60);
            ev.Graphics.DrawImage(img, 2,1,96,14);//包裹条码 128A码
            //ev.Graphics.TranslateTransform(98,59);
            //ev.Graphics.RotateTransform(180);
            ev.Graphics.DrawString("VA39002434914-1-1-", new Font("黑体",10,FontStyle.Bold),Brushes.Black,textSize, format);//包裹条码
            ev.Graphics.DrawString("1.00KG", new Font("黑体", 10,FontStyle.Bold), Brushes.Black, new Point(75, 16));//包裹条码
            ev.Graphics.DrawString("始发地",new Font("黑体",8,FontStyle.Bold),Brushes.Black,new Point(0,20));
            #endregion


            //float linesPerPage;
            //float yPos = 0;
            //int count = 0;
            //float leftMargin = ev.MarginBounds.Left;
            //float topMargin = ev.MarginBounds.Top;
            //String line = "";
            //linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            ////二维码
            //ev.Graphics.DrawImage(BarCodeClass.GenerateBarCode("VA39002434914-1-1-", MM2Inch(80), MM2Inch(16)), new Point(ev.MarginBounds.Left + 45, ev.MarginBounds.Top));
            ////单号
            //ev.Graphics.DrawString("VA39002434914-1-1-", boldFont, Brushes.Black, ev.MarginBounds.Left + 43, ev.MarginBounds.Top + 100);
            ////逐行画字
            //topMargin = topMargin + 125;
            //while (count < linesPerPage && ((line = sr.ReadLine()) != null))
            //{
            //    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            //    ev.Graphics.DrawString(line, printFont, Brushes.Black,
            //       leftMargin, yPos);
            //    count++;
            //}
            ////条形码
            //ev.Graphics.DrawImage(BarCodeClass.GenerateBarCode("VA39002434914", 50, 40), new Point(ev.MarginBounds.Left + 20, Convert.ToInt32(yPos) + 20));
            //// If more lines exist, print another page.
            //if (line != null)
            //    ev.HasMorePages = true;
            //else
            //    ev.HasMorePages = false;
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sb"></param>
        public static void PrintView()
        {
            try
            {
                //sr = new StringReader(sb.ToString());//文本
                PrintDocument pd = new PrintDocument();
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                pd.DefaultPageSettings.Margins.Top = 0;
                pd.DefaultPageSettings.Margins.Left = 0;
                pd.DefaultPageSettings.PaperSize = new PaperSize("customer", MM2Inch(100), MM2Inch(113));//设置打印区域
                pd.PrinterSettings.PrinterName = pd.DefaultPageSettings.PrinterSettings.PrinterName;//默认打印机
                pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.UseAntiAlias = true;//防锯齿
                dialog.Document = pd;//预览对象
                dialog.PrintPreviewControl.Zoom = 1.0;//默认比例百分之百
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //if (sr != null)
                //    sr.Close();
            }
        }


        /// <summary>
        /// 转换毫米到百分之一英寸
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        private static int MM2Inch(int mm)
        {
            return (int)(mm * 100.0f / 25.4f);
        }
    }
}
