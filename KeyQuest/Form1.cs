using System;
using System.IO;
using System.Text;
using System.Linq;

namespace KeyQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, List<int>> indexDic = new Dictionary<int, List<int>>();
        byte[] data;
        string[] dbBytes = new string[10000];
        string[] dbTexts1 = new string[10000];
        string[] dbTexts2= new string[10000];
        string[] dbTexts3 = new string[10000];
        string[] dbTexts4= new string[10000];
        string[] dbTexts5 = new string[10000];
        string[] dbTexts6 = new string[10000];
        string[] dbTexts7 = new string[10000];
        string[] dbTexts8 = new string[10000];
        int[] dbHR = new int[10000];
        int[] dbIDs = new int[10000];
        int selIndex = 0;
        int keyQuestCount = 0;

        int[] HR1IDs = new int[10000];
        int[] HR1Info = new int[10000];
        int[] HR2IDs = new int[10000];
        int[] HR2Info = new int[10000];
        int[] HR3IDs = new int[10000];
        int[] HR3Info = new int[10000];
        int[] HR4IDs = new int[10000];
        int[] HR4Info = new int[10000];
        int[] HR5IDs = new int[10000];
        int[] HR5Info = new int[10000];
        int[] HR6IDs = new int[10000];
        int[] HR6Info = new int[10000];

        private void Form1_Load(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var num = new List<int>();
            indexDic.Add(0, num);
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();

            listBoxDat.Items.Clear();
            int index = tabControl1.SelectedIndex;
            int[] IDs = GetIDArray(index);
            int[] infos = GetInfoArray(index);
            for (int i = 0; i < IDs.Length; i++)
            {
                if (IDs[i] != 0)
                {
                    if (0 <= Array.IndexOf(dbIDs, IDs[i]))
                    {
                        int num = dbIDs.ToList().IndexOf(IDs[i]);
                        string name = dbTexts1[num];
                        if (infos[i] == 1)
                        {
                            name = "<Key>" + name;
                        }
                        else if (infos[i] == 256)
                        {
                            name = "<Urgent>" + name;
                        }
                        listBoxDat.Items.Add(name);
                    }
                }
                else
                {
                    numQuestCount.Value = i;
                    break;
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult folderBrowser = folderBrowserDialog1.ShowDialog();
            if (folderBrowser == DialogResult.OK)
            {
                string[] fileNamesArray = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bin");
                var listFileName = Directory.GetFiles(folderBrowserDialog1.SelectedPath).Select(Path.GetFileName).ToArray();
                var list = new List<byte>();
                byte[] fileHeader = { 00, 00, 00, 00 };
                byte[] devide = { 00, 00 };
                string prevName = "none";
                int count = 0;
                bool suc = false;
                ;
                for (int i = 0; i < fileNamesArray.Length; i++)
                {
                    string fileName = listFileName[i];
                    char[] del = { 'd', 'n' };
                    string[] fileName2 = fileName.Split(del);

                    if (prevName != fileName2[0])
                    {
                        byte[] by = by = File.ReadAllBytes(fileNamesArray[i]);
                        if (by[0] == 192)
                        {
                            count = count + 1;
                            var by1 = new List<byte>();
                            byte[] data = by.Skip(192).Take(320).ToArray();
                            by1.AddRange(data);     //140

                            int textPointer = BitConverter.ToInt16(by, 48);     //AE4
                            int textPointer1 = BitConverter.ToInt16(by, textPointer);
                            textPointer1 = textPointer1 - 32;
                            byte[] pointerData = by.Skip(textPointer1).Take(32).ToArray();
                            by1.AddRange(pointerData);  //160
                            int leng = by1.Count;

                            by1[40] = 64;
                            by1[41] = 1;

                            int pointer = BitConverter.ToInt16(by, textPointer + 4);
                            int val = by[pointer];
                            if (val == 0)
                            {
                                pointer = pointer + 1;
                            }

                            int pTitleAndName = BitConverter.ToInt16(by, textPointer1);
                            int pMainoObj = BitConverter.ToInt16(by, textPointer1 + 4);
                            int pAObj = BitConverter.ToInt16(by, textPointer1 + 8);
                            int pBObj = BitConverter.ToInt16(by, textPointer1 + 12);
                            int pClearC = BitConverter.ToInt16(by, textPointer1 + 16);
                            int pFailC = BitConverter.ToInt16(by, textPointer1 + 20);
                            int pEmp = BitConverter.ToInt16(by, textPointer1 + 24);
                            int pText = BitConverter.ToInt16(by, textPointer1 + 28);

                            int a1 = by.Skip(pTitleAndName).Take(pMainoObj - pTitleAndName).ToArray().Length;
                            int a2 = by.Skip(pMainoObj).Take(pBObj - pMainoObj).ToArray().Length;
                            int a3 = by.Skip(pAObj).Take(pBObj - pAObj).ToArray().Length;
                            int a4 = by.Skip(pBObj).Take(pClearC - pBObj).ToArray().Length;
                            int a5 = by.Skip(pClearC).Take(pFailC - pClearC).ToArray().Length;
                            int a6 = by.Skip(pFailC).Take(pEmp - pFailC).ToArray().Length;
                            int a7 = by.Skip(pEmp).Take(pText - pEmp).ToArray().Length;
                            int a8 = by.Skip(pText).Take(by.Length - pText).ToArray().Length;

                            byte[] b1 = by.Skip(pTitleAndName).Take(pMainoObj - pTitleAndName).ToArray();
                            byte[] b2 = by.Skip(pMainoObj).Take(pBObj - pMainoObj).ToArray();
                            byte[] b3 = by.Skip(pAObj).Take(pBObj - pAObj).ToArray();
                            byte[] b4 = by.Skip(pBObj).Take(pClearC - pBObj).ToArray();
                            byte[] b5 = by.Skip(pClearC).Take(pFailC - pClearC).ToArray();
                            byte[] b6 = by.Skip(pFailC).Take(pEmp - pFailC).ToArray();
                            byte[] b7 = by.Skip(pEmp).Take(pText - pEmp).ToArray();
                            byte[] b8 = by.Skip(pText).Take(by.Length - pText).ToArray();
                            by1.AddRange(b1);
                            by1.AddRange(b2);
                            by1.AddRange(b3);
                            by1.AddRange(b4);
                            by1.AddRange(b5);
                            by1.AddRange(b6);
                            by1.AddRange(b7);
                            by1.AddRange(b8);

                            leng = leng - 32;
                            int num = leng + 32;
                            byte[] c1 = BitConverter.GetBytes(num);    //01,60
                            by1[leng] = c1[0];
                            by1[leng + 1] = c1[1];

                            num = num + a1;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 4] = c1[0];
                            by1[leng + 5] = c1[1];

                            num = num + a2;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 8] = c1[0];
                            by1[leng + 9] = c1[1];

                            num = num + a3;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 12] = c1[0];
                            by1[leng + 13] = c1[1];

                            num = num + a4;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 16] = c1[0];
                            by1[leng + 17] = c1[1];

                            num = num + a5;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 20] = c1[0];
                            by1[leng + 21] = c1[1];

                            num = num + a6;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 24] = c1[0];
                            by1[leng + 25] = c1[1];

                            num = num + a7;
                            c1 = BitConverter.GetBytes(num);
                            by1[leng + 28] = c1[0];
                            by1[leng + 29] = c1[1];

                            leng = by1.Count;
                            byte[] b = BitConverter.GetBytes(leng); //2C8
                            byte[] questHeader = { 00, 00, 15, 04, 18, 01, 00, 00, 00, 00, 00, 00, 00, 00, 255, 255 };
                            questHeader[14] = b[1];
                            questHeader[15] = b[0];
                            list.AddRange(questHeader);

                            list.AddRange(by1);
                            list.AddRange(devide);
                            suc = true;
                        }
                        else
                        {
                            MessageBox.Show("It appears that the quest file is not included or is formatted differently.");
                            break;
                        }
                    }
                    prevName = fileName2[0];
                }
                if (suc)
                {
                    byte[] amount = BitConverter.GetBytes(count);
                    list[0] = amount[0];
                    list[1] = amount[1];
                    File.WriteAllBytes("data/database.bin", list.ToArray());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            path = path + "/data";
            string[] fileNamesArray = Directory.GetFiles(path).Select(Path.GetFileName).ToArray();

            if (fileNamesArray.Contains("database.bin"))
            {
                byte[] byteData = File.ReadAllBytes("data/database.bin");
                int count = BitConverter.ToUInt16(byteData, 0);
                int prevPointer = 4;
                for (int i = 0; i < count; i++)
                {
                    byte[] header = byteData.Skip(prevPointer).Take(16).ToArray();
                    int length = header[14] * 256 + header[15];
                    byte[] by = byteData.Skip(prevPointer + 16).Take(length).ToArray();
                    string str1 = BitConverter.ToString(header).Replace("-", string.Empty);
                    string str2 = BitConverter.ToString(by).Replace("-", string.Empty);
                    str1 = str1 + str2;
                    dbBytes[i] = str1;

                    int pTitleAndName = BitConverter.ToInt16(by, 320);
                    int pMainoObj = BitConverter.ToInt16(by, 324);
                    int pAObj = BitConverter.ToInt16(by, 328);
                    int pBObj = BitConverter.ToInt16(by, 332);
                    int pClearC = BitConverter.ToInt16(by, 336);
                    int pFailC = BitConverter.ToInt16(by, 340);
                    int pEmp = BitConverter.ToInt16(by, 344);
                    int pText = BitConverter.ToInt16(by, 348);
                    string tTitleAndName = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pTitleAndName).Take(pMainoObj - pTitleAndName).ToArray()).Replace("\n", "\r\n");
                    string tMainObj = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pMainoObj).Take(pAObj - pMainoObj).ToArray()).Replace("\n", "\r\n");
                    string tAObj = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pAObj).Take(pClearC - pAObj).ToArray()).Replace("\n", "\r\n");
                    string tBObj = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pBObj).Take(pClearC - pBObj).ToArray()).Replace("\n", "\r\n");
                    string tClearC = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pClearC).Take(pFailC - pClearC).ToArray()).Replace("\n", "\r\n");
                    string tFailC = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pFailC).Take(pEmp - pFailC).ToArray()).Replace("\n", "\r\n");
                    string tEmp = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pEmp).Take(pText - pEmp).ToArray()).Replace("\n", "\r\n");
                    string tText = Encoding.GetEncoding("Shift_JIS").GetString(by.Skip(pText).Take(by.Length - pText).ToArray()).Replace("\n", "\r\n");
                    dbTexts1[i] = tTitleAndName;
                    dbTexts2[i] = tMainObj;
                    dbTexts3[i] = tAObj;
                    dbTexts4[i] = tBObj;
                    dbTexts5[i] = tClearC;
                    dbTexts6[i] = tFailC;
                    dbTexts7[i] = tEmp;
                    dbTexts8[i] = tText;

                    dbIDs[i] = BitConverter.ToUInt16(by, 46);
                    dbHR[i] = BitConverter.ToInt16(by, 78);

                    listBoxDatabase.Items.Add(tTitleAndName);

                    if (i != count - 1)
                    {
                        int num1 = 0;
                        for (int t = 1; t < 250; t++)
                        {
                            int val = prevPointer + 16 + length + t;
                            if (val < byteData.Length)
                            {
                                if (byteData[val] == 64 && byteData[val + 1] == 1 && byteData[val - 1] == 0)
                                {
                                    num1 = val - 56;
                                    break;
                                }
                            }
                        }
                        prevPointer = num1;
                    }
                    else
                    {
                        break;
                    }
                }

                //if (listBoxDatabase.SelectedIndex == -1 && listBoxDatabase.Items.Count != 0)
                //{
                //    listBoxDatabase.SelectedIndex = 0;
                //}
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxDatabase.Items.Count == 0)
                return;

            DialogResult opneFileDialog = openFileDialog1.ShowDialog();
            if (opneFileDialog == DialogResult.OK)
            {
                byte[] by = File.ReadAllBytes(openFileDialog1.FileName);
                if (by[0] == 109)
                {
                    by = File.ReadAllBytes(openFileDialog1.FileName);   
                    data = by;
                    int toHR = BitConverter.ToInt32(by, 2712);       //13C1760
                    for (int i = 0; i < 6; i++)
                    {
                        int HR = BitConverter.ToInt32(by, toHR + (i * 4));
                        for (int u = 0; u < 9999; u++)
                        {
                            int id = BitConverter.ToInt16(by, HR + (u * 8));
                            int info = BitConverter.ToInt16(by, HR + (u * 8) + 4);
                            int[] IDs = GetIDArray(i);
                            int[] infos = GetInfoArray(i);
                            if (id != 0)
                            {
                                IDs[u] = id;
                                infos[u] = info;
                                if (info > 0)
                                {
                                    keyQuestCount = keyQuestCount + 1;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                            
                    }
                    numKey.Value = keyQuestCount;
                    tabControl1.SelectedIndex = 1;
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("This is not mhfdat.bin.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxDat.Items.Count == 0)
                return;

            var dat = data.ToList();
            byte[] zero = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int basePointer = data.Length;
            byte[] by = BitConverter.GetBytes(basePointer);
            dat[2712] = by[0];
            dat[2713] = by[1];
            dat[2714] = by[2];
            dat[2715] = by[3];
            int key = 0;

            dat.AddRange(zero);    //for new pointer 32bytes
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);

            for (int i = 0; i < 6; i++)
            {
                int newPointer = dat.Count;
                byte[] by1 = BitConverter.GetBytes(newPointer);
                label1.Text = newPointer.ToString();
                dat[basePointer + (i * 4) + 0] = by1[0];
                dat[basePointer + (i * 4) + 1] = by1[1];
                dat[basePointer + (i * 4) + 2] = by1[2];
                dat[basePointer + (i * 4) + 3] = by1[3];

                int[] IDs = GetIDArray(i);
                int[] infos = GetInfoArray(i);
                //var add = new List<byte>();
                for (int j = 0; j < IDs.Length; j++)
                {
                    if (IDs[j] != 0)
                    {
                        byte[] quest = { 0, 0, 0, 0, 0, 0, 0, 0 };
                        by = BitConverter.GetBytes(IDs[j]);
                        quest[0] = by[0];
                        quest[1] = by[1];
                        if (infos[j] == 256)
                        {
                            quest[5] = 1;       //urgent
                            quest[2] = (byte)key;
                            key = key + 1;
                        }
                        else if (infos[j] == 1)      //key
                        {
                            quest[4] = 1;
                            quest[2] = (byte)key;
                            key = key + 1;
                        }
                        else
                        {

                        }
                        dat.AddRange(quest);
                    }
                    else
                    {
                        break;
                    }
                }
                dat.AddRange(zero);

            }
            File.WriteAllBytes("output/mhfdat.bin", dat.ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDatabase.Items.Count != 0 && listBoxDatabase.SelectedIndex != -1)
            {
                List<int> db = indexDic[0];

                if (String.IsNullOrEmpty(textBoxSearch.Text))
                {
                    selIndex = listBoxDatabase.SelectedIndex;
                }
                else
                {
                    if (db.Count > listBoxDatabase.SelectedIndex)
                    {
                        selIndex = db[listBoxDatabase.SelectedIndex];

                    }
                }

                textBox1.Text = dbTexts1[selIndex];
                textBox2.Text = dbTexts2[selIndex];
                textBox3.Text = dbTexts3[selIndex];
                textBox4.Text = dbTexts4[selIndex];
                textBox5.Text = dbTexts5[selIndex];
                textBox6.Text = dbTexts6[selIndex];
                textBox7.Text = dbTexts7[selIndex];
                textBox8.Text = dbTexts8[selIndex];
                labelHR.Text = dbHR[selIndex].ToString();
                labelID.Text = dbIDs[selIndex].ToString();
            }
        }

        private void listBoxDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDat.Items.Count != 0 && listBoxDat.SelectedIndex != -1 && listBoxDatabase.Items.Count != 0)
            {
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                int id = ids[listBoxDat.SelectedIndex];
                int[] infos = GetInfoArray(tabControl1.SelectedIndex);
                int info = infos[listBoxDat.SelectedIndex];
                if (0 <= Array.IndexOf(dbIDs, id))
                {
                    int num = dbIDs.ToList().IndexOf(id);
                    textBox1.Text = dbTexts1[num];
                    textBox2.Text = dbTexts2[num];
                    textBox3.Text = dbTexts3[num];
                    textBox4.Text = dbTexts4[num];
                    textBox5.Text = dbTexts5[num];
                    textBox6.Text = dbTexts6[num];
                    textBox7.Text = dbTexts7[num];
                    textBox8.Text = dbTexts8[num];

                    if (info == 256)
                    {
                        radioUrgent.Checked = true;
                    }
                    else if (info ==1)      //key
                    {
                        radioKey.Checked = true;
                    }
                    else               
                    {
                        radioNone.Checked = true;
                    }

                    labelHR.Text = dbHR[num].ToString();
                    labelID.Text = dbIDs[num].ToString();


                }
            }
        }

        int[] GetIDArray(int num)
        {
            int[] ids = new int[10000];
            switch (num)
            {
                case 0:
                    ids =  HR1IDs;
                    break;
                case 1:
                    ids = HR2IDs;
                    break;
                case 2:
                    ids = HR3IDs;
                    break;
                case 3:
                    ids = HR4IDs;
                    break;
                case 4:
                    ids = HR5IDs;
                    break;
                case 5:
                    ids = HR6IDs;
                    break;
            }
            return ids;
        }

        int[] GetInfoArray(int num)
        {
            int[] info = new int[10000];
            switch (num)
            {
                case 0:
                    info = HR1Info;
                    break;
                case 1:
                    info = HR2Info;
                    break;
                case 2:
                    info = HR3Info;
                    break;
                case 3:
                    info = HR4Info;
                    break;
                case 4:
                    info = HR5Info;
                    break;
                case 5:
                    info = HR6Info;
                    break;
            }
            return info;
        }

    }
}