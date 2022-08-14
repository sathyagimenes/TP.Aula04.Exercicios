namespace TP.Aula04.Exercicios
{
    partial class Exercicio1
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
            this.lblNovaLista = new System.Windows.Forms.Label();
            this.txbNovaLista = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.txbProcurar = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblArrayList = new System.Windows.Forms.Label();
            this.gpbArrayList = new System.Windows.Forms.GroupBox();
            this.gpbIndex = new System.Windows.Forms.GroupBox();
            this.lblListaIndex = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbArrayList.SuspendLayout();
            this.gpbIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNovaLista
            // 
            this.lblNovaLista.AutoSize = true;
            this.lblNovaLista.Location = new System.Drawing.Point(62, 141);
            this.lblNovaLista.Name = "lblNovaLista";
            this.lblNovaLista.Size = new System.Drawing.Size(124, 45);
            this.lblNovaLista.TabIndex = 0;
            this.lblNovaLista.Text = "Nova Lista\r\n(somente números\r\nseparados por vírgula)";
            // 
            // txbNovaLista
            // 
            this.txbNovaLista.Location = new System.Drawing.Point(180, 141);
            this.txbNovaLista.Name = "txbNovaLista";
            this.txbNovaLista.Size = new System.Drawing.Size(205, 23);
            this.txbNovaLista.TabIndex = 1;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Location = new System.Drawing.Point(68, 352);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(149, 15);
            this.lblProcurar.TabIndex = 2;
            this.lblProcurar.Text = "Procurar index do número:";
            // 
            // txbProcurar
            // 
            this.txbProcurar.Location = new System.Drawing.Point(241, 344);
            this.txbProcurar.Name = "txbProcurar";
            this.txbProcurar.Size = new System.Drawing.Size(135, 23);
            this.txbProcurar.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(410, 128);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(117, 56);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar nova ArrayList";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(410, 331);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(117, 56);
            this.btnProcurar.TabIndex = 5;
            this.btnProcurar.Text = "Procurar elemento";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblArrayList
            // 
            this.lblArrayList.AutoSize = true;
            this.lblArrayList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrayList.Location = new System.Drawing.Point(6, 31);
            this.lblArrayList.Name = "lblArrayList";
            this.lblArrayList.Size = new System.Drawing.Size(0, 18);
            this.lblArrayList.TabIndex = 6;
            // 
            // gpbArrayList
            // 
            this.gpbArrayList.Controls.Add(this.lblArrayList);
            this.gpbArrayList.Location = new System.Drawing.Point(62, 209);
            this.gpbArrayList.Name = "gpbArrayList";
            this.gpbArrayList.Size = new System.Drawing.Size(505, 68);
            this.gpbArrayList.TabIndex = 7;
            this.gpbArrayList.TabStop = false;
            this.gpbArrayList.Text = "ArrayList";
            // 
            // gpbIndex
            // 
            this.gpbIndex.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbIndex.Controls.Add(this.lblListaIndex);
            this.gpbIndex.Location = new System.Drawing.Point(62, 417);
            this.gpbIndex.Name = "gpbIndex";
            this.gpbIndex.Size = new System.Drawing.Size(505, 68);
            this.gpbIndex.TabIndex = 8;
            this.gpbIndex.TabStop = false;
            this.gpbIndex.Text = "Index do elemento";
            // 
            // lblListaIndex
            // 
            this.lblListaIndex.AutoSize = true;
            this.lblListaIndex.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaIndex.Location = new System.Drawing.Point(6, 31);
            this.lblListaIndex.Name = "lblListaIndex";
            this.lblListaIndex.Size = new System.Drawing.Size(0, 18);
            this.lblListaIndex.TabIndex = 6;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(22, 29);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(621, 44);
            this.lblEnunciado.TabIndex = 9;
            this.lblEnunciado.Text = "Crie uma função que receba uma ArrayList e um número. Ela deve\r\nmostrar todos os " +
    "índices onde esse número aparece na ArrayList.";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(72, 290);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(586, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar\r\npara o\r\nMenu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.gpbIndex);
            this.Controls.Add(this.gpbArrayList);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txbProcurar);
            this.Controls.Add(this.lblProcurar);
            this.Controls.Add(this.txbNovaLista);
            this.Controls.Add(this.lblNovaLista);
            this.Name = "Exercicio1";
            this.Text = "Exercicio1";
            this.Load += new System.EventHandler(this.Exercicio1_Load);
            this.gpbArrayList.ResumeLayout(false);
            this.gpbArrayList.PerformLayout();
            this.gpbIndex.ResumeLayout(false);
            this.gpbIndex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNovaLista;
        private TextBox txbNovaLista;
        private Label lblProcurar;
        private TextBox txbProcurar;
        private Button btnCriar;
        private Button btnProcurar;
        private Label lblArrayList;
        private GroupBox gpbArrayList;
        private GroupBox gpbIndex;
        private Label lblListaIndex;
        private Label lblEnunciado;
        private Label lblError;
        private Button button1;
    }
}