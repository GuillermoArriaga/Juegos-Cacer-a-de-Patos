namespace CaceriaPatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbTiros = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbAciertos = new System.Windows.Forms.ToolStripTextBox();
            this.tbAciertosPorcentaje = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.ProgressBarTiempo = new System.Windows.Forms.ToolStripProgressBar();
            this.timerPato = new System.Windows.Forms.Timer(this.components);
            this.timerDisparo = new System.Windows.Forms.Timer(this.components);
            this.timerPerro = new System.Windows.Forms.Timer(this.components);
            this.timerHit = new System.Windows.Forms.Timer(this.components);
            this.timerPatoHerido = new System.Windows.Forms.Timer(this.components);
            this.timerPerroHerido = new System.Windows.Forms.Timer(this.components);
            this.lAciertos = new System.Windows.Forms.Label();
            this.lFallos = new System.Windows.Forms.Label();
            this.lBalasPerro = new System.Windows.Forms.Label();
            this.lBonusTiempo = new System.Windows.Forms.Label();
            this.cbModoJuego = new System.Windows.Forms.ToolStripComboBox();
            this.timerBonus = new System.Windows.Forms.Timer(this.components);
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.lCaceria = new System.Windows.Forms.Label();
            this.lDePatos = new System.Windows.Forms.Label();
            this.lAutor = new System.Windows.Forms.Label();
            this.pbReloj = new System.Windows.Forms.PictureBox();
            this.pbPatoHerido = new System.Windows.Forms.PictureBox();
            this.pbPerroHerido = new System.Windows.Forms.PictureBox();
            this.pbPerroAcierto = new System.Windows.Forms.PictureBox();
            this.pbPerroFallo = new System.Windows.Forms.PictureBox();
            this.pbPerro = new System.Windows.Forms.PictureBox();
            this.pbPato = new System.Windows.Forms.PictureBox();
            this.pbDisparo = new System.Windows.Forms.PictureBox();
            this.bNuevo = new System.Windows.Forms.ToolStripButton();
            this.bSalir = new System.Windows.Forms.ToolStripButton();
            this.bMasVelocidad = new System.Windows.Forms.ToolStripButton();
            this.bMenosVelocidad = new System.Windows.Forms.ToolStripButton();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.timerIntro = new System.Windows.Forms.Timer(this.components);
            this.timerMid = new System.Windows.Forms.Timer(this.components);
            this.timerReMid = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatoHerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroHerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroAcierto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroFallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisparo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNuevo,
            this.bSalir,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.bMasVelocidad,
            this.bMenosVelocidad,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tbTiros,
            this.toolStripLabel3,
            this.tbAciertos,
            this.tbAciertosPorcentaje,
            this.toolStripSeparator3,
            this.toolStripLabel5,
            this.ProgressBarTiempo,
            this.cbModoJuego});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 51);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 48);
            this.toolStripLabel1.Text = "Velocidad";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 48);
            this.toolStripLabel2.Text = "Tiros";
            // 
            // tbTiros
            // 
            this.tbTiros.Name = "tbTiros";
            this.tbTiros.ReadOnly = true;
            this.tbTiros.Size = new System.Drawing.Size(50, 51);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(63, 48);
            this.toolStripLabel3.Text = "Aciertos";
            // 
            // tbAciertos
            // 
            this.tbAciertos.Name = "tbAciertos";
            this.tbAciertos.ReadOnly = true;
            this.tbAciertos.Size = new System.Drawing.Size(50, 51);
            // 
            // tbAciertosPorcentaje
            // 
            this.tbAciertosPorcentaje.Name = "tbAciertosPorcentaje";
            this.tbAciertosPorcentaje.ReadOnly = true;
            this.tbAciertosPorcentaje.Size = new System.Drawing.Size(50, 51);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(60, 48);
            this.toolStripLabel5.Text = "Tiempo";
            // 
            // ProgressBarTiempo
            // 
            this.ProgressBarTiempo.Name = "ProgressBarTiempo";
            this.ProgressBarTiempo.Size = new System.Drawing.Size(100, 48);
            this.ProgressBarTiempo.Click += new System.EventHandler(this.ProgressBarTiempo_Click);
            // 
            // timerPato
            // 
            this.timerPato.Interval = 1200;
            this.timerPato.Tick += new System.EventHandler(this.timerPato_Tick);
            // 
            // timerDisparo
            // 
            this.timerDisparo.Interval = 1400;
            this.timerDisparo.Tick += new System.EventHandler(this.timerDisparo_Tick);
            // 
            // timerPerro
            // 
            this.timerPerro.Interval = 600;
            this.timerPerro.Tick += new System.EventHandler(this.timerPerro_Tick);
            // 
            // timerHit
            // 
            this.timerHit.Interval = 400;
            this.timerHit.Tick += new System.EventHandler(this.timerHit_Tick);
            // 
            // timerPatoHerido
            // 
            this.timerPatoHerido.Interval = 500;
            this.timerPatoHerido.Tick += new System.EventHandler(this.timerPatoHerido_Tick);
            // 
            // timerPerroHerido
            // 
            this.timerPerroHerido.Interval = 500;
            this.timerPerroHerido.Tick += new System.EventHandler(this.timerPerroHerido_Tick);
            // 
            // lAciertos
            // 
            this.lAciertos.AutoSize = true;
            this.lAciertos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lAciertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lAciertos.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAciertos.ForeColor = System.Drawing.Color.Yellow;
            this.lAciertos.Location = new System.Drawing.Point(148, 80);
            this.lAciertos.Name = "lAciertos";
            this.lAciertos.Size = new System.Drawing.Size(347, 38);
            this.lAciertos.TabIndex = 9;
            this.lAciertos.Text = "Aciertos:  10   70%";
            this.lAciertos.Visible = false;
            // 
            // lFallos
            // 
            this.lFallos.AutoSize = true;
            this.lFallos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lFallos.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFallos.ForeColor = System.Drawing.Color.Crimson;
            this.lFallos.Location = new System.Drawing.Point(148, 138);
            this.lFallos.Name = "lFallos";
            this.lFallos.Size = new System.Drawing.Size(186, 38);
            this.lFallos.TabIndex = 10;
            this.lFallos.Text = "Fallos:  4";
            this.lFallos.Visible = false;
            // 
            // lBalasPerro
            // 
            this.lBalasPerro.AutoSize = true;
            this.lBalasPerro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lBalasPerro.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBalasPerro.Location = new System.Drawing.Point(148, 198);
            this.lBalasPerro.Name = "lBalasPerro";
            this.lBalasPerro.Size = new System.Drawing.Size(341, 38);
            this.lBalasPerro.TabIndex = 11;
            this.lBalasPerro.Text = "Balas al perro:  4";
            this.lBalasPerro.Visible = false;
            // 
            // lBonusTiempo
            // 
            this.lBonusTiempo.AutoSize = true;
            this.lBonusTiempo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lBonusTiempo.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBonusTiempo.Location = new System.Drawing.Point(148, 261);
            this.lBonusTiempo.Name = "lBonusTiempo";
            this.lBonusTiempo.Size = new System.Drawing.Size(366, 38);
            this.lBonusTiempo.TabIndex = 12;
            this.lBonusTiempo.Text = "Bonus de tiempo: 3";
            this.lBonusTiempo.Visible = false;
            // 
            // cbModoJuego
            // 
            this.cbModoJuego.DropDownWidth = 300;
            this.cbModoJuego.Items.AddRange(new object[] {
            "Posicion aleatoria Discontinua",
            "Posicion aleatoria Continua"});
            this.cbModoJuego.Name = "cbModoJuego";
            this.cbModoJuego.Size = new System.Drawing.Size(130, 51);
            this.cbModoJuego.Text = "Modo de Juego";
            this.cbModoJuego.Visible = false;
            this.cbModoJuego.Click += new System.EventHandler(this.cbModoJuego_Click);
            // 
            // timerBonus
            // 
            this.timerBonus.Interval = 10000;
            this.timerBonus.Tick += new System.EventHandler(this.timerBonus_Tick);
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // lCaceria
            // 
            this.lCaceria.AutoSize = true;
            this.lCaceria.BackColor = System.Drawing.Color.Transparent;
            this.lCaceria.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCaceria.Location = new System.Drawing.Point(22, 136);
            this.lCaceria.Name = "lCaceria";
            this.lCaceria.Size = new System.Drawing.Size(56, 315);
            this.lCaceria.TabIndex = 14;
            this.lCaceria.Text = "C\r\nA\r\nC\r\nE\r\nR\r\nI\r\nA";
            // 
            // lDePatos
            // 
            this.lDePatos.AutoSize = true;
            this.lDePatos.BackColor = System.Drawing.Color.Transparent;
            this.lDePatos.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDePatos.Location = new System.Drawing.Point(755, 121);
            this.lDePatos.Name = "lDePatos";
            this.lDePatos.Size = new System.Drawing.Size(51, 360);
            this.lDePatos.TabIndex = 15;
            this.lDePatos.Text = "D\r\nE\r\n\r\nP\r\nA\r\nT\r\nO\r\nS";
            // 
            // lAutor
            // 
            this.lAutor.AutoSize = true;
            this.lAutor.BackColor = System.Drawing.Color.Transparent;
            this.lAutor.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAutor.Location = new System.Drawing.Point(29, 633);
            this.lAutor.Name = "lAutor";
            this.lAutor.Size = new System.Drawing.Size(785, 38);
            this.lAutor.TabIndex = 16;
            this.lAutor.Text = "          por Guillermo Arriaga García          ";
            // 
            // pbReloj
            // 
            this.pbReloj.BackColor = System.Drawing.Color.Transparent;
            this.pbReloj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReloj.Image = global::CaceriaPatos.Properties.Resources.Reloj;
            this.pbReloj.Location = new System.Drawing.Point(606, 415);
            this.pbReloj.Name = "pbReloj";
            this.pbReloj.Size = new System.Drawing.Size(85, 72);
            this.pbReloj.TabIndex = 13;
            this.pbReloj.TabStop = false;
            this.pbReloj.Visible = false;
            this.pbReloj.Click += new System.EventHandler(this.pbReloj_Click);
            // 
            // pbPatoHerido
            // 
            this.pbPatoHerido.BackColor = System.Drawing.Color.Transparent;
            this.pbPatoHerido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPatoHerido.Image = global::CaceriaPatos.Properties.Resources.PatoHerido;
            this.pbPatoHerido.Location = new System.Drawing.Point(653, 198);
            this.pbPatoHerido.Name = "pbPatoHerido";
            this.pbPatoHerido.Size = new System.Drawing.Size(85, 72);
            this.pbPatoHerido.TabIndex = 8;
            this.pbPatoHerido.TabStop = false;
            this.pbPatoHerido.Visible = false;
            // 
            // pbPerroHerido
            // 
            this.pbPerroHerido.BackColor = System.Drawing.Color.Transparent;
            this.pbPerroHerido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerroHerido.Image = global::CaceriaPatos.Properties.Resources.PerroHerido;
            this.pbPerroHerido.Location = new System.Drawing.Point(501, 415);
            this.pbPerroHerido.Name = "pbPerroHerido";
            this.pbPerroHerido.Size = new System.Drawing.Size(99, 136);
            this.pbPerroHerido.TabIndex = 7;
            this.pbPerroHerido.TabStop = false;
            this.pbPerroHerido.Visible = false;
            // 
            // pbPerroAcierto
            // 
            this.pbPerroAcierto.BackColor = System.Drawing.Color.Transparent;
            this.pbPerroAcierto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerroAcierto.Image = global::CaceriaPatos.Properties.Resources.PerroAcierto;
            this.pbPerroAcierto.Location = new System.Drawing.Point(620, 276);
            this.pbPerroAcierto.Name = "pbPerroAcierto";
            this.pbPerroAcierto.Size = new System.Drawing.Size(118, 111);
            this.pbPerroAcierto.TabIndex = 6;
            this.pbPerroAcierto.TabStop = false;
            this.pbPerroAcierto.Visible = false;
            // 
            // pbPerroFallo
            // 
            this.pbPerroFallo.BackColor = System.Drawing.Color.Transparent;
            this.pbPerroFallo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerroFallo.Image = global::CaceriaPatos.Properties.Resources.PerroFallo;
            this.pbPerroFallo.Location = new System.Drawing.Point(501, 276);
            this.pbPerroFallo.Name = "pbPerroFallo";
            this.pbPerroFallo.Size = new System.Drawing.Size(113, 111);
            this.pbPerroFallo.TabIndex = 5;
            this.pbPerroFallo.TabStop = false;
            this.pbPerroFallo.Visible = false;
            // 
            // pbPerro
            // 
            this.pbPerro.BackColor = System.Drawing.Color.Transparent;
            this.pbPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerro.Image = global::CaceriaPatos.Properties.Resources.PerroDerecha;
            this.pbPerro.Location = new System.Drawing.Point(501, 67);
            this.pbPerro.Name = "pbPerro";
            this.pbPerro.Size = new System.Drawing.Size(179, 143);
            this.pbPerro.TabIndex = 4;
            this.pbPerro.TabStop = false;
            this.pbPerro.Visible = false;
            this.pbPerro.Click += new System.EventHandler(this.pbPerro_Click);
            // 
            // pbPato
            // 
            this.pbPato.BackColor = System.Drawing.Color.Transparent;
            this.pbPato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPato.Image = global::CaceriaPatos.Properties.Resources.PatoDerecha;
            this.pbPato.Location = new System.Drawing.Point(620, 67);
            this.pbPato.Name = "pbPato";
            this.pbPato.Size = new System.Drawing.Size(118, 101);
            this.pbPato.TabIndex = 3;
            this.pbPato.TabStop = false;
            this.pbPato.Visible = false;
            this.pbPato.Click += new System.EventHandler(this.pbPato_Click);
            // 
            // pbDisparo
            // 
            this.pbDisparo.BackColor = System.Drawing.Color.Transparent;
            this.pbDisparo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDisparo.Image = global::CaceriaPatos.Properties.Resources.Disparo;
            this.pbDisparo.Location = new System.Drawing.Point(663, 415);
            this.pbDisparo.Name = "pbDisparo";
            this.pbDisparo.Size = new System.Drawing.Size(75, 101);
            this.pbDisparo.TabIndex = 2;
            this.pbDisparo.TabStop = false;
            this.pbDisparo.Visible = false;
            // 
            // bNuevo
            // 
            this.bNuevo.AutoSize = false;
            this.bNuevo.BackgroundImage = global::CaceriaPatos.Properties.Resources.New;
            this.bNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(48, 48);
            this.bNuevo.ToolTipText = "Nuevo Juego";
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bSalir
            // 
            this.bSalir.AutoSize = false;
            this.bSalir.BackgroundImage = global::CaceriaPatos.Properties.Resources.Salir;
            this.bSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(40, 40);
            this.bSalir.ToolTipText = "Salir del Juego";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bMasVelocidad
            // 
            this.bMasVelocidad.AutoSize = false;
            this.bMasVelocidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMasVelocidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bMasVelocidad.Image = global::CaceriaPatos.Properties.Resources.Mas;
            this.bMasVelocidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bMasVelocidad.Name = "bMasVelocidad";
            this.bMasVelocidad.Size = new System.Drawing.Size(24, 24);
            this.bMasVelocidad.ToolTipText = "Aumentar Velocidad";
            this.bMasVelocidad.Click += new System.EventHandler(this.bMasVelocidad_Click);
            // 
            // bMenosVelocidad
            // 
            this.bMenosVelocidad.AutoSize = false;
            this.bMenosVelocidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMenosVelocidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bMenosVelocidad.Image = global::CaceriaPatos.Properties.Resources.Menos;
            this.bMenosVelocidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bMenosVelocidad.Name = "bMenosVelocidad";
            this.bMenosVelocidad.Size = new System.Drawing.Size(24, 24);
            this.bMenosVelocidad.ToolTipText = "Disminuir Velocidad";
            this.bMenosVelocidad.Click += new System.EventHandler(this.bMenosVelocidad_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFondo.Image = global::CaceriaPatos.Properties.Resources.Presentacion;
            this.pbFondo.Location = new System.Drawing.Point(3, 51);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(827, 620);
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.pbFondo_Click);
            // 
            // timerIntro
            // 
            this.timerIntro.Interval = 20000;
            this.timerIntro.Tick += new System.EventHandler(this.timerIntro_Tick);
            // 
            // timerMid
            // 
            this.timerMid.Interval = 1500;
            this.timerMid.Tick += new System.EventHandler(this.timerMid_Tick);
            // 
            // timerReMid
            // 
            this.timerReMid.Interval = 16000;
            this.timerReMid.Tick += new System.EventHandler(this.timerReMid_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.ControlBox = false;
            this.Controls.Add(this.lAutor);
            this.Controls.Add(this.lDePatos);
            this.Controls.Add(this.lCaceria);
            this.Controls.Add(this.pbReloj);
            this.Controls.Add(this.lBonusTiempo);
            this.Controls.Add(this.lBalasPerro);
            this.Controls.Add(this.lFallos);
            this.Controls.Add(this.lAciertos);
            this.Controls.Add(this.pbPatoHerido);
            this.Controls.Add(this.pbPerroHerido);
            this.Controls.Add(this.pbPerroAcierto);
            this.Controls.Add(this.pbPerroFallo);
            this.Controls.Add(this.pbPerro);
            this.Controls.Add(this.pbPato);
            this.Controls.Add(this.pbDisparo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatoHerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroHerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroAcierto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerroFallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisparo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pbDisparo;
        private System.Windows.Forms.PictureBox pbPato;
        private System.Windows.Forms.Timer timerPato;
        private System.Windows.Forms.Timer timerDisparo;
        private System.Windows.Forms.Timer timerPerro;
        private System.Windows.Forms.PictureBox pbPerro;
        private System.Windows.Forms.PictureBox pbPerroFallo;
        private System.Windows.Forms.PictureBox pbPerroAcierto;
        private System.Windows.Forms.ToolStripButton bNuevo;
        private System.Windows.Forms.ToolStripButton bSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton bMasVelocidad;
        private System.Windows.Forms.ToolStripButton bMenosVelocidad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbTiros;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tbAciertos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarTiempo;
        private System.Windows.Forms.ToolStripTextBox tbAciertosPorcentaje;
        private System.Windows.Forms.PictureBox pbPerroHerido;
        private System.Windows.Forms.PictureBox pbPatoHerido;
        private System.Windows.Forms.Timer timerHit;
        private System.Windows.Forms.Timer timerPatoHerido;
        private System.Windows.Forms.Timer timerPerroHerido;
        private System.Windows.Forms.Label lAciertos;
        private System.Windows.Forms.Label lFallos;
        private System.Windows.Forms.Label lBalasPerro;
        private System.Windows.Forms.Label lBonusTiempo;
        private System.Windows.Forms.ToolStripComboBox cbModoJuego;
        private System.Windows.Forms.PictureBox pbReloj;
        private System.Windows.Forms.Timer timerBonus;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lCaceria;
        private System.Windows.Forms.Label lDePatos;
        private System.Windows.Forms.Label lAutor;
        private System.Windows.Forms.Timer timerIntro;
        private System.Windows.Forms.Timer timerMid;
        private System.Windows.Forms.Timer timerReMid;
    }
}

