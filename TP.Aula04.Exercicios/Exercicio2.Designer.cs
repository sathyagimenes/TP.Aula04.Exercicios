namespace TP.Aula04.Exercicios
{
    partial class Exercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio2));
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.gpbListaInteiros = new System.Windows.Forms.GroupBox();
            this.lblListaInteiros = new System.Windows.Forms.Label();
            this.btnCriarLista = new System.Windows.Forms.Button();
            this.txbLista = new System.Windows.Forms.TextBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblSomaNegativos = new System.Windows.Forms.Label();
            this.gpbSomaNegativos = new System.Windows.Forms.GroupBox();
            this.gpbContagemPositivos = new System.Windows.Forms.GroupBox();
            this.lblContagemPositivos = new System.Windows.Forms.Label();
            this.lblCriarLista = new System.Windows.Forms.Label();
            this.gpbListaInteiros.SuspendLayout();
            this.gpbSomaNegativos.SuspendLayout();
            this.gpbContagemPositivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(655, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 22;
            this.button1.Text = "Voltar\r\npara o\r\nMenu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(96, 297);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 21;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(40, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(663, 110);
            this.lblEnunciado.TabIndex = 20;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            this.lblEnunciado.Click += new System.EventHandler(this.lblEnunciado_Click);
            // 
            // gpbListaInteiros
            // 
            this.gpbListaInteiros.Controls.Add(this.lblListaInteiros);
            this.gpbListaInteiros.Location = new System.Drawing.Point(86, 216);
            this.gpbListaInteiros.Name = "gpbListaInteiros";
            this.gpbListaInteiros.Size = new System.Drawing.Size(505, 68);
            this.gpbListaInteiros.TabIndex = 18;
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
            this.btnCriarLista.Location = new System.Drawing.Point(434, 135);
            this.btnCriarLista.Name = "btnCriarLista";
            this.btnCriarLista.Size = new System.Drawing.Size(117, 56);
            this.btnCriarLista.TabIndex = 16;
            this.btnCriarLista.Text = "Criar nova Lista";
            this.btnCriarLista.UseVisualStyleBackColor = true;
            this.btnCriarLista.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txbLista
            // 
            this.txbLista.Location = new System.Drawing.Point(204, 148);
            this.txbLista.Name = "txbLista";
            this.txbLista.Size = new System.Drawing.Size(205, 23);
            this.txbLista.TabIndex = 13;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(369, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(124, 45);
            this.lblLista.TabIndex = 12;
            this.lblLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // lblSomaNegativos
            // 
            this.lblSomaNegativos.AutoSize = true;
            this.lblSomaNegativos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSomaNegativos.Location = new System.Drawing.Point(6, 31);
            this.lblSomaNegativos.Name = "lblSomaNegativos";
            this.lblSomaNegativos.Size = new System.Drawing.Size(0, 18);
            this.lblSomaNegativos.TabIndex = 6;
            // 
            // gpbSomaNegativos
            // 
            this.gpbSomaNegativos.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbSomaNegativos.Controls.Add(this.lblSomaNegativos);
            this.gpbSomaNegativos.Location = new System.Drawing.Point(369, 358);
            this.gpbSomaNegativos.Name = "gpbSomaNegativos";
            this.gpbSomaNegativos.Size = new System.Drawing.Size(222, 68);
            this.gpbSomaNegativos.TabIndex = 19;
            this.gpbSomaNegativos.TabStop = false;
            this.gpbSomaNegativos.Text = "Soma de números negativos";
            // 
            // gpbContagemPositivos
            // 
            this.gpbContagemPositivos.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbContagemPositivos.Controls.Add(this.lblContagemPositivos);
            this.gpbContagemPositivos.Location = new System.Drawing.Point(86, 358);
            this.gpbContagemPositivos.Name = "gpbContagemPositivos";
            this.gpbContagemPositivos.Size = new System.Drawing.Size(222, 68);
            this.gpbContagemPositivos.TabIndex = 20;
            this.gpbContagemPositivos.TabStop = false;
            this.gpbContagemPositivos.Text = "Contagem de números positivos";
            // 
            // lblContagemPositivos
            // 
            this.lblContagemPositivos.AutoSize = true;
            this.lblContagemPositivos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContagemPositivos.Location = new System.Drawing.Point(6, 31);
            this.lblContagemPositivos.Name = "lblContagemPositivos";
            this.lblContagemPositivos.Size = new System.Drawing.Size(0, 18);
            this.lblContagemPositivos.TabIndex = 6;
            // 
            // lblCriarLista
            // 
            this.lblCriarLista.AutoSize = true;
            this.lblCriarLista.Location = new System.Drawing.Point(63, 146);
            this.lblCriarLista.Name = "lblCriarLista";
            this.lblCriarLista.Size = new System.Drawing.Size(124, 45);
            this.lblCriarLista.TabIndex = 23;
            this.lblCriarLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 451);
            this.Controls.Add(this.lblCriarLista);
            this.Controls.Add(this.gpbContagemPositivos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.gpbSomaNegativos);
            this.Controls.Add(this.gpbListaInteiros);
            this.Controls.Add(this.btnCriarLista);
            this.Controls.Add(this.txbLista);
            this.Controls.Add(this.lblLista);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.gpbListaInteiros.ResumeLayout(false);
            this.gpbListaInteiros.PerformLayout();
            this.gpbSomaNegativos.ResumeLayout(false);
            this.gpbSomaNegativos.PerformLayout();
            this.gpbContagemPositivos.ResumeLayout(false);
            this.gpbContagemPositivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label lblError;
        private Label lblEnunciado;
        private GroupBox gpbListaInteiros;
        private Label lblListaInteiros;
        private Button btnCriarLista;
        private TextBox txbLista;
        private Label lblLista;
        private Label lblSomaNegativos;
        private GroupBox gpbSomaNegativos;
        private GroupBox gpbContagemPositivos;
        private Label lblContagemPositivos;
        private Label lblCriarLista;
    }
}