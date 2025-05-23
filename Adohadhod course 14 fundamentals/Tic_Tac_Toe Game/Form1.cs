using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        private int Player_Index = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color);
            pen.Width = 11;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 600, 17, 600, 277);
            e.Graphics.DrawLine(pen, 689, 17, 689, 277);
            e.Graphics.DrawLine(pen, 515, 194, 775, 194);
            e.Graphics.DrawLine(pen, 515, 101, 775, 101);

        }
        //===================================================================================

        private bool Check_Win()
        {
            return
                (B1.Tag.ToString() != "-1" && B1.Tag.ToString() == B2.Tag.ToString() && B1.Tag.ToString() == B3.Tag.ToString()) ||
                (B4.Tag.ToString() != "-1" && B4.Tag.ToString() == B5.Tag.ToString() && B4.Tag.ToString() == B6.Tag.ToString()) ||
                (B7.Tag.ToString() != "-1" && B7.Tag.ToString() == B8.Tag.ToString() && B7.Tag.ToString() == B9.Tag.ToString()) ||
                                       
                (B1.Tag.ToString() != "-1" && B1.Tag.ToString() == B4.Tag.ToString() && B1.Tag.ToString() == B7.Tag.ToString()) ||
                (B2.Tag.ToString() != "-1" && B2.Tag.ToString() == B5.Tag.ToString() && B2.Tag.ToString() == B8.Tag.ToString()) ||
                (B3.Tag.ToString() != "-1" && B3.Tag.ToString() == B6.Tag.ToString() && B3.Tag.ToString() == B9.Tag.ToString()) ||
                                       
                (B1.Tag.ToString() != "-1" && B1.Tag.ToString() == B5.Tag.ToString() && B1.Tag.ToString() == B9.Tag.ToString()) ||
                (B3.Tag.ToString() != "-1" && B3.Tag.ToString() == B5.Tag.ToString() && B3.Tag.ToString() == B7.Tag.ToString());
        }

        private List<Button> Check_Win2()
        {
            Button[,] board = new Button[3, 3]
            {
        { B1, B2, B3 },
        { B4, B5, B6 },
        { B7, B8, B9 }
            };

            int p = Player_Index;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Tag.ToString() == p.ToString() &&
                    board[i, 1].Tag.ToString() == p.ToString() &&
                    board[i, 2].Tag.ToString() == p.ToString())
                {
                    return new List<Button> { board[i, 0], board[i, 1], board[i, 2] };
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i].Tag.ToString() == p.ToString() &&
                    board[1, i].Tag.ToString() == p.ToString() &&
                    board[2, i].Tag.ToString() == p.ToString())
                {
                    return new List<Button> { board[0, i], board[1, i], board[2, i] };
                }
            }

            if (board[0, 0].Tag.ToString() == p.ToString() &&
                board[1, 1].Tag.ToString() == p.ToString() &&
                board[2, 2].Tag.ToString() == p.ToString())
            {
                return new List<Button> { board[0, 0], board[1, 1], board[2, 2] };
            }

            if (board[0, 2].Tag.ToString() == p.ToString() &&
                board[1, 1].Tag.ToString() == p.ToString() &&
                board[2, 0].Tag.ToString() == p.ToString())
            {
                return new List<Button> { board[0, 2], board[1, 1], board[2, 0] };
            }

            return null; 
        }

        private bool Check_Draw()
        {
                string[] allowedButtons = { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9" };

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn && allowedButtons.Contains(btn.Name))
                    {
                        if (ctrl.Tag.ToString()=="-1")
                        {
                            return false;
                        }
                    }
                }
                return true;
        }

        private string [] Players_Data()
        {
            string[] Players = { "Player1", "Player2" };
            return Players;
        } 
       
        private Image [] Symbole_Data()
        {
            string path1 = "D:\\course 14 abohadhod C#\\Adohadhod course 14 fundamentals\\Images (1)\\Images\\X.png";
            Image defaultImage1 = Image.FromFile(path1);
            
            string path2 = "D:\\course 14 abohadhod C#\\Adohadhod course 14 fundamentals\\Images (1)\\Images\\O.png";
            Image defaultImage2 = Image.FromFile(path2);

            Image[] Symbole = { defaultImage1 , defaultImage2};
            return Symbole;
        }

        private void Change_Player_Index()
        {
            Player_Index = 1 - Player_Index;

        }

        private bool Is_available_Place(object sender)
        {
          if(((Button)sender).Tag.ToString()=="0"|| ((Button)sender).Tag.ToString() == "1")
            {
                return false;
            }
          return true;

        }

        private void Restart_Game()
        {
            Player_Index =0;
            string[] allowedButtons = { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9" };

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && allowedButtons.Contains(btn.Name))
                {
                    ctrl.BackgroundImage=Image.FromFile("D:\\course 14 abohadhod C#\\Adohadhod course 14 fundamentals\\Images (1)\\Images\\question-mark-96.png");
                    ctrl.Tag = "-1";
                }
            }
            label6.Text = "";
            label2.Text = "In Progress";
            Black_All_buttons();
            Enable_All_Exept_Restart();
        }
       
        private void Dicabled_All_Exept_Restart()
        {
            string[] allowedButtons = { "button10" };

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && (!allowedButtons.Contains(btn.Name)))
                {
                    ctrl.Enabled = false;


                }
            }
          
        }
        private void Enable_All_Exept_Restart()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn )
                {
                    ctrl.Enabled = true;

                }
            }
          
        }
       
        private void Red_All_buttons()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn )
                {
                    ctrl.BackColor=Color.Red;

                }
            }
          
        }
        private void Black_All_buttons()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn )
                {
                    ctrl.BackColor=Color.Black;

                }
            }
          
        }
        private void Green_All_buttons(List<Button> Win_Buttons)
        {

            foreach (Button ctrl in Win_Buttons)
            {
                if (ctrl is Button btn )
                {
                    ctrl.BackColor=Color.Green;

                }
            }
          
        }
       

        //===================================================================================
        private void The_Main_Loob(object sender)
        {
            if (Is_available_Place(sender))
            {
                string[] players = Players_Data();
                Image[] Symbole = Symbole_Data();
                ((Button)sender).BackgroundImage = Symbole[Player_Index];
                ((Button)sender).Tag = Player_Index;
                List<Button> Win_list = Check_Win2();
                if (Win_list==null)
                {
                    if (!Check_Draw())
                    {

                        label6.Text = players[Player_Index];
                        ((Button)sender).BackgroundImage = Symbole[Player_Index];
                        ((Button)sender).Tag = Player_Index;
                        Change_Player_Index();
                        label6.Text = players[Player_Index];

                    }
                    else
                    {
                        label2.Text = "Draw";
                        Red_All_buttons();
                        Dicabled_All_Exept_Restart();

                    }
                }
                else
                {
                    label2.Text = players[Player_Index];
                    Green_All_buttons(Win_list);
                    Dicabled_All_Exept_Restart();

                }
            }
            else
            {
                MessageBox.Show("Not Available","Wrong Choice",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //===================================================================================

        private void B1_Click(object sender, EventArgs e)
        {
            The_Main_Loob( sender);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B3_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B4_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B5_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B6_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B9_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        private void B8_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);


        }

        private void B2_Click(object sender, EventArgs e)
        {
            The_Main_Loob(sender);

        }

        //===================================================================================
        private void button10_Click_1(object sender, EventArgs e)
        {
            Restart_Game();
        }
    }
        //===================================================================================
    }

