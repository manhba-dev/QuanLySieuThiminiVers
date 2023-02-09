using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DataLayer;
using System.Data.SqlClient;

namespace STOCK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("connectdb.dba"))
            {
                string conStr = "";
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
                connect cp = (connect)bf.Deserialize(fs);
                string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
                string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
                string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
                string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
                conStr += "Data Source=" + servername + "; Initial Catalog=" + database + " ; User ID=" + username +"; Password=" + pass + ";";
                connoi = conStr; 
                //myFunctions._srv = servername;
                //myFunctions._us = username;
                //myFunctions._pw = pass;
                //myFunctions._db = database;
                SqlConnection con = new SqlConnection(conStr);
                try
                {
                    con.Open();
                    
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fs.Close();
                }
                con.Close();
                fs.Close();
                Application.Run(new frmLogin());
            }
            else
            {
                Application.Run(new frmConnect());
            }
        }
        
        public static string connoi = "";
    }
}
