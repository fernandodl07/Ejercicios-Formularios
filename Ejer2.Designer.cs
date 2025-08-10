namespace Ejercicios_Formularios
{
    partial class Ejer2
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
            txtTempera = new TextBox();
            cbxTemp = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(605, 352);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 144);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione tipo de temperatura";
            // 
            // txtTempera
            // 
            txtTempera.Location = new Point(288, 189);
            txtTempera.Name = "txtTempera";
            txtTempera.Size = new Size(121, 23);
            txtTempera.TabIndex = 3;
            // 
            // cbxTemp
            // 
            cbxTemp.FormattingEnabled = true;
            cbxTemp.Items.AddRange(new object[] { "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
            cbxTemp.Location = new Point(288, 145);
            cbxTemp.Name = "cbxTemp";
            cbxTemp.Size = new Size(121, 23);
            cbxTemp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 188);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese cantidad a convertir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 309);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad Convertida";
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(288, 306);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(121, 23);
            txtValor.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(305, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ejer2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(button1);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxTemp);
            Controls.Add(txtTempera);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "Ejer2";
            Text = "Ejer2";
            Load += Ejer2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private TextBox txtTempera;
        private ComboBox cbxTemp;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private Button button1;
    }
}