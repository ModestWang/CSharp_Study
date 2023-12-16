using System.Net;
using System.Text;

namespace QR
{
    public class QQ
    {
        public static void SendTo(
            string your_username = "1598593280",
            string your_password = "",
            string your_auth_token = "",
            string friend_qq_id = "208282594",
            string path_to_your_file = "../../../Baidu_QRCode.jpg"
        )
        {
            // 登录QQ
            string username = your_username;
            string password = your_password;
            string loginUrl = "https://api.qq.com/login";

            // 使用HttpWebRequest发送登录请求
            HttpWebRequest loginRequest = (HttpWebRequest)WebRequest.Create(loginUrl);
            loginRequest.Method = "POST";
            loginRequest.ContentType = "application/x-www-form-urlencoded";

            string postData = "username=" + username + "&password=" + password;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            loginRequest.ContentLength = byteArray.Length;

            using (Stream dataStream = loginRequest.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse loginResponse = (HttpWebResponse)loginRequest.GetResponse();
            string loginResult = "";

            using (Stream responseStream = loginResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                loginResult = reader.ReadToEnd();
            }

            // 解析登录结果，获取登录凭证
            string authToken = your_auth_token;

            // 发送文件给好友
            string friendId = friend_qq_id;
            string fileUrl = "https://api.qq.com/sendfile?auth=" + authToken + "&friendId=" + friendId;
            string filePath = path_to_your_file;

            // 使用HttpWebRequest发送文件
            HttpWebRequest fileRequest = (HttpWebRequest)WebRequest.Create(fileUrl);
            fileRequest.Method = "POST";
            fileRequest.ContentType = "multipart/form-data";

            using (FileStream fileStream = File.OpenRead(filePath))
            {
                using (Stream requestStream = fileRequest.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                }
            }

            HttpWebResponse fileResponse = (HttpWebResponse)fileRequest.GetResponse();
            string fileResult = "";

            using (Stream responseStream = fileResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                fileResult = reader.ReadToEnd();
            }

            Console.WriteLine("File sent successfully!");
        }
    }
}