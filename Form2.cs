using ArkanoiD_ArcadE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkanoiD_ArcadE
{
    public partial class Form2 : Form
    {
        Panel pSinstruccioneS = new Panel();

        Label bTclosEinstruccioneS = new Label();

        Panel pLinstruccioneSjuegO = new Panel();

        Label labeL01 = new Label();

        PictureBox[] pBarkanoiD;

        Label labeL02 = new Label();

        Label labeL03 = new Label();

        Label labeL04 = new Label();

        Label labeL05 = new Label();

        Label labeL06 = new Label();

        Label labeL07 = new Label();

        Label labeL08 = new Label();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.ArK_ICO;

            this.BackColor = Color.Black;

            paneL_instruccioneS();

            paneL_instruccioneSjuegO();

            labeL_01();

            pB_arkanoiD();

            labeL_02();

            labeL_03();

            labeL_04();

            labeL_05();

            labeL_06();

            labeL_07();

            labeL_08();
        }

        private void paneL_instruccioneS()
        {
            pSinstruccioneS.Location = new Point(0, 0);

            pSinstruccioneS.Size = new Size(1029, 35);

            pSinstruccioneS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            pSinstruccioneS.BackColor = Color.Blue;

            this.Controls.Add(pSinstruccioneS);


            bTclosEinstruccioneS.Location = new Point(1007, 0);

            bTclosEinstruccioneS.Size = new Size(20, 35);

            bTclosEinstruccioneS.Text = "X";

            bTclosEinstruccioneS.Font = new Font("SimSun-ExtB", 14);

            bTclosEinstruccioneS.TextAlign = ContentAlignment.MiddleLeft;

            bTclosEinstruccioneS.ForeColor = Color.White;

            bTclosEinstruccioneS.BackColor = Color.Red;

            bTclosEinstruccioneS.Cursor = Cursors.Hand;

            bTclosEinstruccioneS.MouseHover += BTclosEinstruccioneS_MouseHover;

            bTclosEinstruccioneS.MouseLeave += BTclosEinstruccioneS_MouseLeave;

            bTclosEinstruccioneS.Click += BTclosEinstruccioneS_Click;

            pSinstruccioneS.Controls.Add(bTclosEinstruccioneS);
        }

        private void BTclosEinstruccioneS_MouseHover(object? sender, EventArgs e)
        {
            bTclosEinstruccioneS.ForeColor = Color.Black;

            bTclosEinstruccioneS.BackColor = Color.White;
        }

        private void BTclosEinstruccioneS_MouseLeave(object? sender, EventArgs e)
        {
            bTclosEinstruccioneS.ForeColor = Color.White;

            bTclosEinstruccioneS.BackColor = Color.Red;
        }

        private void BTclosEinstruccioneS_Click(object? sender, EventArgs e)
        {
            this.Hide();

            Form juegOfrM = new Form1();

            juegOfrM.Show();
        }

        private void paneL_instruccioneSjuegO()
        {
            pLinstruccioneSjuegO.Location = new Point(230, 190);

            pLinstruccioneSjuegO.Size = new Size(580, 320);

            pLinstruccioneSjuegO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            pLinstruccioneSjuegO.BackColor = Color.Red;

            this.Controls.Add(pLinstruccioneSjuegO);
        }

        private void labeL_01()
        {
            labeL01.Location = new Point(5, 9);

            labeL01.Size = new Size(400, 25);

            labeL01.Text = "Instrucciones del JUEGO ARKANOID ARCADE";

            labeL01.Font = new Font("SimSun-ExtB", 11, FontStyle.Underline);

            labeL01.TextAlign = ContentAlignment.BottomLeft;

            labeL01.ForeColor = Color.Black;

            pLinstruccioneSjuegO.Controls.Add(labeL01);
        }

        private void pB_arkanoiD()
        {
            pBarkanoiD = new PictureBox[3];

            int pa;

            int x = 410;

            for (pa = 0; pa < 3; pa++)
            {
                pBarkanoiD[pa] = new PictureBox();

                pBarkanoiD[pa].Location = new Point(x, 8);

                pBarkanoiD[pa].Size = new Size(25, 25);

                pBarkanoiD[pa].Image = Resources.ArkanoiD_IMG;

                pBarkanoiD[pa].SizeMode = PictureBoxSizeMode.StretchImage;

                pLinstruccioneSjuegO.Controls.Add(pBarkanoiD[pa]);

                x = x + 30;
            }
        }

        private void labeL_02()
        {
            labeL02.Location = new Point(5, 55);

            labeL02.Size = new Size(140, 25);

            labeL02.Text = "Modo JUGADOR:";

            labeL02.Font = new Font("SimSun-ExtB", 11);

            labeL02.TextAlign = ContentAlignment.MiddleLeft;

            labeL02.ForeColor = Color.Black;

            labeL02.BackColor = Color.Blue;

            pLinstruccioneSjuegO.Controls.Add(labeL02);
        }

        private void labeL_03()
        {
            labeL03.Location = new Point(5, 95);

            labeL03.Size = new Size(540, 25);

            labeL03.Text = "1 PLAYER  >> Elije ↑ + Enter,";

            labeL03.Font = new Font("SimSun-ExtB", 11);

            labeL03.TextAlign = ContentAlignment.MiddleLeft;

            labeL03.ForeColor = Color.White;

            pLinstruccioneSjuegO.Controls.Add(labeL03);
        }

        private void labeL_04()
        {
            labeL04.Location = new Point(5, 125);

            labeL04.Size = new Size(540, 25);

            labeL04.Text = "2 PLAYERS >> Elije ↓ + Enter,";

            labeL04.Font = new Font("SimSun-ExtB", 11);

            labeL04.TextAlign = ContentAlignment.MiddleLeft;

            labeL04.ForeColor = Color.White;

            pLinstruccioneSjuegO.Controls.Add(labeL04);
        }

        private void labeL_05()
        {
            labeL05.Location = new Point(5, 165);

            labeL05.Size = new Size(240, 25);

            labeL05.Text = "Movimiento de la BARRA:";

            labeL05.Font = new Font("SimSun-ExtB", 11);

            labeL05.TextAlign = ContentAlignment.MiddleLeft;

            labeL05.ForeColor = Color.Black;

            labeL05.BackColor = Color.Blue;

            pLinstruccioneSjuegO.Controls.Add(labeL05);
        }

        private void labeL_06()
        {
            labeL06.Location = new Point(5, 205);

            labeL06.Size = new Size(540, 25);

            labeL06.Text = "Utiliza las teclas de navegación izquierda y derecha.";

            labeL06.Font = new Font("SimSun-ExtB", 11);

            labeL06.TextAlign = ContentAlignment.MiddleLeft;

            labeL06.ForeColor = Color.White;

            pLinstruccioneSjuegO.Controls.Add(labeL06);
        }

        private void labeL_07()
        {
            labeL07.Location = new Point(5, 245);

            labeL07.Size = new Size(210, 25);

            labeL07.Text = "Reinicio del JUEGO:";

            labeL07.Font = new Font("SimSun-ExtB", 11);

            labeL07.TextAlign = ContentAlignment.MiddleLeft;

            labeL07.ForeColor = Color.Black;

            labeL07.BackColor = Color.Blue;

            pLinstruccioneSjuegO.Controls.Add(labeL07);
        }

        private void labeL_08()
        {
            labeL08.Location = new Point(5, 285);

            labeL08.Size = new Size(540, 25);

            labeL08.Text = "Cuando ganes o pierdas elije la tecla R.";

            labeL08.Font = new Font("SimSun-ExtB", 11);

            labeL08.TextAlign = ContentAlignment.MiddleLeft;

            labeL08.ForeColor = Color.White;

            pLinstruccioneSjuegO.Controls.Add(labeL08);
        }
    }
}