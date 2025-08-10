namespace Ejercicios_Formularios
{
    partial class Ejer1
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
            label1 = new Label();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(605, 352);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 166);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 1;
            label1.Text = "...";
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(318, 223);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(102, 43);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludo";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Ejer1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(btnSaludar);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "Ejer1";
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Button btnSaludar;
    }
}