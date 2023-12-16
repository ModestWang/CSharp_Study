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
            //ʹ��Ĭ����Ӣ��V4ģ��
            PaddleOCRSharp.OCRModelConfig config = null;
            //ʹ��Ĭ�ϲ���
            PaddleOCRSharp.OCRParameter oCRParameter = new PaddleOCRSharp.OCRParameter();
            //ʶ��������
            PaddleOCRSharp.OCRResult ocrResult = new PaddleOCRSharp.OCRResult();
            //�������ȫ�ֳ�ʼ��һ�μ��ɣ�����ÿ��ʶ�𶼳�ʼ�������ױ���     
            PaddleOCRSharp.PaddleOCREngine engine = new PaddleOCRSharp.PaddleOCREngine(config, oCRParameter);
            {
                ocrResult = engine.DetectText(ofd.FileName);
            }
            if (ocrResult != null)
            {
                //MessageBox.Show(ocrResult.Text, "ʶ����");
                outputBox.Text = "ʶ������\n" + ocrResult.Text;
            }
        }
    }
}
