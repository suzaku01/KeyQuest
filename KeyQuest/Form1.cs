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
        string[] dbBytes = new string[60000];
        string[] dbTexts1 = new string[60000];
        string[] dbTexts2= new string[60000];
        string[] dbTexts3 = new string[60000];
        string[] dbTexts4= new string[60000];
        string[] dbTexts5 = new string[60000];
        string[] dbTexts6 = new string[60000];
        string[] dbTexts7 = new string[60000];
        string[] dbTexts8 = new string[60000];
        int[] dbHR = new int[60000];
        int[] dbIDs = new int[60000];
        int selIndex = 0;
        int keyQuestCount = 0;
        bool isLoaded = false;

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

        int[] G1IDs = new int[10000];
        int[] G1Info = new int[10000];
        int[] G2IDs = new int[10000];
        int[] G2Info = new int[10000];
        int[] G3IDs = new int[10000];
        int[] G3Info = new int[10000];
        int[] G4IDs = new int[10000];
        int[] G4Info = new int[10000];
        int[] G5IDs = new int[10000];
        int[] G5Info = new int[10000];
        int[] G6IDs = new int[10000];
        int[] G6Info = new int[10000];
        int[] G7IDs = new int[10000];
        int[] G7Info = new int[10000];
        int[] G8IDs = new int[10000];
        int[] G8Info = new int[10000];
        int[] G9IDs = new int[10000];
        int[] G9Info = new int[10000];
        int[] G10IDs = new int[10000];
        int[] G10Info = new int[10000];

        private void Form1_Load(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var num = new List<int>();
            indexDic.Add(0, num);
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            listBoxDatabase.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchBox_KeyUp);
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

            if (fileNamesArray.Contains("database.bin") && !isLoaded)
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
                    HR1IDs = new int[10000];
                    HR1Info = new int[10000];
                    HR2IDs = new int[10000];
                    HR2Info = new int[10000];
                    HR3IDs = new int[10000];
                    HR3Info = new int[10000];
                    HR4IDs = new int[10000];
                    HR4Info = new int[10000];
                    HR5IDs = new int[10000];
                    HR5Info = new int[10000];
                    HR6IDs = new int[10000];
                    HR6Info = new int[10000];

                    G1IDs = new int[10000];
                    G1Info = new int[10000];
                    G2IDs = new int[10000];
                    G2Info = new int[10000];
                    G3IDs = new int[10000];
                    G3Info = new int[10000];
                    G4IDs = new int[10000];
                    G4Info = new int[10000];
                    G5IDs = new int[10000];
                    G5Info = new int[10000];
                    G6IDs = new int[10000];
                    G6Info = new int[10000];
                    G7IDs = new int[10000];
                    G7Info = new int[10000];
                    G8IDs = new int[10000];
                    G8Info = new int[10000];
                    G9IDs = new int[10000];
                    G9Info = new int[10000];
                    G10IDs = new int[10000];
                    G10Info = new int[10000];

                    isLoaded = true;
                    by = File.ReadAllBytes(openFileDialog1.FileName);   
                    data = by;
                    int toHR = BitConverter.ToInt32(by, 2712);       //13C1760
                    for (int i = 0; i < 6 + 10; i++)
                    {
                        int HR = BitConverter.ToInt32(by, toHR + (i * 4));
                        if (i == 13)
                        {
                            int toGR = BitConverter.ToInt32(by, 1856);
                            HR = BitConverter.ToInt32(by, toGR);
                        }
                        else if (i == 14)
                        {
                            int toGR = BitConverter.ToInt32(by, 1860);
                            HR = BitConverter.ToInt32(by, toGR);
                        }
                        else if (i == 15)
                        {
                            int toGR = BitConverter.ToInt32(by, 1864);
                            HR = BitConverter.ToInt32(by, toGR);
                        }
                        else if (i > 5)
                        {
                            int toGR = BitConverter.ToInt32(by, 1736 + ((i - 6) * 4));
                            HR = BitConverter.ToInt32(by, toGR);
                        }

                        for (int u = 0; u < 99999; u++)
                        {
                            int po = HR + (u * 8);
                            if (po < by.Length && po != by.Length)
                            {
                                int id = BitConverter.ToInt16(by, po);
                                int info = BitConverter.ToInt16(by, HR + (u * 8) + 4);      //1=key, 256 = urgent, 2=has flasg but not key nor urgent
                                int flag = BitConverter.ToInt16(by, HR + (u * 8) + 2);
                                int[] IDs = GetIDArray(i);
                                int[] infos = GetInfoArray(i);
                                if (id != 0)
                                {
                                    if (flag > 0 && i < 6)
                                    {
                                        keyQuestCount = keyQuestCount + 1;
                                    }
                                    else if (info > 0)
                                    {
                                        info = 2;
                                    }
                                    IDs[u] = id;
                                    infos[u] = info;
                                }
                                else
                                {
                                    break;
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
            if (!isLoaded)
                return;

            var dat = data.ToList();
            byte[] zero = { 0, 0, 0, 0 };
            int newBasePointer = dat.Count;
            byte[] by = BitConverter.GetBytes(newBasePointer);
            dat[2712] = by[0];      //A98, for HR
            dat[2713] = by[1];
            dat[2714] = by[2];
            dat[2715] = by[3];
            int key = 0;

            dat.AddRange(zero);    //for new pointer of HR and GR 64bytes,  Part1
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            int GRPointer = dat.Count;
            dat.AddRange(zero);    
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            int GRPointer2 = dat.Count;
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);


            //HR
            for (int i = 0; i < 6 + 10; i++)
            {
                int newPointer = dat.Count;
                byte[] by1 = BitConverter.GetBytes(newPointer);
                dat[newBasePointer + (i * 4) + 0] = by1[0];     //set new pointer for each quest from Part1
                dat[newBasePointer + (i * 4) + 1] = by1[1];
                dat[newBasePointer + (i * 4) + 2] = by1[2];
                dat[newBasePointer + (i * 4) + 3] = by1[3];

                if (i >= 6 && i < 13)   //6,7,8,9,10,11,12
                {
                    byte[] by2 = BitConverter.GetBytes(GRPointer + ((i - 6) * 4));
                    dat[1736 + 0 + ((i - 6) * 4)] = by2[0];
                    dat[1736 + 1 + ((i - 6) * 4)] = by2[1];
                    dat[1736 + 2 + ((i - 6) * 4)] = by2[2];
                    dat[1736 + 3 + ((i - 6) * 4)] = by2[3];
                }

                if (i> 12)      //13,14,15
                {
                    byte[] by3 = BitConverter.GetBytes(GRPointer2 + ((i - 13) * 4));
                    dat[1856 + 0 + ((i - 13) * 4)] = by3[0];
                    dat[1856 + 1 + ((i - 13) * 4)] = by3[1];
                    dat[1856 + 2 + ((i - 13) * 4)] = by3[2];
                    dat[1856 + 3 + ((i - 13) * 4)] = by3[3];
                }

                int[] IDs = GetIDArray(i);
                int[] infos = GetInfoArray(i);
                for (int j = 0; j < IDs.Length; j++)
                {
                    if (IDs[j] != 0)        //break if id is 0 or there's no more quest id
                    {
                        if (IDs[j] != 99999)        //99999 means the quest has deleted and should be skipped in this section
                        {
                            byte[] quest = { 0, 0, 0, 0, 0, 0, 0, 0 };
                            by = BitConverter.GetBytes(IDs[j]);
                            quest[0] = by[0];
                            quest[1] = by[1];
                            if (infos[j] == 256)
                            {
                                key = key + 1;
                                quest[5] = 1;       //urgent
                                quest[2] = (byte)key;
                            }
                            else if (infos[j] == 1)      //key
                            {
                                key = key + 1;
                                quest[4] = 1;
                                quest[2] = (byte)key;
                            }
                            else if (infos[j] == 2)     //mark
                            {
                                quest[4] = 1;
                            }
                            else
                            {

                            }
                            dat.AddRange(quest);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                dat.AddRange(zero);
            }
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            dat.AddRange(zero);
            File.WriteAllBytes("output/mhfdat.bin", dat.ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isLoaded && listBoxDatabase.SelectedIndex != -1)
            {
                int ID = dbIDs[selIndex];
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                for (int j = 0; j < ids.Length; j++)
                {
                    if (ids[j] != 0)
                    {

                    }
                    else
                    {
                        ids[j] = ID;
                        break;
                    }
                }

                string name = dbTexts1[selIndex];
                listBoxDat.Items.Add(name);
                numQuestCount.Value = numQuestCount.Value + 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selinde = listBoxDat.SelectedIndex;
            if (isLoaded && selinde != -1)
            {
                int index = tabControl1.SelectedIndex;
                //if (listBoxDat.SelectedIndex == 0)
                //    return;

                int[] ids = GetIDArray(index);
                ids[selinde] = 99999;
                listBoxDat.Items.RemoveAt(selinde);
                if (listBoxDat.Items.Count != 0)
                {
                    listBoxDat.SetSelected(Math.Max(selinde - 1, 0), true);
                }
                numQuestCount.Value = numQuestCount.Value - 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isLoaded && listBoxDat.SelectedIndex != -1)
            {
                int curIndex = listBoxDat.SelectedIndex;
                int newIndex = listBoxDat.SelectedIndex - 1;
                if (curIndex != 0)
                {
                    int index = tabControl1.SelectedIndex;
                    int[] ids = GetIDArray(index);
                    (ids[curIndex], ids[newIndex]) = (ids[newIndex], ids[curIndex]);
                    int[] infos = GetInfoArray(index);
                    (infos[curIndex], infos[newIndex]) = (infos[newIndex], infos[curIndex]);

                    MoveUp();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isLoaded && listBoxDat.SelectedIndex != -1)
            {
                int curIndex = listBoxDat.SelectedIndex;
                int newIndex = Math.Min(listBoxDat.SelectedIndex + 1, listBoxDat.Items.Count);
                if (curIndex + 1 != listBoxDat.Items.Count)
                {
                    int index = tabControl1.SelectedIndex;
                    int[] ids = GetIDArray(index);
                    (ids[curIndex], ids[newIndex]) = (ids[newIndex], ids[curIndex]);
                    int[] infos = GetInfoArray(index);
                    (infos[curIndex], infos[newIndex]) = (infos[newIndex], infos[curIndex]);

                    MoveDown();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                var strings = new List<string>();
                string input = textBoxSearch.Text;
                listBoxDatabase.Items.Clear();
                List<int> list2 = indexDic[0];
                list2 = new List<int>();
                for (int i = 0; i < dbTexts1.Length; i++)
                {
                    string str = dbTexts1[i];
                    if (str != null)
                    {
                        if (str.Contains(input))
                        {
                            strings.Add(str);

                            list2.Add(i);
                            indexDic[0] = list2;
                        }
                    }
                }

                foreach (string str in strings)
                {
                    listBoxDatabase.Items.Add(str);
                }
            }
            else
            {
                string input = textBoxSearch.Text;
                listBoxDatabase.Items.Clear();
                for (int i = 0; i < dbTexts1.Length; i++)
                {
                    if (dbTexts1[i] != null)
                    {
                        listBoxDatabase.Items.Add(dbTexts1[i]);
                    }

                }
            }
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
                    else if (info ==2)
                    {
                        radiomark.Checked = true;
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
                case 6:
                    ids = G1IDs;
                    break;
                case 7:
                    ids = G2IDs;
                    break;
                case 8:
                    ids = G3IDs;
                    break;
                case 9:
                    ids = G4IDs;
                    break;
                case 10:
                    ids = G5IDs;
                    break;
                case 11:
                    ids = G6IDs;
                    break;
                case 12:
                    ids = G7IDs;
                    break;
                case 13:
                    ids = G8IDs;
                    break;
                case 14:
                    ids = G9IDs;
                    break;
                case 15:
                    ids = G10IDs;
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
                case 6:
                    info = G1Info;
                    break;
                case 7:
                    info = G2Info;
                    break;
                case 8:
                    info = G3Info;
                    break;
                case 9:
                    info = G4Info;
                    break;
                case 10:
                    info = G5Info;
                    break;
                case 11:
                    info = G6Info;
                    break;
                case 12:
                    info = G7Info;
                    break;
                case 13:
                    info = G8Info;
                    break;
                case 14:
                    info = G9Info;
                    break;
                case 15:
                    info = G10Info;
                    break;
            }
            return info;
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            //from StackOverFlow
            if (listBoxDat.SelectedItem == null || listBoxDat.SelectedIndex < 0)
                return;

            int newIndex = listBoxDat.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBoxDat.Items.Count)
                return;

            object selected = listBoxDat.SelectedItem;

            listBoxDat.Items.Remove(selected);
            listBoxDat.Items.Insert(newIndex, selected);
            listBoxDat.SetSelected(newIndex, true);
        }

        private void radioNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNone.Checked && isLoaded)
            {
                int index = listBoxDat.SelectedIndex;
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                int id = ids[index];
                int[] infos = GetInfoArray(tabControl1.SelectedIndex);
                infos[index] = 0;

                if (0 <= Array.IndexOf(dbIDs, id))
                {
                    int num = dbIDs.ToList().IndexOf(id);
                    string str = dbTexts1[num];
                    //str = "<Key>" + str;
                    listBoxDat.Items[index] = str;
                }
            }
        }

        private void radioKey_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKey.Checked && isLoaded)
            {
                int index = listBoxDat.SelectedIndex;
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                int id = ids[index];
                int[] infos = GetInfoArray(tabControl1.SelectedIndex);
                infos[index] = 1;

                if (0 <= Array.IndexOf(dbIDs, id))
                {
                    int num = dbIDs.ToList().IndexOf(id);
                    string str = dbTexts1[num];
                    str = "<Key>" + str;
                    listBoxDat.Items[index] = str;
                }
            }
        }

        private void radioUrgent_CheckedChanged(object sender, EventArgs e)     //,urgent.
        {
            if (radioUrgent.Checked && isLoaded)
            {
                int index = listBoxDat.SelectedIndex;
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                int id = ids[index];
                int[] infos = GetInfoArray(tabControl1.SelectedIndex);
                infos[index] = 256;

                if (0 <= Array.IndexOf(dbIDs, id))
                {
                    int num = dbIDs.ToList().IndexOf(id);
                    string str = dbTexts1[num];
                    str = "<Urgent>" + str;
                    listBoxDat.Items[index] = str;
                }
            }
        }

        private void radioTest_CheckedChanged(object sender, EventArgs e)
        {
            if (radiomark.Checked && isLoaded)
            {
                int index = listBoxDat.SelectedIndex;
                int[] ids = GetIDArray(tabControl1.SelectedIndex);
                int id = ids[index];
                int[] infos = GetInfoArray(tabControl1.SelectedIndex);
                infos[index] = 2;

                if (0 <= Array.IndexOf(dbIDs, id))
                {
                    int num = dbIDs.ToList().IndexOf(id);
                    string str = dbTexts1[num];
                    str = "<Mark>" + str;
                    listBoxDat.Items[index] = str;
                }
            }
        }

        private void textBoxSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            //F1ÉLÅ[Ç™âüÇ≥ÇÍÇΩÇ©í≤Ç◊ÇÈ
            if (e.KeyData == Keys.Enter)
            {
                if (isLoaded && listBoxDatabase.SelectedIndex != -1)
                {
                    int ID = dbIDs[selIndex];
                    int[] ids = GetIDArray(tabControl1.SelectedIndex);
                    for (int j = 0; j < ids.Length; j++)
                    {
                        if (ids[j] != 0)
                        {

                        }
                        else
                        {
                            ids[j] = ID;
                            break;
                        }
                    }

                    string name = dbTexts1[selIndex];
                    listBoxDat.Items.Add(name);
                    numQuestCount.Value = numQuestCount.Value + 1;
                }
            }
        }
    }
}