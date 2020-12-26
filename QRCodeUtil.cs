using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace qr_code_generator
{
    public class QRCodeUtil
    {
        public static Result GetContent(string filename)
        {
            var barcodeReader = new BarcodeReader();

            var barcodeBitmap = new Bitmap(filename);

            var barcodeResult = barcodeReader.Decode(barcodeBitmap);

            return barcodeResult;
        }

        public static void CreateFile(BarcodeFormat format, string content, string filename)
        {
            var barcodeWriter = new BarcodeWriter();

            barcodeWriter.Format = format;
            barcodeWriter.Options = new QrCodeEncodingOptions
            {
                Margin = 1,
                Height = 200,
                Width = 200,
                ErrorCorrection = ErrorCorrectionLevel.Q
            };

            var bitmap = barcodeWriter.Write(content);

            bitmap.Save(filename, ImageFormat.Png);
        }
    }
}
