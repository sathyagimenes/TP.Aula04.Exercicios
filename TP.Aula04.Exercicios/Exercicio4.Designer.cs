namespace TP.Aula04.Exercicios
{
    partial class Exercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio4));
            this.lblCriarLista = new System.Windows.Forms.Label();
            this.gpbProxZero = new System.Windows.Forms.GroupBox();
            this.lblProxZero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.gpbListaInteiros = new System.Windows.Forms.GroupBox();
            this.lblListaInteiros = new System.Windows.Forms.Label();
            this.btnCriarLista = new System.Windows.Forms.Button();
            this.txbLista = new System.Windows.Forms.TextBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.gpbProxZero.SuspendLayout();
            this.gpbListaInteiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCriarLista
            // 
            this.lblCriarLista.AutoSize = true;
            this.lblCriarLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCriarLista.Location = new System.Drawing.Point(36, 201);
            this.lblCriarLista.Name = "lblCriarLista";
            this.lblCriarLista.Size = new System.Drawing.Size(142, 51);
            this.lblCriarLista.TabIndex = 41;
            this.lblCriarLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // gpbProxZero
            // 
            this.gpbProxZero.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbProxZero.Controls.Add(this.lblProxZero);
            this.gpbProxZero.Location = new System.Drawing.Point(562, 201);
            this.gpbProxZero.Name = "gpbProxZero";
            this.gpbProxZero.Size = new System.Drawing.Size(167, 142);
            this.gpbProxZero.TabIndex = 37;
            this.gpbProxZero.TabStop = false;
            this.gpbProxZero.Text = "Valor mais próximo de zero";
            // 
            // lblProxZero
            // 
            this.lblProxZero.AutoSize = true;
            this.lblProxZero.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProxZero.Location = new System.Drawing.Point(17, 52);
            this.lblProxZero.Name = "lblProxZero";
            this.lblProxZero.Size = new System.Drawing.Size(0, 37);
            this.lblProxZero.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(672, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 40;
            this.button1.Text = "Voltar\r\npara o\r\nMenu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(67, 356);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 39;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(36, 35);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(693, 110);
            this.lblEnunciado.TabIndex = 38;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            // 
            // gpbListaInteiros
            // 
            this.gpbListaInteiros.Controls.Add(this.lblListaInteiros);
            this.gpbListaInteiros.Location = new System.Drawing.Point(57, 275);
            this.gpbListaInteiros.Name = "gpbListaInteiros";
            this.gpbListaInteiros.Size = new System.Drawing.Size(477, 68);
            this.gpbListaInteiros.TabIndex = 36;
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
            this.btnCriarLista.Location = new System.Drawing.Point(417, 201);
            this.btnCriarLista.Name = "btnCriarLista";
            this.btnCriarLista.Size = new System.Drawing.Size(117, 56);
            this.btnCriarLista.TabIndex = 35;
            this.btnCriarLista.Text = "Criar nova Lista";
            this.btnCriarLista.UseVisualStyleBackColor = true;
            this.btnCriarLista.Click += new System.EventHandler(this.btnCriarLista_Click);
            // 
            // txbLista
            // 
            this.txbLista.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLista.Location = new System.Drawing.Point(195, 215);
            this.txbLista.Name = "txbLista";
            this.txbLista.Size = new System.Drawing.Size(205, 27);
            this.txbLista.TabIndex = 34;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(386, 66);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(124, 45);
            this.lblLista.TabIndex = 33;
            this.lblLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.lblCriarLista);
            this.Controls.Add(this.gpbProxZero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.gpbListaInteiros);
            this.Controls.Add(this.btnCriarLista);
            this.Controls.Add(this.txbLista);
            this.Controls.Add(this.lblLista);
            this.Name = "Exercicio4";
            this.Text = "Exercicio4";
            this.Load += new System.EventHandler(this.Exercicio4_Load);
            this.gpbProxZero.ResumeLayout(false);
            this.gpbProxZero.PerformLayout();
            this.gpbListaInteiros.ResumeLayout(false);
            this.gpbListaInteiros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCriarLista;
        private GroupBox gpbProxZero;
        private Label lblProxZero;
        private Button button1;
        private Label lblError;
        private Label lblEnunciado;
        private GroupBox gpbListaInteiros;
        private Label lblListaInteiros;
        private Button btnCriarLista;
        private TextBox txbLista;
        private Label lblLista;
    }
}