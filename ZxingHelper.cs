using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using ZXing;
using ZXing.QrCode;

namespace ZXingDemo
{
    public class ZxingHelper
    {
        public static void Generate1(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //设置二维码的宽度和高度
            options.Width = 200;
            options.Height = 200;
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            writer.Options = options;

            Bitmap map = writer.Write(text);
            string data = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filename = @"E:\Visual Studio\repos\ZXingDemo\ZXingDemo\Image\" + data + ".png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }
    }
}