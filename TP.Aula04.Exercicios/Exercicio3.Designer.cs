namespace TP.Aula04.Exercicios
{
    partial class Exercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio3));
            this.gpbDiferenca = new System.Windows.Forms.GroupBox();
            this.lblDiferenca = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.gpbListaInteiros = new System.Windows.Forms.GroupBox();
            this.lblListaInteiros = new System.Windows.Forms.Label();
            this.btnCriarLista = new System.Windows.Forms.Button();
            this.txbLista = new System.Windows.Forms.TextBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblCriarLista = new System.Windows.Forms.Label();
            this.gpbDiferenca.SuspendLayout();
            this.gpbListaInteiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDiferenca
            // 
            this.gpbDiferenca.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbDiferenca.Controls.Add(this.lblDiferenca);
            this.gpbDiferenca.Location = new System.Drawing.Point(547, 163);
            this.gpbDiferenca.Name = "gpbDiferenca";
            this.gpbDiferenca.Size = new System.Drawing.Size(167, 142);
            this.gpbDiferenca.TabIndex = 28;
            this.gpbDiferenca.TabStop = false;
            this.gpbDiferenca.Text = "Diferença entre min e max";
            this.gpbDiferenca.Enter += new System.EventHandler(this.gpbContagemPositivos_Enter);
            // 
            // lblDiferenca
            // 
            this.lblDiferenca.AutoSize = true;
            this.lblDiferenca.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiferenca.Location = new System.Drawing.Point(17, 52);
            this.lblDiferenca.Name = "lblDiferenca";
            this.lblDiferenca.Size = new System.Drawing.Size(0, 37);
            this.lblDiferenca.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(657, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 31;
            this.button1.Text = "Voltar\r\npara o\r\nMenu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(52, 299);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 30;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(38, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(694, 132);
            this.lblEnunciado.TabIndex = 29;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            // 
            // gpbListaInteiros
            // 
            this.gpbListaInteiros.Controls.Add(this.lblListaInteiros);
            this.gpbListaInteiros.Location = new System.Drawing.Point(42, 237);
            this.gpbListaInteiros.Name = "gpbListaInteiros";
            this.gpbListaInteiros.Size = new System.Drawing.Size(477, 68);
            this.gpbListaInteiros.TabIndex = 26;
            this.gpbListaInteiros.TabStop = false;
            this.gpbListaInteiros.Text = "Lista";
            // 
            // lblListaInteiros
            // 
            this.lblListaInteiros.AutoSize = true;
            this.lblListaInteiros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaInteiros.Location = new System.Drawing.Point(6, 31);
            this.lblListaInteiros.Name = "lblListaInteiros";
            this.lblListaInteiros.Size = new System.Drawing.Size(0, 18);
            this.lblListaInteiros.TabIndex = 6;
            // 
            // btnCriarLista
            // 
            this.btnCriarLista.Location = new System.Drawing.Point(402, 163);
            this.btnCriarLista.Name = "btnCriarLista";
            this.btnCriarLista.Size = new System.Drawing.Size(117, 56);
            this.btnCriarLista.TabIndex = 25;
            this.btnCriarLista.Text = "Criar nova Lista";
            this.btnCriarLista.UseVisualStyleBackColor = true;
            this.btnCriarLista.Click += new System.EventHandler(this.btnCriarLista_Click);
            // 
            // txbLista
            // 
            this.txbLista.Location = new System.Drawing.Point(172, 176);
            this.txbLista.Name = "txbLista";
            this.txbLista.Size = new System.Drawing.Size(205, 23);
            this.txbLista.TabIndex = 24;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(371, 31);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(124, 45);
            this.lblLista.TabIndex = 23;
            this.lblLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // lblCriarLista
            // 
            this.lblCriarLista.AutoSize = true;
            this.lblCriarLista.Location = new System.Drawing.Point(42, 174);
            this.lblCriarLista.Name = "lblCriarLista";
            this.lblCriarLista.Size = new System.Drawing.Size(124, 45);
            this.lblCriarLista.TabIndex = 32;
            this.lblCriarLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 393);
            this.Controls.Add(this.lblCriarLista);
            this.Controls.Add(this.gpbDiferenca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.gpbListaInteiros);
            this.Controls.Add(this.btnCriarLista);
            this.Controls.Add(this.txbLista);
            this.Controls.Add(this.lblLista);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.gpbDiferenca.ResumeLayout(false);
            this.gpbDiferenca.PerformLayout();
            this.gpbListaInteiros.ResumeLayout(false);
            this.gpbListaInteiros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpbDiferenca;
        private Label lblDiferenca;
        private Button button1;
        private Label lblError;
        private Label lblEnunciado;
        private GroupBox gpbListaInteiros;
        private Label lblListaInteiros;
        private Button btnCriarLista;
        private TextBox txbLista;
        private Label lblLista;
        private Label lblCriarLista;
    }
}