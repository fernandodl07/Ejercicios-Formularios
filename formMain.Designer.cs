namespace Ejercicios_Formularios
{
    partial class formMain
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
            label1 = new Label();
            btnEje1 = new Button();
            btnEje2 = new Button();
            btnEje3 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 34);
            label1.Name = "label1";
            label1.Size = new Size(237, 21);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a los ejercicios 09-08";
            // 
            // btnEje1
            // 
            btnEje1.Location = new Point(275, 115);
            btnEje1.Name = "btnEje1";
            btnEje1.Size = new Size(153, 47);
            btnEje1.TabIndex = 1;
            btnEje1.Text = "Ingresar al ejercicio 1";
            btnEje1.UseVisualStyleBackColor = true;
            btnEje1.Click += btnEje1_Click;
            // 
            // btnEje2
            // 
            btnEje2.Location = new Point(275, 194);
            btnEje2.Name = "btnEje2";
            btnEje2.Size = new Size(153, 47);
            btnEje2.TabIndex = 2;
            btnEje2.Text = "Ingresar al ejercicio 2";
            btnEje2.UseVisualStyleBackColor = true;
            btnEje2.Click += btnEje2_Click;
            // 
            // btnEje3
            // 
            btnEje3.Location = new Point(275, 279);
            btnEje3.Name = "btnEje3";
            btnEje3.Size = new Size(153, 47);
            btnEje3.TabIndex = 3;
            btnEje3.Text = "Ingresar al ejercicio 3";
            btnEje3.UseVisualStyleBackColor = true;
            btnEje3.Click += btnEje3_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(605, 352);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 43);
            btnExit.TabIndex = 4;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(btnExit);
            Controls.Add(btnEje3);
            Controls.Add(btnEje2);
            Controls.Add(btnEje1);
            Controls.Add(label1);
            Name = "formMain";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEje1;
        private Button btnEje2;
        private Button btnEje3;
        private Button btnExit;
    }
}
