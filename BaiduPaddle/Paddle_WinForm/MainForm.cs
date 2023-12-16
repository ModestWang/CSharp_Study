namespace Paddle_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.*|*.bmp;*.jpg;*.jpeg;*.tiff;*.tiff;*.png";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //使用默认中英文V4模型
            PaddleOCRSharp.OCRModelConfig config = null;
            //使用默认参数
            PaddleOCRSharp.OCRParameter oCRParameter = new PaddleOCRSharp.OCRParameter();
            //识别结果对象
            PaddleOCRSharp.OCRResult ocrResult = new PaddleOCRSharp.OCRResult();
            //建议程序全局初始化一次即可，不必每次识别都初始化，容易报错。     
            PaddleOCRSharp.PaddleOCREngine engine = new PaddleOCRSharp.PaddleOCREngine(config, oCRParameter);
            {
                ocrResult = engine.DetectText(ofd.FileName);
            }
            if (ocrResult != null)
            {
                //MessageBox.Show(ocrResult.Text, "识别结果");
                outputBox.Text = "识别结果：\n" + ocrResult.Text;
            }
        }
    }
}
