﻿namespace TP.Aula04.Exercicios
{
    partial class FrmMenu
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.BackColor = System.Drawing.Color.Moccasin;
            this.btnExercicio1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio1.Location = new System.Drawing.Point(75, 160);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(146, 120);
            this.btnExercicio1.TabIndex = 0;
            this.btnExercicio1.Text = "Exercicio 1\r\nArrayList";
            this.btnExercicio1.UseVisualStyleBackColor = false;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExercicio2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio2.Location = new System.Drawing.Point(221, 160);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(145, 120);
            this.btnExercicio2.TabIndex = 1;
            this.btnExercicio2.Text = "Exercicio 2\r\nPositivos e \r\nNegativos";
            this.btnExercicio2.UseVisualStyleBackColor = false;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExercicio3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio3.Location = new System.Drawing.Point(75, 280);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(146, 123);
            this.btnExercicio3.TabIndex = 2;
            this.btnExercicio3.Text = "Exercicio 3 \r\nDiferença\r\nMin e Max";
            this.btnExercicio3.UseVisualStyleBackColor = false;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.BackColor = System.Drawing.Color.Moccasin;
            this.btnExercicio4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio4.Location = new System.Drawing.Point(221, 280);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(145, 123);
            this.btnExercicio4.TabIndex = 3;
            this.btnExercicio4.Text = "Exercicio 4\r\nPróximo\r\nao Zero";
            this.btnExercicio4.UseVisualStyleBackColor = false;
            this.btnExercicio4.Click += new System.EventHandler(this.btnExercicio4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(92, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o exercício";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExercicio1;
        private Button btnExercicio2;
        private Button btnExercicio3;
        private Button btnExercicio4;
        private Label label1;
    }
}