using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaceriaPatos
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        // rand.Next(c, d) entero aleatorio de c a d-1

        int posPerroX = 5;
        int conta = 0;
        int tiros = 100;
        int aciertos = 0;
        int fallos = 0;
        int faseJuego = 0;
        int bonus = 0;
        int golpes = 0;

        public Form1()
        {
            InitializeComponent();
            pbFondo.SizeMode = PictureBoxSizeMode.Zoom;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SIntro20seg);
            audio.Play();
            timerIntro.Enabled = true;
        }

        private void pbFondo_Click(object sender, EventArgs e)
        {
            if (faseJuego == 0 || faseJuego == 2)
            {
                return;
            }

            MouseEventArgs mouse = (MouseEventArgs)e;

            int x1 = mouse.X - 27;
            int y1 = mouse.Y - 44;
            pbDisparo.Location = new Point(x1,y1);
            pbDisparo.Visible = true;
            timerDisparo.Enabled = true;

            // No se le atino al pato
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SDisparo2);
            audio.Play();

            // Tiro fallido
            pbPerro.Visible = false;
            pbPerroFallo.Location = new Point(posPerroX, 450);
            pbPerroFallo.Visible = true;

            fallos++;
            tiros++;
            tbTiros.Text = tiros.ToString();
            tbAciertosPorcentaje.Text = (aciertos * 100 / (tiros)).ToString("N0") + " %";

            //MessageBox.Show(String.Format("X = {0}, Y = {1}", mouse.X, mouse.Y));   // 820x390
        }

        private void pbPato_Click(object sender, EventArgs e)
        {
            // Sí se le atino al pato
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SDisparo);
            audio.Play();

            aciertos++;
            tiros++;
            tbAciertos.Text = aciertos.ToString();
            tbTiros.Text = tiros.ToString();
            tbAciertosPorcentaje.Text = (aciertos * 100 / (tiros)).ToString("N0") + " %";

            // Hit
            timerHit.Enabled = true;

            switch (rand.Next(1, 7).ToString())
            {
                case "1":
                    pbPato.Image = Properties.Resources.HitPow;
                    break;
                case "2":
                    pbPato.Image = Properties.Resources.HitBoom;
                    break;
                case "3":
                    pbPato.Image = Properties.Resources.HitKapow;
                    break;
                case "4":
                    pbPato.Image = Properties.Resources.HitPow;
                    break;
                case "5":
                    pbPato.Image = Properties.Resources.HitZap;
                    break;
                default:    // Tiene más probilidad esta 2/7
                    pbPato.Image = Properties.Resources.HitPow;
                    break;
            }

            // Pato herido cerca del perro
            SoundPlayer audio2 = new SoundPlayer(Properties.Resources.SPatoHerido);
            audio2.Play();

            pbPatoHerido.Location = new Point(posPerroX, 350);
            pbPatoHerido.Visible = true;
            timerPatoHerido.Enabled = true;
        }


        private void timerPato_Tick(object sender, EventArgs e)
        {
            if (cbModoJuego.SelectedIndex == 1)
            {
                Point ubicacionContinua = pbPato.Location;

                int factor = 10;

                switch (rand.Next(1, 9).ToString()) // Ocho direcciones: vert horiz diag
                {
                    case "1":    // >
                        ubicacionContinua.X += rand.Next(7, 10) * factor;
                        break;
                    case "2":    // \>
                        ubicacionContinua.X += rand.Next(7, 10) * factor;
                        ubicacionContinua.Y += rand.Next(7, 10) * factor;
                        break;
                    case "3":    // v
                        ubicacionContinua.Y += rand.Next(7, 10) * factor;
                        break;
                    case "4":    // </
                        ubicacionContinua.X -= rand.Next(7, 10) * factor;
                        ubicacionContinua.Y += rand.Next(7, 10) * factor;
                        break;
                    case "5":    // <
                        ubicacionContinua.X -= rand.Next(7, 10) * factor;
                        break;
                    case "6":    // <\
                        ubicacionContinua.X -= rand.Next(7, 10) * factor;
                        ubicacionContinua.Y -= rand.Next(7, 10) * factor;
                        break;
                    case "7":    // ^
                        ubicacionContinua.Y -= rand.Next(7, 10) * factor;
                        break;
                    case "8":    // />
                        ubicacionContinua.X += rand.Next(7, 10) * factor;
                        ubicacionContinua.Y -= rand.Next(7, 10) * factor;
                        break;
                }


                if (ubicacionContinua.X > 749)
                {
                    ubicacionContinua.X = 5;
                }
                if (ubicacionContinua.X < 5)
                {
                    ubicacionContinua.X = 749;
                }
                if (ubicacionContinua.Y > 379)
                {
                    ubicacionContinua.Y = 5;
                }
                if (ubicacionContinua.Y < 5)
                {
                    ubicacionContinua.Y = 379;
                }

                pbPato.Location = ubicacionContinua;
            }
            else
            {
                pbPato.Location = new Point(rand.Next(5, 750), rand.Next(5, 380));
            }
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SPato);
            audio.Play();
        }

        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            timerDisparo.Enabled = false;
            pbDisparo.Visible = false;

            // Tiro fallido
            SoundPlayer audio2 = new SoundPlayer(Properties.Resources.SPerroFallo);
            audio2.Play();

        }

        private void timerPerro_Tick(object sender, EventArgs e)
        {
            if (pbPerro.Visible)
            {
                posPerroX = (posPerroX + 30) % 800;
                conta = 0;
            }
            else
            {
                conta++;
            }
           
            pbPerro.Location = new Point(posPerroX, 450);

            if(ProgressBarTiempo.Value > 0)
            {
                ProgressBarTiempo.Value--;

                if (ProgressBarTiempo.Value == 0)
                {
                    //MessageBox.Show("Tiempo terminado");
                    //timerPerro.Enabled = false;
                    faseJuego = 2;

                    // Final del Juego
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.SFanfarriaFin);
                    audio.Play();

                    cbModoJuego.Visible = false;

                    timerMid.Enabled = true;

                    timerDisparo.Enabled = false;
                    timerHit.Enabled = false;
                    timerPato.Enabled = false;
                    timerPatoHerido.Enabled = false;
                    timerPerro.Enabled = false;
                    timerPerroHerido.Enabled = false;
                    timerBonus.Enabled = false;
                    timerReloj.Enabled = false;

                    pbPato.Visible = false;
                    pbPatoHerido.Visible = false;
                    pbPerro.Visible = false;
                    pbPerroAcierto.Visible = false;
                    pbPerroFallo.Visible = false;
                    pbPerroHerido.Visible = false;
                    pbDisparo.Visible = false;
                    pbReloj.Visible = false;

                    pbFondo.Image = Properties.Resources.Presentacion;

                    lAciertos.Text = "Aciertos: " + aciertos.ToString() + "   " + tbAciertosPorcentaje.Text;
                    lFallos.Text = "Fallos: " + fallos.ToString();
                    lBalasPerro.Text = "Golpes al Perro: " + golpes.ToString();
                    lBonusTiempo.Text = "Bonus de Tiempo: " + bonus.ToString();

                    lAciertos.Visible = true;
                    lFallos.Visible = true;
                    lBalasPerro.Visible = true;
                    lBonusTiempo.Visible = true;
                }
            }


            if (conta == 2)
            {
                pbPerroFallo.Visible = false;
                pbPerroAcierto.Visible = false;
                pbPerro.Visible = true;
                conta = 0;
            }
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            cbModoJuego.Visible = true;
            timerIntro.Enabled = false;
            timerMid.Enabled = false;
            timerReMid.Enabled = false;

            SoundPlayer audio = new SoundPlayer(Properties.Resources.SFanfarriaInicio);
            audio.Play();

            tiros = 0;
            aciertos = 0;
            fallos = 0;
            bonus = 0;
            golpes = 0;
            conta = 0;
            faseJuego = 1;

            lCaceria.Visible = false;
            lDePatos.Visible = false;
            lAutor.Visible = false;

            lAciertos.Visible = false;
            lFallos.Visible = false;
            lBalasPerro.Visible = false;
            lBonusTiempo.Visible = false;

            tbAciertos.Text = aciertos.ToString();
            tbTiros.Text = tiros.ToString();
            ProgressBarTiempo.Value = 100;

            pbFondo.Image = Properties.Resources.Fondo02;
            pbFondo.SizeMode = PictureBoxSizeMode.Zoom;

            pbDisparo.Parent = pbFondo;
            pbDisparo.Visible = false;
            pbDisparo.SizeMode = PictureBoxSizeMode.Zoom;

            pbPato.Parent = pbFondo;
            pbPato.Visible = true;
            pbPato.SizeMode = PictureBoxSizeMode.Zoom;
            pbPato.Location = new Point(rand.Next(5, 800), rand.Next(5, 380));

            pbPerro.Parent = pbFondo;
            pbPerro.Visible = true;
            pbPerro.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerro.Location = new Point(posPerroX, 450);

            pbPerroFallo.Parent = pbFondo;
            pbPerroFallo.Visible = false;
            pbPerroFallo.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerroFallo.Location = new Point(posPerroX, 450);

            pbPerroAcierto.Parent = pbFondo;
            pbPerroAcierto.Visible = false;
            pbPerroAcierto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerroAcierto.Location = new Point(posPerroX, 450);

            pbPatoHerido.Parent = pbFondo;
            pbPatoHerido.Visible = false;
            pbPatoHerido.SizeMode = PictureBoxSizeMode.Zoom;
            pbPatoHerido.Location = new Point(posPerroX, 450);

            pbPerroHerido.Parent = pbFondo;
            pbPerroHerido.Visible = false;
            pbPerroHerido.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerroHerido.Location = new Point(posPerroX, 450);

            pbReloj.Parent = pbFondo;
            pbReloj.Visible = false;
            pbReloj.SizeMode = PictureBoxSizeMode.Zoom;
            pbReloj.Location = new Point(posPerroX, 450);

            timerBonus.Enabled = true;
            timerPato.Enabled = true;
            timerPerro.Enabled = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMasVelocidad_Click(object sender, EventArgs e)
        {
            timerPato.Enabled = false;
            int duracion = timerPato.Interval - 100;
            if (duracion < 100)
            {
                duracion = 100;
            }
            timerPato.Interval = duracion;
            timerPato.Enabled = true;
            pbPato.Location = new Point(rand.Next(5, 750), rand.Next(5, 380));
        }

        private void bMenosVelocidad_Click(object sender, EventArgs e)
        {
            timerPato.Enabled = false;
            int duracion = timerPato.Interval + 100;
            if (duracion > 3000)
            {
                duracion = 3000;
            }
            timerPato.Interval = duracion;
            timerPato.Enabled = true;
            pbPato.Location = new Point(rand.Next(5, 750), rand.Next(5, 380));
        }

        private void timerPatoHerido_Tick(object sender, EventArgs e)
        {
            pbPatoHerido.Visible = false;
            timerPatoHerido.Enabled = false;

            // Perro
            pbPerro.Visible = false;
            pbPerroAcierto.Location = new Point(posPerroX, 450);
            pbPerroAcierto.Visible = true;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SPerroExito);
            audio.Play();
        }

        private void timerHit_Tick(object sender, EventArgs e)
        {
            pbPato.Image = Properties.Resources.PatoDerecha;
        }

        private void pbPerro_Click(object sender, EventArgs e)
        {
            // Perro herido
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SPerroHerido);
            audio.Play();

            golpes++;
            pbPerroHerido.Location = new Point(posPerroX, 450);
            pbPerro.Visible = false;
            pbPerroHerido.Visible = true;
            timerPerroHerido.Enabled = true;
        }

        private void timerPerroHerido_Tick(object sender, EventArgs e)
        {
            timerPerroHerido.Enabled = false;
            pbPerroHerido.Visible = false;
            pbPerro.Visible = true;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SPerroLadrando);
            audio.Play();
        }

        private void timerBonus_Tick(object sender, EventArgs e)
        {
            pbReloj.Location= new Point(rand.Next(10, 750), rand.Next(10, 550));
            pbReloj.Image = Properties.Resources.Reloj;
            pbReloj.Visible = true;
            timerReloj.Enabled = true;
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            timerReloj.Enabled = false;
            pbReloj.Visible = false;
        }

        private void pbReloj_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SBonusTiempo);
            audio.Play();

            bonus++;
            //pbReloj.Image = Properties.Resources.Disparo2;
            pbReloj.Image = Properties.Resources.TiempoExtra;

            int tiempoAgregado = rand.Next(5, 16);
            if(ProgressBarTiempo.Value + tiempoAgregado > 100)
            {
                ProgressBarTiempo.Value = 100;
            }
            else
            {
                ProgressBarTiempo.Value = ProgressBarTiempo.Value + tiempoAgregado;
            }
            
        }

        private void timerIntro_Tick(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SIntro20seg);
            audio.Play();
        }

        private void timerMid_Tick(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SMidOutro16seg);
            audio.Play();
            timerReMid.Enabled = true;
            timerMid.Enabled = false;
        }

        private void timerReMid_Tick(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.SMidOutro16seg);
            audio.Play();
        }

        private void ProgressBarTiempo_Click(object sender, EventArgs e)
        {
            if (faseJuego == 0 || faseJuego == 2)
            {
                return;
            }
            ProgressBarTiempo.Value = 10;
        }

        private void cbModoJuego_Click(object sender, EventArgs e)
        {
        }
    }
}
