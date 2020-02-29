namespace JarmuKolcsonzo.Views
{
    partial class JarmuKategoriaForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKategoriaNevText = new System.Windows.Forms.TextBox();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.buttonHozzadas = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategórianév:";
            // 
            // textBoxKategoriaNevText
            // 
            this.textBoxKategoriaNevText.Location = new System.Drawing.Point(24, 39);
            this.textBoxKategoriaNevText.Name = "textBoxKategoriaNevText";
            this.textBoxKategoriaNevText.Size = new System.Drawing.Size(287, 20);
            this.textBoxKategoriaNevText.TabIndex = 1;
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegsem.Location = new System.Drawing.Point(236, 65);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsem.TabIndex = 2;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            // 
            // buttonHozzadas
            // 
            this.buttonHozzadas.Location = new System.Drawing.Point(24, 65);
            this.buttonHozzadas.Name = "buttonHozzadas";
            this.buttonHozzadas.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzadas.TabIndex = 2;
            this.buttonHozzadas.Text = "OK";
            this.buttonHozzadas.UseVisualStyleBackColor = true;
            this.buttonHozzadas.Click += new System.EventHandler(this.buttonHozzadas_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // JarmuKategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 107);
            this.Controls.Add(this.buttonHozzadas);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxKategoriaNevText);
            this.Controls.Add(this.label1);
            this.Name = "JarmuKategoriaForm";
            this.Text = "JarmuKategoriaForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKategoriaNevText;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.Button buttonHozzadas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}