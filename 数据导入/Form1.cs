using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据导入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = ExcelSqlConnection("c:\\线路数据录入模版.xlsx", "国内线路");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                DataRow rs = dt.Rows[1];
            }
        }
        /// <summary>
        /// 连接Excel  读取Excel数据   并返回DataSet数据集合
        /// </summary>
        /// <param name="filepath">Excel服务器路径</param>
        /// <param name="tableName">Excel表名称</param>
        /// <returns></returns>
        public static System.Data.DataSet ExcelSqlConnection(string filepath, string tableName)
        {
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //此連接可以操作.xls與.xlsx文件
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataSet ds = new DataSet();
            //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等    
            DataTable dtSheetName = conn.GetOleDbSchemaTable(
            OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

            //包含excel中表名的字符串数组  
            string[] strTableNames = new string[dtSheetName.Rows.Count];
            for (int k = 0; k < dtSheetName.Rows.Count; k++)
            {
                strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
            }
            OleDbDataAdapter odda = new OleDbDataAdapter("select * from [" + strTableNames[0].ToString() + "]", conn); //("select * from [Sheet1$]", conn);
            odda.Fill(ds, "[" + tableName + "$]");
            conn.Close();
            return ds;
        }

    }
}
