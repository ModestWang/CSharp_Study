using PaddleOCRSharp;

namespace BaiduPaddle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OCRModelConfig config = null;
            OCRParameter oCRParameter = new OCRParameter();
            OCRResult ocrResult = new OCRResult();

            using (PaddleOCREngine engine = new PaddleOCREngine(config, oCRParameter))
            {
                string image = "test.png";
                ocrResult = engine.DetectText("../../../../Images" + image);
                if (ocrResult != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(ocrResult.Text);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Successfully!");
        }
    }
}