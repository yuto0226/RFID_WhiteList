using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RFID_WhiteList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setConnectState(false);
            readWhiteList();
            if (TestAndConnect()) {
                textResponse.AppendText("[+] 讀卡機連線成功\r\n");
            }
        }

        string ConsoleText = string.Empty;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPortRFID.IsOpen)
            {
                closePort(); // 確保串列埠被正確關閉
            }
            saveWhiteList();
            Console.WriteLine("[-] 視窗關閉\r\n");
        }
        
        /* Utility */
        private byte[] hexStringToByte(string hexString)
        {
            byte[] returnedBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnedBytes.Length; i++)

                returnedBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

            return returnedBytes;
        }

        private String byteToHexString(byte[] buffer)
        {
            String hexString = "";

            for (int i = 0; i < buffer.Length; i++)
                hexString += buffer[i].ToString("X2"); //將資料先轉16進位

            return hexString;
        }

        bool checkConnection()
        {
            bool state = serialPortRFID.IsOpen;
            setConnectState(state);
            return state;
        }

        void setConnectState(Boolean s)
        {
            if (s)
            {
                labelStatusIcon.Text = "●";
                labelStatusIcon.ForeColor = Color.FromArgb(64, 160, 43); // Color.Green;
                labelStatusText.Text = "讀卡機連線成功";

                comboCOM.Enabled = false;
                textCommand.Enabled = true;
                btnSendCommand.Enabled = true;

                btnConnect.Text = "斷線";
            }
            else
            {
                labelStatusIcon.Text = "×";
                labelStatusIcon.ForeColor = Color.FromArgb(210, 15, 57); //Color.Red;
                labelStatusText.Text = "讀卡機連線失敗";

                comboCOM.Enabled = true;
                textCommand.Enabled = false;
                btnSendCommand.Enabled = false;

                textCardID.Text = "";
                labelIdStatus.Text = "-";
                labelIdStatus.ForeColor = Color.Gainsboro;
                btnAddCardId.Enabled = false;
                btnRemoveCardId.Enabled = false;

                labelCardAccess.Text = "---";
                labelCardAccess.ForeColor = Color.Black;

                btnConnect.Text = "連線";
            }
        }

        void setCardState(bool s) {
            if (s)
            {
                labelIdStatus.Text = "●";
                labelIdStatus.ForeColor = Color.FromArgb(64, 160, 43);
            }
            else
            {
                labelCardStatusHint.Text = "卡片讀取失敗";
                labelCardStatusHint.ForeColor = Color.FromArgb(210, 15, 57);

                labelIdStatus.Text = "×";
                labelIdStatus.ForeColor = Color.FromArgb(210, 15, 57);
                textCardID.Text = "None";

                labelCardAccess.Text = "---";
                labelCardAccess.ForeColor = Color.Black;
            }
        }

        int openPort(string comName)
        {
            if (serialPortRFID.IsOpen) return 1;
            System.Console.WriteLine("[+] Port opening.");
            serialPortRFID.PortName = comName;
            try
            {
                serialPortRFID.Open();
                setConnectState(true);
            }
            catch (Exception err)
            {
                System.Console.WriteLine("[-] " + err.Message);
                setConnectState(false);
                return 0;
            }
            return 1;
        }

        void closePort()
        {
            if (!serialPortRFID.IsOpen) return;
            System.Console.WriteLine("[-] Port closing.");
            try
            {
                serialPortRFID.Close();
            }
            catch (Exception err)
            {
                System.Console.WriteLine("[-] " + err.Message);
                textResponse.AppendText("[-] " + err.Message + "\r\n");
                return;
            }
            setConnectState(false);
            setCardState(false);
        }

        bool TestAndConnect() {
            // test which com to connect
            for (int i = 0; i < 20; i++)
            {
                openPort("COM" + i);
                if (serialPortRFID.IsOpen)
                {
                    setConnectState(true);
                    comboCOM.Text = "COM" + i;
                    Console.WriteLine("[+] " + comboCOM.Text + " successfully opened.\r\n");
                    return true;
                }
            }
            return false;
        }

        byte[] readByte(int size)
        {
            byte[] bufferR = new byte[size];

            try
            {
                serialPortRFID.DiscardInBuffer();
                serialPortRFID.ReadTimeout = 1000;
                System.Threading.Thread.Sleep(100);
                serialPortRFID.Read(bufferR, 0, bufferR.Length);
                //updateStatusCode(bufferR[0]);
            }
            catch (Exception err)
            {
                textResponse.AppendText("[-] " + err.Message + "\r\n");
            }
            return bufferR;
        }

        void writeByte(byte[] bufferW)
        {
            if (!checkConnection()) return;
            try
            {
                serialPortRFID.Write(bufferW, 0, bufferW.Length);
            }
            catch (Exception err)
            {
                textResponse.AppendText("[-] " + err.Message + "\r\n");
            }
        }

        void setStatusBit(System.Windows.Forms.TextBox t, int b)
        {
            if (b != 0)
            {
                t.Text = "1";
                t.BackColor = Color.FromArgb(166, 209, 137);
            }
            else
            {
                t.Text = "0";
                t.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        void updateStatusCode(byte code)
        {
            //System.Console.WriteLine("Status code: 0x{0:X}", code);
            setStatusBit(statusBit0, code & (1 << 0));
            setStatusBit(statusBit1, code & (1 << 1));
            setStatusBit(statusBit2, code & (1 << 2));
            setStatusBit(statusBit3, code & (1 << 3));
            setStatusBit(statusBit4, code & (1 << 4));
            setStatusBit(statusBit5, code & (1 << 5));
            setStatusBit(statusBit6, code & (1 << 6));
            setStatusBit(statusBit7, code & (1 << 7));
        }

        void saveWhiteList() {
            string filePath = "whitelist.txt";

            // 檢查檔案是否存在
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }

            // 清空 whitelist
            File.WriteAllText(filePath, "");
            Console.WriteLine("[-] 清空白名單：\r\n" + File.ReadAllText(filePath));

            Console.WriteLine("[*] 寫入白名單 {0} 筆紀錄", comboCardId.Items.Count);
            string[] IDs = new string[comboCardId.Items.Count];
            for (int i = 0; i < comboCardId.Items.Count; i++)
            {
                //textResponse.AppendText("[+] " + comboCardId.Items[i] + "\r\n");
                Console.WriteLine("[+] " + comboCardId.Items[i]);
                IDs[i] = comboCardId.Items[i].ToString();
            }

            File.WriteAllLines(filePath, IDs);
        }

        void readWhiteList() {
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
            //Console.WriteLine("檔案內容如下：");
            Console.WriteLine("[*] 讀取白名單\r\n");

            comboCardId.Items.Clear();

            foreach (string line in fileContent)
            {
                if (line.Trim() == "" || line.Trim().Length != 8) continue;
                Console.WriteLine("[+] " + line + "\r\n");
                comboCardId.Items.Add(line);
            }
        }

        byte[] sendCommand(string c) {
            byte[] bufferW = hexStringToByte(c);
            writeByte(bufferW);

            byte[] bufferR = readByte(16);
            return bufferR;
        }

        /* UI functions */
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPortRFID.IsOpen)
            {
                textResponse.AppendText("[+] 中斷讀卡機連線\r\n");
                closePort();
                return;
            }

            if (comboCOM.Text == "" || comboCOM.Text == "懶得找 COM")
            {
                if (TestAndConnect())
                {
                    textResponse.AppendText("[+] 讀卡機連線成功\r\n");
                }
                else
                { 
                    textResponse.AppendText("[+] 讀卡機連線失敗\r\n");
                }
                return;
            }

            // 無法連線
            if (openPort(comboCOM.Text) == 0)
            {
                MessageBox.Show("無法與 " + comboCOM.Text + " 連線", "連線錯誤", MessageBoxButtons.OK, MessageBoxIcon.None);
                textResponse.AppendText("無法與 " + comboCOM.Text + " 連線\r\n");
                setConnectState(false);
                return;
            }

            if (serialPortRFID.IsOpen)
            {
                textResponse.AppendText("[+] " + comboCOM.Text + " successfully opened.\r\n");
                setConnectState(true);
            }
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            if (textCommand.Text == "") return;
            textResponse.AppendText("[+] data writing: " + textCommand.Text + "\r\n");
            System.Console.WriteLine("[+] data writing: " + textCommand.Text);
            byte[] data = sendCommand(textCommand.Text);
            textCommand.Text = "";
            string res = byteToHexString(data);
            updateStatusCode(data[0]);
            textResponse.AppendText("[+] data received: 0x" + res.Substring(0, 8) + "\r\n");
        }

        private void textCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // 阻止按鍵的預設行為

                if (textCommand.Text == "") return;
                textResponse.AppendText("[+] data writing: " + textCommand.Text + "\r\n");
                System.Console.WriteLine("[+] data writing: " + textCommand.Text);
                byte[] data = sendCommand(textCommand.Text);
                string res = byteToHexString(data);
                updateStatusCode(data[0]);
                textResponse.AppendText("[+] data received: 0x" + res.Substring(0, 8) + "\r\n");
                textCommand.Text = "";
            }

            if (e.Control && e.KeyCode == Keys.L) {
                e.Handled = true;
                e.SuppressKeyPress = true; // 阻止按鍵的預設行為

                textResponse.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Console.WriteLine("[+] Timer start.");
            if (!serialPortRFID.IsOpen)
            {
                setConnectState(false);
                setCardState(false);
                return;
            }

            byte[] bufferR = sendCommand("55");
            if (bufferR[0] == 0x86)
            {
                if (textCardID.Text == "None") updateStatusCode(bufferR[0]);
                string res = byteToHexString(bufferR);
                textCardID.Text = res.Substring(2,8);
                setCardState(true);

                // 比對卡片有無在清單內
                if (textCardID.Text != "None" && comboCardId.Items.Contains(textCardID.Text))
                {
                    labelCardStatusHint.Text = "卡片已經在清單裡面了";
                    labelCardStatusHint.ForeColor = Color.FromArgb(210, 15, 57);
                    btnAddCardId.Enabled = false;
                    btnRemoveCardId.Enabled = true;

                    comboCardId.Text = textCardID.Text;

                    labelCardAccess.Text = "○ 可以進入";
                    labelCardAccess.ForeColor = Color.FromArgb(64, 160, 43);
                }
                else {
                    labelCardStatusHint.ForeColor = Color.FromArgb(64, 160, 43);
                    labelCardStatusHint.Text = "卡片可以加入清單";
                    btnAddCardId.Enabled = true;
                    btnRemoveCardId.Enabled = false;

                    labelCardAccess.Text = "× 禁止進入";
                    labelCardAccess.ForeColor = Color.FromArgb(210, 15, 57);
                }
            }
            else
            {
                setCardState(false);
            }
        }

        private void btnRemoveCardId_Click(object sender, EventArgs e)
        {
            if (!comboCardId.Items.Contains(textCardID.Text))
            {
                textResponse.AppendText("[-] Card ID:" + textCardID.Text + " didn't exist.\r\n");
                return;
            }
            comboCardId.Items.Remove(textCardID.Text);
            comboCardId.Text = "";
        }

        private void btnAddCardId_Click(object sender, EventArgs e)
        {
            if (comboCardId.Items.Contains(textCardID.Text))
            {
                textResponse.AppendText("[-] Card ID:" + textCardID.Text + " already exists.\r\n");
                return;
            }
            comboCardId.Items.Add(textCardID.Text);
            comboCardId.Text = textCardID.Text;
        }

        private void ToolStripMenuItem白名單_Click(object sender, EventArgs e)
        {
            saveWhiteList();
            Form frm = new Form2();
            frm.ShowDialog();
            readWhiteList();
        }
    }
}
