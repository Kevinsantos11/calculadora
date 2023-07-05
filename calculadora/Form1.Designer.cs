namespace calculadora
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
            resultado = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(201, 48);
            somar.Name = "somar";
            somar.Size = new Size(76, 34);
            somar.TabIndex = 0;
            somar.Text = "somar";
            somar.UseVisualStyleBackColor = true;
            // 
            // SegundoNumero
            // 
            SegundoNumero.Location = new Point(297, 54);
            SegundoNumero.Name = "SegundoNumero";
            SegundoNumero.Size = new Size(150, 31);
            SegundoNumero.TabIndex = 1;
            // 
            // PrimeiroNumero
            // 
            PrimeiroNumero.Location = new Point(12, 48);
            PrimeiroNumero.Name = "PrimeiroNumero";
            PrimeiroNumero.Size = new Size(174, 31);
            PrimeiroNumero.TabIndex = 2;
            PrimeiroNumero.TextChanged += PrimeiroNumero_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 51);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 3;
            label1.Text = "primeiro numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 54);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 4;
            label2.Text = "segundo numero";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(482, 60);
            resultado.Name = "resultado";
            resultado.Size = new Size(22, 25);
            resultado.TabIndex = 5;
            resultado.Text = "0";
            resultado.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(resultado);
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
        private Label resultado;
    }
}