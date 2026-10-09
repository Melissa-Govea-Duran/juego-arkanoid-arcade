using ArkanoiD_ArcadE.Properties;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Runtime.Versioning;
using System.Runtime.InteropServices; /*Libreria para redondear elementos*/

namespace ArkanoiD_ArcadE
{
    public partial class Form1 : Form
    {
        Panel pSarkanoiD = new Panel();

        Label bThelParkA = new Label();

        Label bTclosEarK = new Label();

        Label lBscorEaR1 = new Label();

        Label lBjGscorE1 = new Label();

        Label lBhIscorEA = new Label();

        Label lBjGhIscorEaR = new Label();

        PictureBox pBarkanoiD = new PictureBox();

        PictureBox pBseleccionaRjuegO = new PictureBox();

        Label lB1playeRarK = new Label();

        Label lB2playerSarK = new Label();

        Label lBtaitOarK = new Label();

        Label lBautoR01 = new Label();

        Label lBautoR02 = new Label();

        Label lBautoR03 = new Label();

        System.Media.SoundPlayer sN_insertaRmonedA = new System.Media.SoundPlayer(Resources.S_InsertarM);

        Boolean desactivaRteclaS = true;

        Label lBmensajE = new Label();

        System.Windows.Forms.Timer tR_moVmensajE = new System.Windows.Forms.Timer();

        System.Windows.Forms.Timer tR_esperAmensajE = new System.Windows.Forms.Timer();

        int contadoResperA = 0;

        System.Media.SoundPlayer sN_intrO = new System.Media.SoundPlayer(Resources.sN_Intro);

        System.Windows.Forms.Timer tR_labeLparpadeantE = new System.Windows.Forms.Timer();

        Label lBrounD = new Label();

        System.Media.SoundPlayer sN_empezarJuego = new System.Media.SoundPlayer(Resources.sN_Empezar);

        PictureBox[] pBvidas;

        PictureBox pBcanvaS = new PictureBox();

        Label lBplayeR1 = new Label();

        Label lBreadY = new Label();

        Label[,] lBbloqueS;

        PictureBox pBpelotA = new PictureBox();

        int moVpelotAX = 5;

        int moVpelotAY = 5;

        PictureBox pBbarrA = new PictureBox();

        System.Windows.Forms.Timer tR_moVpeLelIblO = new System.Windows.Forms.Timer();

        System.Media.SoundPlayer sN_rebotEpelotA = new System.Media.SoundPlayer(Resources.S_Prebote);

        int puntoSarkanoiD = 0;

        int vidaSjugadoR = 3;

        Label lBganadoR = new Label();

        System.Media.SoundPlayer sN_gamEwiN = new System.Media.SoundPlayer(Resources.S_GameW);

        Label lBperdedoR = new Label();

        System.Media.SoundPlayer sN_gamEoveR = new System.Media.SoundPlayer(Resources.S_GameO);

        Boolean reiniciaRjuegO;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.ArK_ICO;

            this.BackColor = Color.Black;

            paneL_suParkanoiD();

            labeL_scorEaR1();

            labeL_jGscorE1();

            labeL_hIscorEA();

            labeL_jGhIscorEaR();

            pB_arkanoiD();

            pB_seleccionaRjuegO();

            this.KeyDown += Form1_KeyDown;

            this.KeyPreview = true;

            lB_1playeRarK();

            lB_2playerSarK();

            lB_taitOarK();

            lB_autoR01();

            lB_autoR02();

            lB_autoR03();
        }

        private void paneL_suParkanoiD()
        {
            pSarkanoiD.Location = new Point(0, 0);

            pSarkanoiD.Size = new Size(1029, 35);

            pSarkanoiD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            pSarkanoiD.BackColor = Color.Blue;

            this.Controls.Add(pSarkanoiD);


            bThelParkA.Location = new Point(986, 0);

            bThelParkA.Size = new Size(20, 35);

            bThelParkA.Text = "?";

            bThelParkA.Font = new Font("SimSun-ExtB", 14);

            bThelParkA.TextAlign = ContentAlignment.MiddleLeft;

            bThelParkA.ForeColor = Color.White;

            bThelParkA.BackColor = Color.LightGray;

            bThelParkA.Cursor = Cursors.Hand;

            bThelParkA.MouseHover += BThelParkA_MouseHover;

            bThelParkA.MouseLeave += BThelParkA_MouseLeave;

            bThelParkA.Click += BThelParkA_Click;


            bTclosEarK.Location = new Point(1007, 0);

            bTclosEarK.Size = new Size(20, 35);

            bTclosEarK.Text = "X";

            bTclosEarK.Font = new Font("SimSun-ExtB", 14);

            bTclosEarK.TextAlign = ContentAlignment.MiddleLeft;

            bTclosEarK.ForeColor = Color.White;

            bTclosEarK.BackColor = Color.Red;

            bTclosEarK.Cursor = Cursors.Hand;

            bTclosEarK.MouseHover += BTclosEarK_MouseHover;

            bTclosEarK.MouseLeave += BTclosEarK_MouseLeave;

            bTclosEarK.Click += BTclosEarK_Click;


            pSarkanoiD.Controls.Add(bThelParkA);

            pSarkanoiD.Controls.Add(bTclosEarK);
        }

        private void BThelParkA_MouseHover(object? sender, EventArgs e)
        {
            bThelParkA.ForeColor = Color.Black;

            bThelParkA.BackColor = Color.White;
        }

        private void BThelParkA_MouseLeave(object? sender, EventArgs e)
        {
            bThelParkA.ForeColor = Color.White;

            bThelParkA.BackColor = Color.LightGray;
        }

        private void BThelParkA_Click(object? sender, EventArgs e)
        {
            this.Hide();

            Form instruccioneSfrM = new Form2();

            instruccioneSfrM.Show();
        }

        private void BTclosEarK_MouseHover(object? sender, EventArgs e)
        {
            bTclosEarK.ForeColor = Color.Black;

            bTclosEarK.BackColor = Color.White;
        }

        private void BTclosEarK_MouseLeave(object? sender, EventArgs e)
        {
            bTclosEarK.ForeColor = Color.White;

            bTclosEarK.BackColor = Color.Red;
        }

        private void BTclosEarK_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labeL_scorEaR1()
        {
            lBscorEaR1.Location = new Point(75, 40);

            lBscorEaR1.Size = new Size(130, 35);

            lBscorEaR1.Text = "1UP";

            lBscorEaR1.Font = new Font("SimSun-ExtB", 16);

            lBscorEaR1.TextAlign = ContentAlignment.MiddleCenter;

            lBscorEaR1.ForeColor = Color.Red;

            lBscorEaR1.BackColor = Color.LightGray;

            lBscorEaR1.Tag = "1";

            this.Controls.Add(lBscorEaR1);
        }

        private void labeL_jGscorE1()
        {
            lBjGscorE1.Location = new Point(75, 85);

            lBjGscorE1.Size = new Size(130, 35);

            lBjGscorE1.Text = "00";

            lBjGscorE1.Font = new Font("SimSun-ExtB", 16);

            lBjGscorE1.TextAlign = ContentAlignment.MiddleCenter;

            lBjGscorE1.ForeColor = Color.White;

            lBjGscorE1.BackColor = Color.LightGray;

            lBjGscorE1.Tag = "1";

            this.Controls.Add(lBjGscorE1);
        }

        private void labeL_hIscorEA()
        {
            lBhIscorEA.Location = new Point(450, 40);

            lBhIscorEA.Size = new Size(170, 35);

            lBhIscorEA.Text = "HIGH SCORE";

            lBhIscorEA.Font = new Font("SimSun-ExtB", 16);

            lBhIscorEA.TextAlign = ContentAlignment.MiddleCenter;

            lBhIscorEA.ForeColor = Color.Red;

            lBhIscorEA.BackColor = Color.LightGray;

            lBhIscorEA.Tag = "1";

            this.Controls.Add(lBhIscorEA);
        }

        private void labeL_jGhIscorEaR()
        {
            lBjGhIscorEaR.Location = new Point(450, 85);

            lBjGhIscorEaR.Size = new Size(170, 35);

            lBjGhIscorEaR.Text = "50000";

            lBjGhIscorEaR.Font = new Font("SimSun-ExtB", 16);

            lBjGhIscorEaR.TextAlign = ContentAlignment.MiddleCenter;

            lBjGhIscorEaR.ForeColor = Color.White;

            lBjGhIscorEaR.BackColor = Color.LightGray;

            lBjGhIscorEaR.Tag = "1";

            this.Controls.Add(lBjGhIscorEaR);
        }

        private void pB_arkanoiD()
        {
            pBarkanoiD.Location = new Point(410, 190);

            pBarkanoiD.Size = new Size(250, 100);

            pBarkanoiD.Image = Resources.ArK_IMG;

            pBarkanoiD.SizeMode = PictureBoxSizeMode.StretchImage;

            pBarkanoiD.BackColor = Color.Red;

            pBarkanoiD.Tag = "2";

            this.Controls.Add(pBarkanoiD);
        }

        private void pB_seleccionaRjuegO()
        {
            pBseleccionaRjuegO.Location = new Point(410, 338);

            pBseleccionaRjuegO.Size = new Size(20, 20);

            pBseleccionaRjuegO.Image = Resources.FledeR_IMG;

            pBseleccionaRjuegO.SizeMode = PictureBoxSizeMode.StretchImage;

            pBseleccionaRjuegO.BackColor = Color.White;

            pBseleccionaRjuegO.Tag = "2";

            this.Controls.Add(pBseleccionaRjuegO);
        }

        private void lB_1playeRarK()
        {
            lB1playeRarK.Location = new Point(450, 330);

            lB1playeRarK.Size = new Size(170, 35);

            lB1playeRarK.Text = "1 PLAYER";

            lB1playeRarK.Font = new Font("SimSun-ExtB", 16);

            lB1playeRarK.TextAlign = ContentAlignment.MiddleLeft;

            lB1playeRarK.ForeColor = Color.White;

            lB1playeRarK.BackColor = Color.LightGray;

            lB1playeRarK.Tag = "3";

            this.Controls.Add(lB1playeRarK);
        }

        private void lB_2playerSarK()
        {
            lB2playerSarK.Location = new Point(450, 380);

            lB2playerSarK.Size = new Size(170, 35);

            lB2playerSarK.Text = "2 PLAYERS";

            lB2playerSarK.Font = new Font("SimSun-ExtB", 16);

            lB2playerSarK.TextAlign = ContentAlignment.MiddleLeft;

            lB2playerSarK.ForeColor = Color.White;

            lB2playerSarK.BackColor = Color.LightGray;

            lB2playerSarK.Tag = "3";

            this.Controls.Add(lB2playerSarK);
        }

        private void lB_taitOarK()
        {
            lBtaitOarK.Location = new Point(450, 460);

            lBtaitOarK.Size = new Size(170, 50);

            lBtaitOarK.Text = "TAITO";

            lBtaitOarK.Font = new Font("SimSun-ExtB", 25);

            lBtaitOarK.TextAlign = ContentAlignment.MiddleCenter;

            lBtaitOarK.ForeColor = Color.Red;

            lBtaitOarK.BackColor = Color.LightGray;

            lBtaitOarK.Tag = "3";

            this.Controls.Add(lBtaitOarK);
        }

        private void lB_autoR01()
        {
            lBautoR01.Location = new Point(365, 530);

            lBautoR01.Size = new Size(350, 35);

            lBautoR01.Text = "© TAITO CORPORATION 1987";

            lBautoR01.Font = new Font("SimSun-ExtB", 16);

            lBautoR01.TextAlign = ContentAlignment.MiddleCenter;

            lBautoR01.ForeColor = Color.White;

            lBautoR01.BackColor = Color.LightGray;

            lBautoR01.Tag = "3";

            this.Controls.Add(lBautoR01);
        }

        private void lB_autoR02()
        {
            lBautoR02.Location = new Point(365, 570);

            lBautoR02.Size = new Size(350, 35);

            lBautoR02.Text = "LICENSE BY";

            lBautoR02.Font = new Font("SimSun-ExtB", 16);

            lBautoR02.TextAlign = ContentAlignment.MiddleCenter;

            lBautoR02.ForeColor = Color.White;

            lBautoR02.BackColor = Color.LightGray;

            lBautoR02.Tag = "3";

            this.Controls.Add(lBautoR02);
        }

        private void lB_autoR03()
        {
            lBautoR03.Location = new Point(365, 610);

            lBautoR03.Size = new Size(350, 35);

            lBautoR03.Text = "NINTENDO OF AMERICA INC.";

            lBautoR03.Font = new Font("SimSun-ExtB", 16);

            lBautoR03.TextAlign = ContentAlignment.MiddleCenter;

            lBautoR03.ForeColor = Color.White;

            lBautoR03.BackColor = Color.LightGray;

            lBautoR03.Tag = "3";

            this.Controls.Add(lBautoR03);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && desactivaRteclaS == true)
            {
                Console.Beep();

                pBseleccionaRjuegO.Location = new Point(410, 338);
            }

            else if (e.KeyCode == Keys.Down && desactivaRteclaS == true)
            {
                Console.Beep();

                pBseleccionaRjuegO.Location = new Point(410, 388);
            }

            else if (e.KeyCode == Keys.Enter && pBseleccionaRjuegO.Location.Y == 338 && desactivaRteclaS == true)
            {
                sN_insertaRmonedA.Play();

                seleccioN_1playeR();

                lB_mensajE();

                timeR_moVmensajE();

                timeR_esperAmensajE();
            }

            else if (e.KeyCode == Keys.Enter && pBseleccionaRjuegO.Location.Y == 388 && desactivaRteclaS == true)
            {
                sN_insertaRmonedA.Play();

                MessageBox.Show("¡Modo 2 PLAYERS EN CONSTRUCCIÓN!", "Mensaje . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (e.KeyCode == Keys.Left)
            {
                if (pBbarrA.Left >= pBcanvaS.Left + 5)
                {
                    pBbarrA.Left = pBbarrA.Left - 5;
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (pBbarrA.Left <= pBcanvaS.Width - 20)
                {
                    pBbarrA.Left = pBbarrA.Left + 5;
                }
            }

            else if (e.KeyCode == Keys.R && reiniciaRjuegO == true)
            {
                this.Hide();

                Form reiniciaRfrM = new Form1();

                reiniciaRfrM.Show();
            }
        }

        private void seleccioN_1playeR()
        {
            foreach (PictureBox desP2 in this.Controls.OfType<PictureBox>())
            {
                if (desP2.Tag == "2")
                {
                    desP2.Visible = false;
                }
            }

            foreach (Label desL3 in this.Controls.OfType<Label>())
            {
                if (desL3.Tag == "3")
                {
                    desL3.Visible = false;
                }
            }
        }

        private void lB_mensajE()
        {
            lBmensajE.Location = new Point(290, 670);

            lBmensajE.Size = new Size(520, 405);

            lBmensajE.Text = "THE ERA AND TIME OF\nTHIS STORY IS UNKNOWN.\n\nAFTER THE MOTHER SHIP\n\"ARKANOID\" WAS DESTROYED,\nA SPACECRAFT \"VAUS\"\nSCRAMBLED AWAY FROM IT.\n\nBUT ONLY TO BE\nTRAPPED IN SPACE WARPED\nBY SOMEONE . . . . . .";

            lBmensajE.Font = new Font("Courier New", 20, FontStyle.Bold);

            lBmensajE.TextAlign = ContentAlignment.MiddleLeft;

            lBmensajE.ForeColor = Color.White;

            lBmensajE.BackColor = Color.LightGray;

            this.Controls.Add(lBmensajE);
        }

        private void timeR_moVmensajE()
        {
            tR_moVmensajE.Tick += TR_moVmensajE_Tick;

            tR_moVmensajE.Interval = 100;

            tR_moVmensajE.Start();
        }

        private void TR_moVmensajE_Tick(object? sender, EventArgs e)
        {
            bThelParkA.Enabled = false;

            desactivaRteclaS = false; /*Desde que sale el mensaje ya no se detectan las teclas para seleccionar el juego*/

            lBmensajE.Top = lBmensajE.Top - 10;

            if (lBmensajE.Top <= 190)
            {
                tR_moVmensajE.Stop();
            }
        }

        private void timeR_esperAmensajE()
        {
            tR_esperAmensajE.Tick += TR_esperAmensajE_Tick;

            tR_esperAmensajE.Interval = 100;

            tR_esperAmensajE.Start();
        }

        private void TR_esperAmensajE_Tick(object? sender, EventArgs e)
        {
            contadoResperA++;

            if (contadoResperA == 100)
            {
                lBmensajE.Visible = false;

                foreach (Control apareceRPL in this.Controls)
                {
                    if (apareceRPL.Tag == "2" || apareceRPL.Tag == "3")
                    {
                        apareceRPL.Visible = true;
                    }
                }

                sN_intrO.Play();

                timeR_labeLparpadeantE();
            }

            else if (contadoResperA == 105)
            {
                pBseleccionaRjuegO.Visible = false;
            }

            else if (contadoResperA == 155)
            {
                tR_labeLparpadeantE.Stop();

                lB_1playeRarK();
            }

            else if (contadoResperA == 160)
            {
                foreach (Control desaparecEPL in this.Controls)
                {
                    if (desaparecEPL.Tag == "2" || desaparecEPL.Tag == "3")
                    {
                        desaparecEPL.Visible = false;
                    }
                }

                lB_rounD();
            }

            else if (contadoResperA == 170)
            {
                sN_empezarJuego.Play();

                posicionL_nuevA();

                pB_vidaS();

                lBrounD.Location = new Point(800, 578);

                pB_canvaS();

                lB_playeR1();

                lB_readY();
            }

            else if (contadoResperA == 200)
            {
                lBplayeR1.Visible = false;

                lBreadY.Visible = false;

                lB_bloqueS();

                pB_barrA();

                pB_pelotA();

                pBcanvaS.SendToBack(); /*Mande el canvas hacia abajo para que los otros elementos funcionen correctamente*/

                tR_esperAmensajE.Stop();

                timeR_moVpeLelIblO();
            }
        }

        private void timeR_labeLparpadeantE()
        {
            tR_labeLparpadeantE.Tick += TR_labeLparpadeantE_Tick;

            tR_labeLparpadeantE.Interval = 300;

            tR_labeLparpadeantE.Start();
        }

        private void TR_labeLparpadeantE_Tick(object? sender, EventArgs e)
        {
            if (lB1playeRarK.ForeColor == Color.White)
            {
                lB1playeRarK.ForeColor = Color.Black;

                lB1playeRarK.BackColor = Color.Black;
            }

            else
            {
                lB1playeRarK.ForeColor = Color.White;

                lB1playeRarK.BackColor = Color.LightGray;
            }
        }

        private void lB_rounD()
        {
            lBrounD.Location = new Point(450, 360);

            lBrounD.Size = new Size(170, 35);

            lBrounD.Text = "ROUND 1";

            lBrounD.Font = new Font("SimSun-ExtB", 16);

            lBrounD.TextAlign = ContentAlignment.MiddleCenter;

            lBrounD.ForeColor = Color.White;

            lBrounD.BackColor = Color.LightGray;

            this.Controls.Add(lBrounD);
        }

        private void posicionL_nuevA()
        {
            lBhIscorEA.Location = new Point(800, 85);

            lBjGhIscorEaR.Location = new Point(800, 130);

            lBscorEaR1.Location = new Point(800, 200);

            lBjGscorE1.Location = new Point(800, 245);
        }

        /*https://es.stackoverflow.com/questions/341573/redondear-esquinas-de-un-textbox*/

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] /*Importe una libreria externa para redondear elementos*/
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,

            int nTopRect,

            int nRightRect,

            int nBottomRect,

            int nWidthEllipse,

            int nHeightEllipse
            );

        private void pB_vidaS()
        {
            pBvidas = new PictureBox[2];

            int v;

            int xv = 800;

            for (v = 0; v < 2; v++)
            {
                pBvidas[v] = new PictureBox();

                pBvidas[v].Location = new Point(xv, 350);

                pBvidas[v].Size = new Size(50, 15);

                pBvidas[v].BackColor = Color.Gray;

                pBvidas[v].Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, pBvidas[v].Width, pBvidas[v].Height, 10, 10));

                this.Controls.Add(pBvidas[v]);

                xv = xv + 80;
            }
        }

        private void pB_canvaS()
        {
            pBcanvaS.Location = new Point(75, 85);

            pBcanvaS.Size = new Size(700, 530);

            pBcanvaS.Image = Resources.Fondo_IMG;

            pBcanvaS.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(pBcanvaS);
        }

        private void lB_playeR1()
        {
            lBplayeR1.Location = new Point(270, 350);

            lBplayeR1.Size = new Size(170, 35);

            lBplayeR1.Text = "PLAYER 1";

            lBplayeR1.Font = new Font("SimSun-ExtB", 16);

            lBplayeR1.TextAlign = ContentAlignment.MiddleCenter;

            lBplayeR1.ForeColor = Color.White;

            lBplayeR1.BackColor = Color.LightGray;

            pBcanvaS.Controls.Add(lBplayeR1);
        }

        private void lB_readY()
        {
            lBreadY.Location = new Point(270, 420);

            lBreadY.Size = new Size(170, 35);

            lBreadY.Text = "READY";

            lBreadY.Font = new Font("SimSun-ExtB", 16);

            lBreadY.TextAlign = ContentAlignment.MiddleCenter;

            lBreadY.ForeColor = Color.White;

            lBreadY.BackColor = Color.LightGray;

            pBcanvaS.Controls.Add(lBreadY);
        }

        private void lB_bloqueS()
        {
            lBbloqueS = new Label[6, 11];

            int x = 100;

            int y = 120;

            int f, c;

            for (f = 0; f < 6; f++)
            {
                for (c = 0; c < 11; c++)
                {
                    lBbloqueS[f, c] = new Label();

                    lBbloqueS[f, c].Location = new Point(x, y);

                    lBbloqueS[f, c].Size = new Size(50, 10);

                    lBbloqueS[f, c].Tag = "bloques";

                    lBbloqueS[f, c].TabIndex = f;

                    this.Controls.Add(lBbloqueS[f, c]);

                    x = x + 60;

                    Color[] arreglOcoloreS = new Color[] { Color.Gray, Color.Red, Color.Aqua, Color.Orange, Color.Pink, Color.GreenYellow };

                    int ac;

                    for (ac = 0; ac <= arreglOcoloreS.Length; ac++)
                    {
                        if (f == ac)
                        {
                            lBbloqueS[f, c].BackColor = arreglOcoloreS[ac];
                        }
                    }
                }

                x = 100;

                y = y + 20;
            }
        }

        private void pB_pelotA()
        {
            pBpelotA.Location = new Point(438, 535);

            pBpelotA.Size = new Size(20, 20);

            pBpelotA.BackColor = Color.DarkOrange;

            pBpelotA.BorderStyle = BorderStyle.FixedSingle;

            pBpelotA.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, pBpelotA.Width, pBpelotA.Height, 20, 20));

            this.Controls.Add(pBpelotA);
        }

        private void pB_barrA()
        {
            pBbarrA.Location = new Point(402, 555);

            pBbarrA.Size = new Size(90, 15);

            pBbarrA.BackColor = Color.Gray;

            pBbarrA.BorderStyle = BorderStyle.FixedSingle;

            pBbarrA.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, pBbarrA.Width, pBbarrA.Height, 10, 10));

            this.Controls.Add(pBbarrA);
        }

        private void movimientO_pelotA()
        {
            pBpelotA.Left = pBpelotA.Left + moVpelotAX; /*Hacia la derecha*/

            pBpelotA.Top = pBpelotA.Top - moVpelotAY; /*Hacia arriba*/

            if (pBpelotA.Left + pBpelotA.Width > pBcanvaS.Width + 65 || pBpelotA.Left < 75)
            {
                moVpelotAX = -moVpelotAX;
            }

            else if (pBpelotA.Top < 85 || pBpelotA.Bounds.IntersectsWith(pBbarrA.Bounds))
            {
                moVpelotAY = -moVpelotAY;
            }

            if (pBpelotA.Bounds.IntersectsWith(pBbarrA.Bounds))
            {
                sN_rebotEpelotA.Play();
            }
        }

        private void eliminA_bloqueS()
        {
            foreach (Control bloqueS in this.Controls)
            {
                if (bloqueS is Label && bloqueS.Tag == "bloques")
                {
                    if (pBpelotA.Bounds.IntersectsWith(bloqueS.Bounds))
                    {
                        Controls.Remove(bloqueS);

                        int[] puntoSbloqueS = new int[] { 80, 160, 240, 320, 400, 480 };

                        int pb;

                        for (pb = 0; pb <= puntoSbloqueS.Length; pb++)
                        {
                            if (bloqueS.TabIndex == pb)
                            {
                                puntoSarkanoiD = puntoSarkanoiD + puntoSbloqueS[pb];
                            }
                        }

                        lBjGscorE1.Text = puntoSarkanoiD.ToString();
                    }
                }
            }
        }

        private void ganadoR_perdedoR()
        {
            if (puntoSarkanoiD == 18480)
            {
                pBpelotA.Visible = false;

                pBbarrA.Visible = false;

                tR_moVpeLelIblO.Stop();

                lB_ganadoR();

                sN_gamEwiN.Play();

                reiniciaRjuegO = true;
            }

            else if (pBpelotA.Location.Y >= 590)
            {
                vidaSjugadoR = vidaSjugadoR - 1;

                pBpelotA.Location = new Point(438, 535);

                moVpelotAY = -moVpelotAY; /*La pelota va hacia arriba de nuevo*/

                if (vidaSjugadoR == 2)
                {
                    pBvidas[1].Visible = false;
                }

                else if (vidaSjugadoR == 1)
                {
                    pBvidas[0].Visible = false;
                }

                else if (vidaSjugadoR == 0)
                {
                    foreach (Control desPbloqueS in this.Controls)
                    {
                        if (desPbloqueS.Tag == "bloques")
                        {
                            desPbloqueS.Visible = false;
                        }
                    }

                    pBpelotA.Visible = false;

                    pBbarrA.Visible = false;

                    tR_moVpeLelIblO.Stop();

                    lB_perdedoR();

                    sN_gamEoveR.Play();

                    reiniciaRjuegO = true;
                }
            }
        }

        private void lB_ganadoR()
        {
            lBganadoR.Location = new Point(250, 265);

            lBganadoR.Size = new Size(230, 35);

            lBganadoR.Text = "¡HAS GANADO!";

            lBganadoR.Font = new Font("SimSun-ExtB", 16);

            lBganadoR.TextAlign = ContentAlignment.MiddleCenter;

            lBganadoR.ForeColor = Color.White;

            lBganadoR.BackColor = Color.Lime;

            pBcanvaS.Controls.Add(lBganadoR);
        }

        private void lB_perdedoR()
        {
            lBperdedoR.Location = new Point(250, 265);

            lBperdedoR.Size = new Size(230, 35);

            lBperdedoR.Text = "¡HAS PERDIDO!";

            lBperdedoR.Font = new Font("SimSun-ExtB", 16);

            lBperdedoR.TextAlign = ContentAlignment.MiddleCenter;

            lBperdedoR.ForeColor = Color.White;

            lBperdedoR.BackColor = Color.Red;

            pBcanvaS.Controls.Add(lBperdedoR);
        }

        private void timeR_moVpeLelIblO()
        {
            tR_moVpeLelIblO.Tick += TR_moVpeLelIblO_Tick;

            tR_moVpeLelIblO.Interval = 50;

            tR_moVpeLelIblO.Start();
        }

        private void TR_moVpeLelIblO_Tick(object? sender, EventArgs e)
        {
            movimientO_pelotA();

            eliminA_bloqueS();

            ganadoR_perdedoR();
        }
    }
}