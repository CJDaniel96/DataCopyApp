using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 420);

            lblTitle.Location = new Point(180, 40);
            lblTitle.AutoSize = true;
            lblTitle.Text = "資料自動轉存";
            lblTitle.Font = new Font("新細明體", 32, FontStyle.Regular);

            Filefo.Location = new Point(180, 185);
            Filefo.AutoSize = true;
            Filefo.Text = "檔案位置:";
            Filefo.Font = new Font("新細明體", 14, FontStyle.Regular);

            Filefotext.Location = new Point(320, 180);
            Filefotext.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            Filefotext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Filefotext.Font = new Font("新細明體", 10, FontStyle.Regular);
            Filefotext.Text = "";

            Fileto.Location = new Point(180, 235);
            Fileto.AutoSize = true;
            Fileto.Text = "存放位置:";
            Fileto.Font = new Font("新細明體", 14, FontStyle.Regular);

            Filetotext.Location = new Point(320, 230);
            Filetotext.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            Filetotext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Filetotext.Font = new Font("新細明體", 10, FontStyle.Regular);
            Filetotext.Text = "";

            Submit.Location = new Point(180, 300);
            Submit.AutoSize = true;
            Submit.Text = "確定";
            Submit.Visible = true;
            Submit.Enabled = true;

            Reset.Location = new Point(320, 300);
            Reset.AutoSize = true;
            Reset.Text = "重置";
            Reset.Visible = true;
            Reset.Enabled = true;

            Endexit.Location = new Point(460, 300);
            Endexit.AutoSize = true;
            Endexit.Text = "退出";
            Endexit.Visible = true;
            Endexit.Enabled = true;
        }

        private void Filefotext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Endexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否退出程式?", "資料自動轉存", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirfor;
            DirectoryInfo dirto;

            Filefotext.Text = "c:\\Users\\Daniel\\Downloads\\abc";
            Filetotext.Text = "d:\\";

            try
            {
                dirfor = new DirectoryInfo(Filefotext.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("請確實填寫路徑!!!");
                return;
            }

            if (!dirfor.Exists)
            {
                MessageBox.Show("請確實填寫路徑!!!");
                return;
            }

            try
            {
                dirto = new DirectoryInfo(Filetotext.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("目的路徑不存在!!!");
                if (MessageBox.Show("請問是否在桌面創建資料夾?", "資料自動轉存", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    dirfor = new DirectoryInfo(Filefotext.Text);
                    dirto = new DirectoryInfo("C:\\Users\\Daniel\\Desktop");
                    DataCopyApp(dirfor, dirto);
                    return;
                }
                else
                {
                    MessageBox.Show("請確實填寫路徑!!!");
                    return;
                }
            }

            if(Filefotext.Text != null && Filetotext.Text != null)
            {
                dirfor = new DirectoryInfo(Filefotext.Text);
                dirto = new DirectoryInfo(Filetotext.Text);
                DataCopyApp(dirfor, dirto);
            }
        }

        //資料自動轉存
        private void DataCopyApp(DirectoryInfo dirfordata, DirectoryInfo dirtodata)
        {
            FileInfo[] filefordata = dirfordata.GetFiles();
            DateTime[] filefortime = new DateTime[filefordata.Length];
            //將資料時間存入陣列
            for(int i = 0; i < filefordata.Length; i++)
            {
                filefortime[i] = filefordata[i].CreationTime.Date;
            }
            //將資料依時間排序
            filefortime = DateTimeBySort(filefortime);
            DirectoryInfo[] dirtime = new DirectoryInfo[filefortime.Length];

            for (int i = 0; i < filefortime.Length; i++)
            {
                dirtime[i] = Createdir(dirtodata, filefortime[i]);
                for(int j = 0; j < filefordata.Length; j++)
                {

                        filefordata[j].CopyTo(dirtime[i].FullName + "\\" + filefordata[j]);
                }
            }
        }

        //資料依時間由近到遠排序
        private DateTime[] DateTimeBySort(DateTime[] filefortime)
        {
            DateTime temp;

            for(int i = 0; i < filefortime.Length; i++)
            {
                for(int j = 0; j < filefortime.Length; j++)
                {
                    if(DateTime.Compare(filefortime[i], filefortime[j]) < 0)
                    {
                        temp = filefortime[i];
                        filefortime[i] = filefortime[j];
                        filefortime[j] = temp;
                    }
                }
            }

            return filefortime;
        }

        //創建新資料夾
        private DirectoryInfo Createdir(DirectoryInfo dirtodata, DateTime filetime)
        {
            string filetimepath = "\\" + filetime.ToString("yyyyMMdd");
            string dirtopath = dirtodata.ToString();
            string dirpath = dirtopath + filetimepath;
            DirectoryInfo newdir = Directory.CreateDirectory(dirpath);
            
            return newdir;
        }
    }
}