namespace Opdracht5
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertCF = new System.Windows.Forms.Button();
            this.btnConvertFC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(139, 98);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(54, 20);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(464, 98);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(77, 20);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(139, 144);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(125, 27);
            this.txtCelsius.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(464, 144);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(125, 27);
            this.txtFahrenheit.TabIndex = 3;
            // 
            // btnConvertCF
            // 
            this.btnConvertCF.Location = new System.Drawing.Point(139, 207);
            this.btnConvertCF.Name = "btnConvertCF";
            this.btnConvertCF.Size = new System.Drawing.Size(73, 29);
            this.btnConvertCF.TabIndex = 4;
            this.btnConvertCF.Text = "°C to F";
            this.btnConvertCF.UseVisualStyleBackColor = true;
            this.btnConvertCF.Click += new System.EventHandler(this.btnConvertCF_Click);
            // 
            // btnConvertFC
            // 
            this.btnConvertFC.Location = new System.Drawing.Point(464, 207);
            this.btnConvertFC.Name = "btnConvertFC";
            this.btnConvertFC.Size = new System.Drawing.Size(73, 29);
            this.btnConvertFC.TabIndex = 5;
            this.btnConvertFC.Text = "F to °C";
            this.btnConvertFC.UseVisualStyleBackColor = true;
            this.btnConvertFC.Click += new System.EventHandler(this.btnConvertFC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertFC);
            this.Controls.Add(this.btnConvertCF);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCelsius;
        private Label lblFahrenheit;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Button btnConvertCF;
        private Button btnConvertFC;
    }
}