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

namespace RFID_WhiteList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            readWhiteList();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        { 
            saveWhiteList();
        }

        void saveWhiteList()
        {
            string filePath = "whitelist.txt";

            // 檢查檔案是否存在
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }

            // 清空 whitelist
            File.WriteAllText(filePath, "");
            Console.WriteLine("[-] 清空白名單：\r\n" + File.ReadAllText(filePath));

            Console.WriteLine("[*] 寫入白名單 {0} 筆紀錄", listBox.Items.Count);
            string[] IDs = new string[listBox.Items.Count];
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                //textResponse.AppendText("[+] " + comboCardId.Items[i] + "\r\n");
                Console.WriteLine("[+] " + listBox.Items[i]);
                IDs[i] = listBox.Items[i].ToString();
            }

            File.WriteAllLines(filePath, IDs);
        }

        void readWhiteList()
        {
            string filePath = "whitelist.txt"; // 檔案路徑

            // 檢查檔案是否存在
            if (!File.Exists(filePath))
            {
                //Console.WriteLine("檔案不存在，正在建立檔案...");

                // 自動建立檔案並寫入預設內容
                File.WriteAllText(filePath, "");
                //Console.WriteLine("檔案已建立。");
            }

            // 讀取檔案內容
            string[] fileContent = File.ReadAllLines(filePath);
            //textResponse.AppendText("[*] 讀取白名單");

            listBox.Items.Clear();

            foreach (string line in fileContent)
            {
                if (line.Trim() == "" || line.Trim().Length != 8) continue;
                //textResponse.AppendText("[+] " + line + "\r\n");
                listBox.Items.Add(line);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            textBox.Text = listBox.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(textBox.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains(textBox.Text)) {
                MessageBox.Show("紀錄已存在","錯誤");
                return;
            }

            listBox.Items.Add(textBox.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "") { 
                btnAdd.Enabled = false;
            }
            if (!listBox.Items.Contains(textBox.Text))
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
