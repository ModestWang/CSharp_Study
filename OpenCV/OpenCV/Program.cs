using OpenCvSharp;
using OpenCvSharp.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCV
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一张大小为300*300颜色为绿色的三通道彩色图像
            Mat img = new Mat(300, 300, MatType.CV_8UC3, new Scalar(0, 255, 0));
            //显示图像
            Cv2.ImShow("img", img);
            //延时等待按键按下
            Cv2.WaitKey(0);
        }
    }
}
