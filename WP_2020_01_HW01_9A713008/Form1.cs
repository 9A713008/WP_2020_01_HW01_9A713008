using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WP_2020_01_HW01_9A713008
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

       //int Index = GetHashIndexByMod();
       
        private void btnGo1_Click(object sender, EventArgs e)
        {  
            tB2.Text = GetMD5(tB1.Text);
            MessageBox.Show("888"/* + Index*/);
            




        }
        private int GetHashIndexByMod(string inputString, int modNum = 16)
        {
            MD5 md5 = MD5.Create();//建立一個MD5
            byte[] source = Encoding.Default.GetBytes(inputString);//將字串轉為Byte[]
            byte[] crypto = md5.ComputeHash(source);//進行MD5加密
            string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串

            int value = (int)crypto[0];
            return value % modNum;  //0~15 
        }

        public string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}
