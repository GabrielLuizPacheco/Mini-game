namespace Joquempô
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPedra = new System.Windows.Forms.Button();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonTesoura = new System.Windows.Forms.Button();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelIA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVencedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelpPlayer = new System.Windows.Forms.Label();
            this.labelpIa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPedra
            // 
            this.buttonPedra.BackColor = System.Drawing.Color.Black;
            this.buttonPedra.Font = new System.Drawing.Font("Android 101", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedra.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPedra.Location = new System.Drawing.Point(375, 168);
            this.buttonPedra.Name = "buttonPedra";
            this.buttonPedra.Size = new System.Drawing.Size(75, 23);
            this.buttonPedra.TabIndex = 0;
            this.buttonPedra.Text = "Pedra";
            this.buttonPedra.UseVisualStyleBackColor = false;
            this.buttonPedra.Click += new System.EventHandler(this.buttonPedra_Click);
            // 
            // buttonPapel
            // 
            this.buttonPapel.BackColor = System.Drawing.Color.Black;
            this.buttonPapel.Font = new System.Drawing.Font("Android 101", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPapel.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPapel.Location = new System.Drawing.Point(375, 220);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(75, 23);
            this.buttonPapel.TabIndex = 1;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = false;
            this.buttonPapel.Click += new System.EventHandler(this.buttonPapel_Click);
            // 
            // buttonTesoura
            // 
            this.buttonTesoura.BackColor = System.Drawing.Color.Black;
            this.buttonTesoura.Font = new System.Drawing.Font("Android 101", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTesoura.ForeColor = System.Drawing.Color.Yellow;
            this.buttonTesoura.Location = new System.Drawing.Point(375, 269);
            this.buttonTesoura.Name = "buttonTesoura";
            this.buttonTesoura.Size = new System.Drawing.Size(75, 23);
            this.buttonTesoura.TabIndex = 2;
            this.buttonTesoura.Text = "Tesoura";
            this.buttonTesoura.UseVisualStyleBackColor = false;
            this.buttonTesoura.Click += new System.EventHandler(this.buttonTesoura_Click);
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer.Location = new System.Drawing.Point(153, 173);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(23, 19);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Text = "0";
            // 
            // labelIA
            // 
            this.labelIA.AutoSize = true;
            this.labelIA.BackColor = System.Drawing.Color.Transparent;
            this.labelIA.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIA.ForeColor = System.Drawing.Color.Red;
            this.labelIA.Location = new System.Drawing.Point(655, 173);
            this.labelIA.Name = "labelIA";
            this.labelIA.Size = new System.Drawing.Size(23, 19);
            this.labelIA.TabIndex = 4;
            this.labelIA.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(153, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(655, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "IA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(244, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vencedor:";
            // 
            // labelVencedor
            // 
            this.labelVencedor.AutoSize = true;
            this.labelVencedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVencedor.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencedor.ForeColor = System.Drawing.Color.Red;
            this.labelVencedor.Location = new System.Drawing.Point(390, 50);
            this.labelVencedor.Name = "labelVencedor";
            this.labelVencedor.Size = new System.Drawing.Size(47, 19);
            this.labelVencedor.TabIndex = 8;
            this.labelVencedor.Text = "win";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pontos Player:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(525, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pontos IA:";
            // 
            // labelpPlayer
            // 
            this.labelpPlayer.AutoSize = true;
            this.labelpPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelpPlayer.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelpPlayer.Location = new System.Drawing.Point(205, 340);
            this.labelpPlayer.Name = "labelpPlayer";
            this.labelpPlayer.Size = new System.Drawing.Size(23, 19);
            this.labelpPlayer.TabIndex = 11;
            this.labelpPlayer.Text = "0";
            // 
            // labelpIa
            // 
            this.labelpIa.AutoSize = true;
            this.labelpIa.BackColor = System.Drawing.Color.Transparent;
            this.labelpIa.Font = new System.Drawing.Font("Android 101", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpIa.ForeColor = System.Drawing.Color.Red;
            this.labelpIa.Location = new System.Drawing.Point(658, 340);
            this.labelpIa.Name = "labelpIa";
            this.labelpIa.Size = new System.Drawing.Size(23, 19);
            this.labelpIa.TabIndex = 12;
            this.labelpIa.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Joquempô.Properties.Resources.cpk1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelpIa);
            this.Controls.Add(this.labelpPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVencedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIA);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.buttonTesoura);
            this.Controls.Add(this.buttonPapel);
            this.Controls.Add(this.buttonPedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPedra;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonTesoura;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVencedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelpPlayer;
        private System.Windows.Forms.Label labelpIa;
    }
}

