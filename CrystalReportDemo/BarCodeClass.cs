using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace CrystalReportDemo
{
    public static class BarCodeClass
    {
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="Contents"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap GenerateBarCode(string Contents, int width, int height)
        {
            if (String.IsNullOrEmpty(Contents))
            {
                MessageBox.Show("请输入需要编码的内容");
                return null;
            }
            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = width,
                Height = height,
                PureBarcode = true,
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = options;
            Bitmap bitmap = writer.Write(Contents);
            return bitmap;
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="Contents"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static Bitmap GenerateQuickMark(string Contents, int width, int height)
        {
            if (String.IsNullOrEmpty(Contents))
            {
                MessageBox.Show("输入内容不能为空！");
                return null;
            }
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            EncodingOptions options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = width,
                Height = height,
                Margin = 1
            };
            writer.Options = options;
            Bitmap bitmap = writer.Write(Contents);
            return bitmap;
        }

    }
}
