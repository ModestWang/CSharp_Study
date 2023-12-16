namespace QR
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyQRCode.CreateQRCode
                ("https://github.com/ModestWang", "MyGithub_QRCode");

            MyQRCode.CreateQRCode
                ("https://www.baidu.com", "Baidu_QRCode");

            MyQRCode.CreateQRCode
                ("https://one.hfut.edu.cn/home/index", "HFUT信息门户_QRCode");

        }
    }
}