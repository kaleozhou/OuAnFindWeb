using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Web
{
    public class MobileSMS
    {

        #region www.56dxw.com 发送短信
        //添加服务引用  http://jiekou.56dxw.com/WebServiceInterface.asmx  
        //输入命名空间：MobileMessage_56  
        private MobileMessage_56.WebServiceInterfaceSoapClient _ws_56 = null;

        /// <summary>  
        /// www.56dxw.com短信接口服务  
        /// </summary>  
        public MobileMessage_56.WebServiceInterfaceSoapClient ws_56
        {
            get
            {
                if (_ws_56 == null) _ws_56 = new MobileMessage_56.WebServiceInterfaceSoapClient();
                return _ws_56;
            }
        }

        private string username_56 = "test2";//网站的用户名  
        private string password_56 = "test2212";//网站的登陆密码  
        private string cid_56 = "70";//企业id  

        /// <summary>  
        /// 发送短信接口函数 www.56dxw.com  
        /// </summary>  
        /// <param name="mobilenumber">手机号英文半角逗号隔开,一次1000个以内</param>  
        /// <param name="message">信息内容</param>  
        /// <returns>  
        /// -1  用户名密码不正确  
        ///-2   内容不能大于70个字  
        ///-3   验证此平台是否存在  
        ///-4   提交号码不能为空或客户余额为0  
        ///-5   客户剩余条数不够要发送的短信数量  
        ///-6   非法短信内容  
        ///-7   返回系统故障  
        ///-8   网络性错误，请稍后再试  
        ///1    代表发送成功  
        /// </returns>  
        public int SendMSG_56(string mobilenumber, string message)
        {
            string sendtime = "";//格式："2010-1-27 11:10:20"---发送时间，为空则立即发送  
            string smsnumber = "10690";//平台  
            string username = "test2";
            string password = "test2212";
            string cid = "70";
            return ws_56.SendNote(mobilenumber, message, username, password, cid, sendtime, smsnumber);
        }


        /// <summary>  
        /// 查询剩余短信条数  
        /// </summary>  
        /// <returns>  
        /// -1  代表用户名密码不正确  
        /// 其它值 代表返回具体条数  
        /// </returns>  
        public int ReturnUserFullMoney_56()
        {
            return ws_56.ReturnUserFullMoney(username_56, password_56, cid_56);
        }

        /// <summary>  
        /// 修改密码  
        /// </summary>  
        /// <param name="oldpwd">旧密码</param>  
        /// <param name="newpwd">新密码</param>  
        /// <returns>  
        /// 1   代表密码修改成功  
        /// -1  代表密码编辑失败  
        /// -2  用户名密码错误  
        /// </returns>  
        public int EditUserPwd(string oldpwd, string newpwd)
        {
            return ws_56.EditUserPwd(username_56, oldpwd, newpwd, cid_56);
        }

        #endregion  

        #region 悠逸企业短信平台
        public static bool SendMobileMsg(string msgContent, List<string> destListPhones)
        {
            try
            {
                bool result = false;
                string strPhones = string.Join(";", destListPhones.ToArray());
                strPhones += ";";
                var encoding = System.Text.Encoding.GetEncoding("GB2312");
  
                string postData = string.Format("uid=用户名&pwd=密码&mobile={0};&msg={1}&dtime=", strPhones, msgContent);
 
                byte[] data = encoding.GetBytes(postData);
 
                // 定义 WebRequest
                HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create("http://www.smsadmin.cn/smsmarketing/wwwroot/api/post_send/");
 
                myRequest.Method = "POST";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentLength = data.Length;
 
                Stream newStream = myRequest.GetRequestStream();
 
                //发送数据
                newStream.Write(data, 0, data.Length);
                newStream.Close();
 
                // 得到 Response
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.Default);
                string content = reader.ReadToEnd();
 
                if (content.Substring(0, 1) == "0")
                    result = true;
                else
                {
                    if (content.Substring(0, 1) == "2") //余额不足
                    {
                    //"手机短信余额不足";
                    //TODO
                    }
                    else
                    {
                    //短信发送失败的其他原因，请参看官方API
                    }
                    result = false;
                }
 
                return result;
            }
            catch
            {
                return false;
            }
         
        }
        #endregion


    }
}