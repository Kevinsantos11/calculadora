﻿namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            somar = new Button();
            SegundoNumero = new TextBox();
            PrimeiroNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            resultadoText = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(253, 225);
            somar.Name = "somar";
            somar.Size = new Size(76, 34);
            somar.TabIndex = 0;
            somar.Text = "somar";
            somar.UseVisualStyleBackColor = true;
            somar.Click += somar_Click;
            // 
            // SegundoNumero
            // 
            SegundoNumero.Location = new Point(253, 163);
            SegundoNumero.Name = "SegundoNumero";
            SegundoNumero.Size = new Size(142, 31);
            SegundoNumero.TabIndex = 1;
            // 
            // PrimeiroNumero
            // 
            PrimeiroNumero.Location = new Point(253, 91);
            PrimeiroNumero.Name = "PrimeiroNumero";
            PrimeiroNumero.Size = new Size(142, 31);
            PrimeiroNumero.TabIndex = 2;
            PrimeiroNumero.TextChanged += PrimeiroNumero_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 97);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 3;
            label1.Text = "primeiro numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 169);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 4;
            label2.Text = "segundo numero";
            label2.Click += label2_Click;
            // 
            // resultadoText
            // 
            resultadoText.AutoSize = true;
            resultadoText.Location = new Point(433, 131);
            resultadoText.Name = "resultadoText";
            resultadoText.Size = new Size(22, 25);
            resultadoText.TabIndex = 5;
            resultadoText.Text = "0";
            resultadoText.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(resultadoText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PrimeiroNumero);
            Controls.Add(SegundoNumero);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button somar;
        private TextBox SegundoNumero;
        private TextBox PrimeiroNumero;
        private Label label1;
        private Label label2;
        private Label resultadoText;
    }
}