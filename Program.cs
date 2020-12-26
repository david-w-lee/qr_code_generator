using System;
using ZXing;

namespace qr_code_generator
{
    class Program
    {

        private void QRCodeUrlTest()
        {
            string filename = "QRCodeUrlGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.QR_CODE, "https://www.msn.com/", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        private void QRCodeSmsTest()
        {
            string filename = "QRCodeSmsGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.QR_CODE, "SMSTO:+1112223333:Hello!", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        private void QRCodePhoneTest()
        {
            string filename = "QRCodeTelGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.QR_CODE, "tel:+1112223333", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        private void QRCodeMailTest()
        {
            string filename = "QRCodeMailGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.QR_CODE, "mailto:blah@hotmail.com", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        private void UPC_A_CodeTest()
        {
            string filename = "UpcACodeGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.UPC_A, "012345678912", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }
        private void UPC_E_CodeTest()
        {
            string filename = "UpcECodeGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.UPC_E, "12345670", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        private void EAN_13_CodeTest()
        {
            string filename = "Ean13CodeGenerated.png";
            QRCodeUtil.CreateFile(BarcodeFormat.EAN_13, "5701234567899", filename);
            var res = QRCodeUtil.GetContent(filename);

            Console.WriteLine($"Content: {res.Text}");
            Console.WriteLine($"Format: {res.BarcodeFormat}");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.QRCodeUrlTest();

            Console.ReadLine();
        }
    }
}
