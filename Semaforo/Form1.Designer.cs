namespace Semaforo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CarrostextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semaforo.Properties.Resources.apagado2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(166, 41);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Location = new System.Drawing.Point(166, 106);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(75, 23);
            this.buttonParar.TabIndex = 2;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(166, 174);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Location = new System.Drawing.Point(362, 111);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(0, 13);
            this.EstadoLabel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carros en espera de luz ";
            // 
            // CarrostextBox
            // 
            this.CarrostextBox.Location = new System.Drawing.Point(365, 71);
            this.CarrostextBox.Name = "CarrostextBox";
            this.CarrostextBox.ReadOnly = true;
            this.CarrostextBox.Size = new System.Drawing.Size(100, 20);
            this.CarrostextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 245);
            this.Controls.Add(this.CarrostextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstadoLabel);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarrostextBox;
    }
}

