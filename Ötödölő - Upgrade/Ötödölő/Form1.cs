using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Ötödölő
{
    public partial class Form1 : Form
    {
        int m = 0;
        int n1 = 0;
        int n2 = 0;
        int nh1 = 0;
        int nh2 = 0;
        int revealCount = 0;
        int gamesCount = 0;
        int[,] arrayparameters;

        string hide = "Eltűntet";
        string reveal = "Megjelenít";
        string player1Win = "1. Játékos Nyert";
        string player2Win = "2. Játékos Nyert";
        string playerDraw = "Döntetlen";
        string loadedgameStatus = "";

        bool okwin = false;
        bool okdraw = false;
        bool loaded = false;

        Button[,] buttonArray;
        Color clr = new Color();


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            n1Box_TextChanged(sender, e);
            n2Box_TextChanged(sender, e);

            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            try
            {
                using (FileStream fs = new FileStream("CountText.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadToEnd();
                        gamesCount = Convert.ToInt32(line);

                        sr.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            LoadNumberText.Maximum = gamesCount; 
        }


        public void ColorDeclaration()
        {
            switch (m % 2)
            {
                case 1:
                    clr = Color.Green;
                    break;
                case 0:
                    clr = Color.Yellow;
                    break;
            }
        }

        public void Inc()
        {
            m += 1;
        }
        
        public void Draw()
        {
            if (m == n1 * n2)
            {
                okdraw = true;
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        buttonArray[i , j].Enabled = false;
                    }
                }
                NewGameButton.Visible = true;
                SaveButton.Visible = true;
                ResetButton.Visible = true;
            }
        } 

        public void Win()
        {
            for (int m = 0; m < n2; m++) //Vízszintesen nyert
            {
                for (int i = 0; i < n1 - 4; i++)
                {
                    try
                    {
                        if (((buttonArray[i, m].BackColor == Color.Green) & (buttonArray[i + 1, m].BackColor == Color.Green) & (buttonArray[i + 2, m].BackColor == Color.Green) & (buttonArray[i + 3, m].BackColor == Color.Green) & (buttonArray[i + 4, m].BackColor == Color.Green)) || ((buttonArray[i, m].BackColor == Color.Yellow) & (buttonArray[i + 1, m].BackColor == Color.Yellow) & (buttonArray[i + 2, m].BackColor == Color.Yellow) & (buttonArray[i + 3, m].BackColor == Color.Yellow) & (buttonArray[i + 4, m].BackColor == Color.Yellow)))
                        {
                            okwin = true;
                            for (int k = 0; k < n1; k++)
                            {
                                for (int j = 0; j < n2; j++)
                                {
                                    buttonArray[k, j].Enabled = false;
                                }
                            }
                            NewGameButton.Visible = true;
                            SaveButton.Visible = true;
                            ResetButton.Visible = true;

                            /*buttonArray[i, m].BackColor = Color.Red;
                            buttonArray[i + 1, m].BackColor = Color.Red;
                            buttonArray[i + 2, m].BackColor = Color.Red;
                            buttonArray[i + 3, m].BackColor = Color.Red;
                            buttonArray[i + 4, m].BackColor = Color.Red;*/
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            for (int m = 0; m < n1; m++) //Függőlegesen nyert
            {
                for (int i = 0; i < n2 - 4; i++)
                {
                    try
                    {
                        if (((buttonArray[m, i].BackColor == Color.Green) & (buttonArray[m, i + 1].BackColor == Color.Green) & (buttonArray[m, i + 2].BackColor == Color.Green) & (buttonArray[m, i + 3].BackColor == Color.Green) & (buttonArray[m, i + 4].BackColor == Color.Green)) || ((buttonArray[m, i].BackColor == Color.Yellow) & (buttonArray[m, i + 1].BackColor == Color.Yellow) & (buttonArray[m, i + 2].BackColor == Color.Yellow) & (buttonArray[m, i + 3].BackColor == Color.Yellow) & (buttonArray[m, i + 4].BackColor == Color.Yellow)))
                        {
                            okwin = true;
                            for (int k = 0; k < n1; k++)
                            {
                                for (int j = 0; j < n2; j++)
                                {
                                    buttonArray[k, j].Enabled = false;
                                }
                            }
                            NewGameButton.Visible = true;
                            SaveButton.Visible = true;
                            ResetButton.Visible = true;

                            /*buttonArray[m, i].BackColor = Color.Red;
                            buttonArray[m, i + 1].BackColor = Color.Red;
                            buttonArray[m, i + 2].BackColor = Color.Red;
                            buttonArray[m, i + 3].BackColor = Color.Red;
                            buttonArray[m, i + 4].BackColor = Color.Red;*/
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            for (int m = 0; m < n1 - 4; m++) //Főátlóval nyert
            {
                for (int i = 0; i < n2 - 4; i++)
                {
                    try
                    {
                        if (((buttonArray[m + 0, i + 0].BackColor == Color.Green) & (buttonArray[m + 1, i + 1].BackColor == Color.Green) & (buttonArray[m + 2, i + 2].BackColor == Color.Green) & (buttonArray[m + 3, i + 3].BackColor == Color.Green) & (buttonArray[m + 4, i + 4].BackColor == Color.Green)) || ((buttonArray[m + 0, i + 0].BackColor == Color.Yellow) & (buttonArray[m + 1, i + 1].BackColor == Color.Yellow) & (buttonArray[m + 2, i + 2].BackColor == Color.Yellow) & (buttonArray[m + 3, i + 3].BackColor == Color.Yellow) & (buttonArray[m + 4, i + 4].BackColor == Color.Yellow)))
                        {
                            okwin = true;
                            for (int k = 0; k < n1; k++)
                            {
                                for (int j = 0; j < n2; j++)
                                {
                                    buttonArray[k, j].Enabled = false;
                                }
                            }
                            NewGameButton.Visible = true;
                            SaveButton.Visible = true;
                            ResetButton.Visible = true;

                            /*buttonArray[m, i].BackColor = Color.Red;
                            buttonArray[m + 1, i + 1].BackColor = Color.Red;
                            buttonArray[m + 2, i + 2].BackColor = Color.Red;
                            buttonArray[m + 3, i + 3].BackColor = Color.Red;
                            buttonArray[m + 4, i + 4].BackColor = Color.Red;*/
                        }
                    }
                    catch (Exception)
                    {

                        break;
                    }
                }
            }

            for (int m = 0; m < n1 - 4; m++) //Mellékátlóval nyert
            {
                for (int i = 0; i < n2 - 4; i++)
                {
                    try
                    {
                        if (((buttonArray[m, n2 - 1 - i].BackColor == Color.Green) & (buttonArray[m + 1, n2 - 1 - i - 1].BackColor == Color.Green) & (buttonArray[m + 2, n2 - 1 - i - 2].BackColor == Color.Green) & (buttonArray[m + 3, n2 - 1 - i - 3].BackColor == Color.Green) & (buttonArray[m + 4, n2 - 1 - i - 4].BackColor == Color.Green)) || ((buttonArray[m, n2 - 1 - i].BackColor == Color.Yellow) & (buttonArray[m + 1, n2 - 1 - i - 1].BackColor == Color.Yellow) & (buttonArray[m + 2, n2 - 1 - i - 2].BackColor == Color.Yellow) & (buttonArray[m + 3, n2 - 1 - i - 3].BackColor == Color.Yellow) & (buttonArray[m + 4, n2 - 1 - i - 4].BackColor == Color.Yellow)))
                        {
                            okwin = true;
                            for (int k = 0; k < n1; k++)
                            {
                                for (int j = 0; j < n2; j++)
                                {
                                    buttonArray[k, j].Enabled = false;
                                }
                            }
                            NewGameButton.Visible = true;
                            SaveButton.Visible = true;
                            ResetButton.Visible = true;

                            /*buttonArray[m, n2 - 1 - i].BackColor = Color.Red;
                            buttonArray[m + 1, n2 - 1 - i - 1].BackColor = Color.Red;
                            buttonArray[m + 2, n2 - 1 - i - 2].BackColor = Color.Red;
                            buttonArray[m + 3, n2 - 1 - i - 3].BackColor = Color.Red;
                            buttonArray[m + 4, n2 - 1 - i - 4].BackColor = Color.Red;*/
                        }
                    }
                    catch (Exception)
                    {

                        break;
                    }
                }
            }
        }
        
        public void WriteTheSituation()
        {
            if (okwin == true)
            {
                switch (m % 2)
                {
                    case 1:
                        GameFinalStatusButton.Text = player1Win;
                        break;
                    case 0:
                        GameFinalStatusButton.Text = player2Win;
                        break;
                }
                GameFinalStatusButton.Visible = true;
            }
            else if (okdraw == true)
            {
                GameFinalStatusButton.Text = playerDraw;
                GameFinalStatusButton.Visible = true;
            }
        }

        public void CreatingNewButtons(int n1, int n2)
        {
            buttonArray = new Button[n1 , n2];

            int horizotal = -59;
            for (int i = 0; i < n1; i++)
            {
                horizotal += 60;
                int vertical = -59;
                for (int j = 0; j < n2; j++)
                {
                    vertical += 60;
                    buttonArray[i, j] = new Button();
                    buttonArray[i, j].Size = new Size(60, 60);
                    buttonArray[i, j].Tag = i.ToString() + " " + j.ToString();
                    buttonArray[i, j].Location = new Point(horizotal + 1, vertical + 1);
                    buttonArray[i, j].Enabled = true;
                    buttonArray[i, j].BackColor = Color.LightGray;
                    buttonArray[i, j].Text = i.ToString() + " " + j.ToString();
                    buttonArray[i, j].Click += (s, e) => button_click(s, e);
                    this.Controls.Add(buttonArray[i, j]);
                }
            }
        }

        public void CreatingNewButtonsLoad(int nh1, int nh2)
        {
            buttonArray = new Button[nh1, nh2];

            int horizotal = -59;
            for (int i = 0; i < nh1; i++)
            {
                horizotal += 60;
                int vertical = -59;
                for (int j = 0; j < nh2; j++)
                {
                    vertical += 60;
                    buttonArray[i, j] = new Button();
                    buttonArray[i, j].Size = new Size(60, 60);
                    buttonArray[i, j].Tag = i.ToString() + " " + j.ToString();
                    buttonArray[i, j].Location = new Point(horizotal + 1, vertical + 1);
                    buttonArray[i, j].Enabled = false;

                    switch (arrayparameters[i, j])
                    {
                        case 1:
                            {
                                buttonArray[i, j].BackColor = Color.Green;
                            }
                            break;
                        case 2:
                            {
                                buttonArray[i, j].BackColor = Color.Yellow;
                            }
                            break;
                        default:
                            {
                                buttonArray[i, j].BackColor = Color.LightGray;
                            }break;
                    }

                    buttonArray[i, j].Text = i.ToString() + " " + j.ToString();
                    buttonArray[i, j].Click += (s, e) => button_click(s, e);
                    this.Controls.Add(buttonArray[i, j]);
                }

                GameFinalStatusButton.Text = loadedgameStatus;
                GameFinalStatusButton.Visible = true;
                NewGameButton.Visible = true;
                ResetButton.Visible = true;
            }
        }

        public void Reset()
        {
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    buttonArray[i, j].Enabled = true;
                    buttonArray[i, j].BackColor = Color.LightGray;
                }
            }
            m = 0;
            NewGameButton.Visible = false;
            GameFinalStatusButton.Text = "";
            GameFinalStatusButton.Visible = false;
            okdraw = false;
            okwin = false;
            loaded = false;
        }
        
        public void GameNumberInc()
        {
            try
            {
                using (FileStream fs = new FileStream("CountText.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadToEnd();
                        gamesCount = Convert.ToInt32(line);
                        gamesCount++;

                        sr.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


            if (File.Exists("CountText.txt"))
            {
                File.Delete("CountText.txt");
            }

            try
            {
                using (FileStream fs = new FileStream("CountText.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(gamesCount.ToString());

                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            LoadNumberText.Maximum = gamesCount;
        }

        public void FileWrite()
        {
            try
            {
                using (FileStream fs = new FileStream("Game " + gamesCount + ".txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(n1 + "x" + n2 + Environment.NewLine);

                        for (int i = 0; i < n2; i++)
                        {
                            for (int j = 0; j < n1; j++)
                            {
                                if (buttonArray[j, i].BackColor == Color.Green)
                                {
                                    sw.Write(1);
                                }
                                else if (buttonArray[j, i].BackColor == Color.Yellow)
                                {
                                    sw.Write(2);
                                }
                                else
                                {
                                    sw.Write(0);
                                }
                                sw.Write(" ");
                            }
                            sw.Write(Environment.NewLine);
                        }

                        if (okwin == false)
                        {
                            sw.Write(playerDraw);
                        }
                        else
                        {
                            switch (m % 2)
                            {
                                case 1:
                                    {
                                        sw.Write(player1Win);
                                    }
                                    break;
                                default:
                                    {
                                        sw.Write(player2Win);
                                    }
                                    break;
                            }
                        }

                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            SaveButton.Visible = false;
        }
        
        public void FileLoad()
        {
            buttonArray = null;
            n1 = 0;
            n2 = 0;
            int filenumber = Convert.ToInt32(LoadNumberText.Text);
            try
            {
                using (FileStream fs = new FileStream("Game " + filenumber + ".txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string lines = sr.ReadToEnd();
                        string[] data = lines.Split('\n');
                        string[] numbers = data[0].Split('x');

                        nh1 = Convert.ToInt32(numbers[0]);
                        nh2 = Convert.ToInt32(numbers[1]);

                        arrayparameters = new int[nh1, nh2];

                        for (int i = 0; i < nh2; i++)
                        {
                            for (int j = 0; j < nh1; j++)
                            {
                                arrayparameters[j, i] = Convert.ToInt32(data[i + 1][2 * j]);
                                arrayparameters[j, i] -= 48;
                            }
                        }

                        loadedgameStatus = data[data.Length - 1];

                        sr.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            loaded = true;
            n1Box.Visible = false;
            n2Box.Visible = false;
            n1Get.Visible = false;
            n2Get.Visible = false;
            StartButton.Visible = false;
            NewGameButton.Visible = false;

            CreatingNewButtonsLoad(nh1, nh2);
        }


        private void TextBoxTextChange(TextBox data)
        {
            Font font = new Font("Times New Roman", 16.0f, FontStyle.Bold);
            data.Font = font;
        }

        private void n1Box_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChange(n1Box);
        }

        private void n2Box_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChange(n2Box);
        }


        private void HideRevealButton_Click(object sender, EventArgs e)
        {
            revealCount++;

            if (loaded == false)
            {
                switch (revealCount % 2)
                {
                    case 1:
                        HideRevealButton.Text = reveal;

                        for (int i = 0; i < n1; i++)
                        {
                            for (int j = 0; j < n2; j++)
                            {
                                string s = buttonArray[i, j].Text;
                                buttonArray[i, j].Text = "";
                            }
                        }
                        break;
                    default:
                        HideRevealButton.Text = hide;

                        for (int i = 0; i < n1; i++)
                        {
                            for (int j = 0; j < n2; j++)
                            {
                                buttonArray[i, j].Text = buttonArray[i, j].Tag.ToString();
                            }
                        }
                        break;
                }
            }
            else
            {
                switch (revealCount % 2)
                {
                    case 1:
                        HideRevealButton.Text = reveal;

                        for (int i = 0; i < nh1; i++)
                        {
                            for (int j = 0; j < nh2; j++)
                            {
                                buttonArray[i, j].Text = "";
                            }
                        }
                        break;
                    default:
                        HideRevealButton.Text = hide;

                        for (int i = 0; i < nh1; i++)
                        {
                            for (int j = 0; j < nh2; j++)
                            {
                                buttonArray[i, j].Text = buttonArray[i, j].Tag.ToString();
                            }
                        }
                        break;
                }
            }
        }
        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            GameNumberInc();
            FileWrite();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SaveButton.Visible = false;
            HideRevealButton.Visible = true;

            int filenumber = Convert.ToInt32(LoadNumberText.Text);
            string line = "";
            try
            {
                using (FileStream fs = new FileStream("CountText.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        line = sr.ReadToEnd();
                        gamesCount = Convert.ToInt32(line);

                        sr.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            if ((filenumber>0) && (filenumber <= gamesCount))
            {
                if (buttonArray != null)
                {
                    foreach (Button btn in buttonArray)
                    {
                        Controls.Remove(btn);
                        btn.Dispose();
                    }
                }

                FileLoad();
            }

            if (HideRevealButton.Text == "Megjelenít")
            {
                revealCount++;
                HideRevealButton.Text = "Eltűntet";
            }
        }
        
        private void button_click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;

                string sh = b.Tag.ToString();
                string[] s = sh.Split(' ');

                Inc();
                ColorDeclaration();

                int i = Convert.ToInt32(s[0]);
                int j = Convert.ToInt32(s[1]);
                buttonArray[i, j].BackColor = clr;
                buttonArray[i, j].Enabled = false;

                Win();
                Draw();
                WriteTheSituation();
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            SaveButton.Visible = false;

            if (n1 == 0) 
            {
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }

            Reset();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(n1Get.Text);
            n2 = Convert.ToInt32(n2Get.Text);

            n1 = Math.Min(n1, 20);
            n2 = Math.Min(n2, 12);

            n1Box.Visible = false;
            n2Box.Visible = false;
            n1Get.Visible = false;
            n2Get.Visible = false;
            StartButton.Visible = false;
            HideRevealButton.Visible = true;

            CreatingNewButtons(n1, n2);

            loaded = false;
        }
    }
}