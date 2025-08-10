namespace Ejercicios_Formularios
{
    partial class Ejer3
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
            btnBack = new Button();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(605, 352);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(237, 145);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(149, 23);
            txtNumber1.TabIndex = 3;
            txtNumber1.Text = "Ingrese numero 1";
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(237, 207);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(149, 23);
            txtNumber2.TabIndex = 4;
            txtNumber2.Text = "Ingrese numero 2";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(99, 252);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(118, 54);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(237, 252);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(118, 54);
            btnResta.TabIndex = 6;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(373, 252);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(118, 54);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "Multiplicacion";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(506, 252);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(118, 54);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(237, 374);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(149, 23);
            txtResultado.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 153);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 10;
            label1.Text = "Ingrese numero 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 207);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 11;
            label2.Text = "Ingrese numero 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 377);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Resultado";
            // 
            // Ejer3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(btnBack);
            Name = "Ejer3";
            Text = "Ejer3";
            Load += Ejer3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDivision;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}