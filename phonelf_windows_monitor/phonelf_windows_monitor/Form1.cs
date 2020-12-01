using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using SimpleTCP;
using System.Text.RegularExpressions;
using System.IO;

namespace phonelf_windows_monitor
{
    public partial class Form1 : Form
    {

        //全域變數
        int[] hhmmss = { 0, 0, 0, 0, 0, 0 };
        public int[] dai = { 0, 0, 0, 0 };
        public string das = "NP";

        public Form1()
        {
            InitializeComponent();
            StartTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            file_des.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);/*預設路徑*/
        }

        //timmer

        System.Windows.Forms.Timer t = null;

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        int count_renew_time = 0;
        void t_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            hhmmss[0] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 1, 1));
            hhmmss[1] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 2, 1));
            hhmmss[2] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 4, 1));
            hhmmss[3] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 5, 1));
            hhmmss[4] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 7, 1));
            hhmmss[5] = int.Parse(lblTime.Text.Substring(lblTime.Text.Length - 8, 1));
            hhmmssSHOW.Text = hhmmss[5].ToString() + hhmmss[4].ToString() + hhmmss[3].ToString() + hhmmss[2].ToString() + hhmmss[1].ToString() + hhmmss[0].ToString();
            if (able_time_new.Checked){
                if (count_renew_time >= renewTI.Value)
                {
                    conS.Text = "";
                    count_renew_time = 0;
                }
                else
                {
                    count_renew_time++;
                }
            }
        }

        //TCP server
        SimpleTcpServer server;
        
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            conS.Invoke((MethodInvoker)delegate ()
            {
                conS.Text += e.MessageString;
                e.ReplyLine(STARTTHING.Text+das+hhmmssSHOW.Text + String.Format("{0:00000}", Convert.ToInt32(dai[0])) + String.Format("{0:00000}", Convert.ToInt32(dai[1])) + String.Format("{0:00000}", Convert.ToInt32(dai[2])) + String.Format("{0:00000}", Convert.ToInt32(dai[3])) + EndTHING.Text);
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            dai[i] = 0;
                            break;
                        case 1:
                            dai[i] = 0;
                            break;
                        case 2:
                            dai[i] = 0;
                            break;
                        case 3:
                            dai[i] = 0;
                            break;
                        default:
                            break;
                    }
                }
                das = "NP";
            });
        }

        private void SVon_Click(object sender, EventArgs e)
        {
            //Start server host
            conS.Text += "Server starting...";
            ipSHOW.Text=GetLocalIP();
            SVsat.Text = "start";
            System.Net.IPAddress ip = (use_local_ip.Checked)? System.Net.IPAddress.Parse(user_ip_inp.Text) : System.Net.IPAddress.Parse(GetLocalIP());
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void svCLS_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                SVsat.Text = "stop";
            }
        }
        /// <summary>
        /// 獲取當前使用的IP
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP()
        {
            string result = RunApp("route", "print", true);
            Match m = Regex.Match(result, @"0.0.0.0\s+0.0.0.0\s+(\d+.\d+.\d+.\d+)\s+(\d+.\d+.\d+.\d+)");
            if (m.Success)
            {
                return m.Groups[2].Value;
            }
            else
            {
                try
                {
                    System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
                    c.Connect("www.baidu.com", 80);
                    string ip = ((System.Net.IPEndPoint)c.Client.LocalEndPoint).Address.ToString();
                    c.Close();
                    return ip;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 獲取本機主DNS
        /// </summary>
        /// <returns></returns>
        public static string GetPrimaryDNS()
        {
            string result = RunApp("nslookup", "", true);
            Match m = Regex.Match(result, @"\d+\.\d+\.\d+\.\d+");
            if (m.Success)
            {
                return m.Value;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 執行一個控制檯程式並返回其輸出引數。
        /// </summary>
        /// <param name="filename">程式名</param>
        /// <param name="arguments">輸入引數</param>
        /// <returns></returns>
        public static string RunApp(string filename, string arguments, bool recordLog)
        {
            try
            {
                if (recordLog)
                {
                    Trace.WriteLine(filename + " " + arguments);
                }
                Process proc = new Process();
                proc.StartInfo.FileName = filename;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = arguments;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();
                using (System.IO.StreamReader sr = new System.IO.StreamReader(proc.StandardOutput.BaseStream, Encoding.Default))
                {
                    //string txt = sr.ReadToEnd();
                    //sr.Close();
                    //if (recordLog)
                    //{
                    // Trace.WriteLine(txt);
                    //}
                    //if (!proc.HasExited)
                    //{
                    // proc.Kill();
                    //}
                    //上面標記的是原文，下面是我自己除錯錯誤後自行修改的
                    Thread.Sleep(100);  //貌似呼叫系統的nslookup還未返回資料或者資料未編碼完成，程式就已經跳過直接執行
                                        //txt = sr.ReadToEnd()了，導致返回的資料為空，故睡眠令硬體反應
                    if (!proc.HasExited)  //在無引數呼叫nslookup後，可以繼續輸入命令繼續操作，如果程序未停止就直接執行
                    {    //txt = sr.ReadToEnd()程式就在等待輸入，而且又無法輸入，直接掐住無法繼續執行
                        proc.Kill();
                    }
                    string txt = sr.ReadToEnd();
                    sr.Close();
                    if (recordLog)
                        Trace.WriteLine(txt);
                    return txt;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                return ex.Message;
            }
        }

        private void satBOXsub_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        dai[i] = int.Parse(da1.Text);
                break;
                    case 1:
                        dai[i] = int.Parse(da2.Text);
                        break;
                    case 2:
                        dai[i] = int.Parse(da3.Text);
                        break;
                    case 3:
                        dai[i] = int.Parse(da4.Text);
                        break;
                    default:
                        break;
                }
            }
            das = da0.Text;
        }

        private void gui_fly_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        da1.Text = "0";
                        dai[i] = int.Parse(da1.Text);
                        break;
                    case 1:
                        da2.Text = "0";
                        dai[i] = int.Parse(da2.Text);
                        break;
                    case 2:
                        da3.Text = "0";
                        dai[i] = int.Parse(da3.Text);
                        break;
                    case 3:
                        da4.Text = "0";
                        dai[i] = int.Parse(da4.Text);
                        break;
                    default:
                        break;
                }
            }
            da0.Text = "ST";
            das = da0.Text;
        }

        private void gui_mt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        da1.Text = "0";
                        dai[i] = int.Parse(da1.Text);
                        break;
                    case 1:
                        da2.Text = "0";
                        dai[i] = int.Parse(da2.Text);
                        break;
                    case 2:
                        da3.Text = "0";
                        dai[i] = int.Parse(da3.Text);
                        break;
                    case 3:
                        da4.Text = "0";
                        dai[i] = int.Parse(da4.Text);
                        break;
                    default:
                        break;
                }
            }
            da0.Text = "TT";
           
            das = da0.Text;
        }

        private void gui_set_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        da1.Text = "0";
                        dai[i] = int.Parse(da1.Text);
                        break;
                    case 1:
                        da2.Text = "0";
                        dai[i] = int.Parse(da2.Text);
                        break;
                    case 2:
                        da3.Text = "0";
                        dai[i] = int.Parse(da3.Text);
                        break;
                    case 3:
                        da4.Text = "0";
                        dai[i] = int.Parse(da4.Text);
                        break;
                    default:
                        break;
                }
            }
            da0.Text = "MS";
            
            das = da0.Text;
        }

        private void gui_stb_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        da1.Text = "0";
                        dai[i] = int.Parse(da1.Text);
                        break;
                    case 1:
                        da2.Text = "0";
                        dai[i] = int.Parse(da2.Text);
                        break;
                    case 2:
                        da3.Text = "0";
                        dai[i] = int.Parse(da3.Text);
                        break;
                    case 3:
                        da4.Text = "0";
                        dai[i] = int.Parse(da4.Text);
                        break;
                    default:
                        break;
                }
            }
            da0.Text = "SB";
            das = da0.Text;
        }

        private void clone_ip_Click(object sender, EventArgs e)
        {
            user_ip_inp.Text = ipSHOW.Text;
        }

        private void checkip_Click(object sender, EventArgs e)
        {
            if (use_local_ip.Checked)
            {

            }
            else
            {
                ipSHOW.Text = GetLocalIP();
            }
        }

        public bool WriteOut(String thingToWriteIn)
        {

            string FileName = file_des.Text;
            if (System.IO.File.Exists(FileName))
            {
                using (System.IO.StreamWriter sw = File.AppendText(FileName))
                {
                    sw.WriteLine(thingToWriteIn);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(FileName))
                {
                    sw.WriteLine(thingToWriteIn);
                }
            }
            return true;
        }

        private void file_des_Click(object sender, EventArgs e)
        {
            //no move
        }

        private void use_local_ip_CheckedChanged(object sender, EventArgs e)
        {
            user_ip_inp.Enabled = (use_local_ip.Checked) ? true : false;
        }

        private string OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //移動上層在指定下層路徑
            dlg.RestoreDirectory = true;
            //dlg.InitialDirectory = dir.Parent.Parent.FullName + @"\ModelImages";
            dlg.Title = "Open Txt File";

            // Set filter for file extension and default file extension
            dlg.Filter = "Text File | *.txt";

            // Display OpenFileDialog by calling ShowDialog method ->ShowDialog()
            // Get the selected file name and display in a TextBox
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != null)
            {
                // Open document
                string filename = dlg.FileName;
                return filename;
            }
            else
            {
                return null;
            }

        }

        private void file_sel_Click(object sender, EventArgs e)
        {
            file_des.Text = OpenFile();
        }

        /*TODO:
         * 多執行敘後送
         * cmd ip check
         */
    }
}
