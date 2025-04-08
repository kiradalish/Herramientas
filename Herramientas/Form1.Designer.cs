namespace TriviaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonResponder;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.ProgressBar progressBarTiempo;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label labelTiempo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonResponder = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.progressBarTiempo = new System.Windows.Forms.ProgressBar();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Location = new System.Drawing.Point(30, 20);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCategoria.TabIndex = 0;
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.Location = new System.Drawing.Point(200, 20);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(150, 21);
            this.comboBoxNivel.TabIndex = 1;
            // 
            // labelPregunta
            // 
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelPregunta.Location = new System.Drawing.Point(30, 60);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(500, 40);
            this.labelPregunta.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(50, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(400, 20);
            this.radioButton1.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(50, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(400, 20);
            this.radioButton2.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(50, 180);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(400, 20);
            this.radioButton3.TabIndex = 5;
            // 
            // radioButton4
            // 
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton4.Location = new System.Drawing.Point(50, 210);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(400, 20);
            this.radioButton4.TabIndex = 6;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(370, 18);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(100, 25);
            this.buttonIniciar.TabIndex = 7;
            this.buttonIniciar.Text = "Iniciar";
            // 
            // buttonResponder
            // 
            this.buttonResponder.Location = new System.Drawing.Point(50, 250);
            this.buttonResponder.Name = "buttonResponder";
            this.buttonResponder.Size = new System.Drawing.Size(100, 30);
            this.buttonResponder.TabIndex = 8;
            this.buttonResponder.Text = "Responder";
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(170, 250);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(100, 30);
            this.buttonReiniciar.TabIndex = 9;
            this.buttonReiniciar.Text = "Reiniciar";
            // 
            // progressBarTiempo
            // 
            this.progressBarTiempo.Location = new System.Drawing.Point(30, 300);
            this.progressBarTiempo.Name = "progressBarTiempo";
            this.progressBarTiempo.Size = new System.Drawing.Size(400, 20);
            this.progressBarTiempo.TabIndex = 10;
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.Location = new System.Drawing.Point(30, 340);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(200, 20);
            this.labelPuntaje.TabIndex = 11;
            // 
            // labelTiempo
            // 
            this.labelTiempo.Location = new System.Drawing.Point(250, 340);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(200, 20);
            this.labelTiempo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Herramientas.Properties.Resources.millo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.buttonResponder);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.progressBarTiempo);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelTiempo);
            this.Name = "Form1";
            this.Text = "Trivia Pro";
          
            this.ResumeLayout(false);

        }
    }
}