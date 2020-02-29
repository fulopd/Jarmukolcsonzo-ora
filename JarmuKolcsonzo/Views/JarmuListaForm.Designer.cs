namespace JarmuKolcsonzo.Views
{
    partial class JarmuListaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarmuListaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ferohelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogyasztasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elerhetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.szervizbenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.szervizDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muszakiDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszerzesDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmukategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mentestoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.KeresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rendszamDataGridViewTextBoxColumn,
            this.kategoriaIdDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.modellDataGridViewTextBoxColumn,
            this.ferohelyDataGridViewTextBoxColumn,
            this.fogyasztasDataGridViewTextBoxColumn,
            this.elerhetoDataGridViewTextBoxColumn,
            this.szervizbenDataGridViewTextBoxColumn,
            this.szervizDatumDataGridViewTextBoxColumn,
            this.muszakiDatumDataGridViewTextBoxColumn,
            this.beszerzesDatumDataGridViewTextBoxColumn,
            this.jarmukategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jarmuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 334);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // rendszamDataGridViewTextBoxColumn
            // 
            this.rendszamDataGridViewTextBoxColumn.DataPropertyName = "rendszam";
            this.rendszamDataGridViewTextBoxColumn.HeaderText = "rendszam";
            this.rendszamDataGridViewTextBoxColumn.Name = "rendszamDataGridViewTextBoxColumn";
            // 
            // kategoriaIdDataGridViewTextBoxColumn
            // 
            this.kategoriaIdDataGridViewTextBoxColumn.DataPropertyName = "kategoriaId";
            this.kategoriaIdDataGridViewTextBoxColumn.HeaderText = "kategoriaId";
            this.kategoriaIdDataGridViewTextBoxColumn.Name = "kategoriaIdDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "tipus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            // 
            // modellDataGridViewTextBoxColumn
            // 
            this.modellDataGridViewTextBoxColumn.DataPropertyName = "modell";
            this.modellDataGridViewTextBoxColumn.HeaderText = "modell";
            this.modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            // 
            // ferohelyDataGridViewTextBoxColumn
            // 
            this.ferohelyDataGridViewTextBoxColumn.DataPropertyName = "ferohely";
            this.ferohelyDataGridViewTextBoxColumn.HeaderText = "ferohely";
            this.ferohelyDataGridViewTextBoxColumn.Name = "ferohelyDataGridViewTextBoxColumn";
            // 
            // fogyasztasDataGridViewTextBoxColumn
            // 
            this.fogyasztasDataGridViewTextBoxColumn.DataPropertyName = "fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.HeaderText = "fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.Name = "fogyasztasDataGridViewTextBoxColumn";
            // 
            // elerhetoDataGridViewTextBoxColumn
            // 
            this.elerhetoDataGridViewTextBoxColumn.DataPropertyName = "elerheto";
            this.elerhetoDataGridViewTextBoxColumn.HeaderText = "elerheto";
            this.elerhetoDataGridViewTextBoxColumn.Name = "elerhetoDataGridViewTextBoxColumn";
            this.elerhetoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elerhetoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // szervizbenDataGridViewTextBoxColumn
            // 
            this.szervizbenDataGridViewTextBoxColumn.DataPropertyName = "szervizben";
            this.szervizbenDataGridViewTextBoxColumn.HeaderText = "szervizben";
            this.szervizbenDataGridViewTextBoxColumn.Name = "szervizbenDataGridViewTextBoxColumn";
            this.szervizbenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.szervizbenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // szervizDatumDataGridViewTextBoxColumn
            // 
            this.szervizDatumDataGridViewTextBoxColumn.DataPropertyName = "szervizDatum";
            this.szervizDatumDataGridViewTextBoxColumn.HeaderText = "szervizDatum";
            this.szervizDatumDataGridViewTextBoxColumn.Name = "szervizDatumDataGridViewTextBoxColumn";
            // 
            // muszakiDatumDataGridViewTextBoxColumn
            // 
            this.muszakiDatumDataGridViewTextBoxColumn.DataPropertyName = "muszakiDatum";
            this.muszakiDatumDataGridViewTextBoxColumn.HeaderText = "muszakiDatum";
            this.muszakiDatumDataGridViewTextBoxColumn.Name = "muszakiDatumDataGridViewTextBoxColumn";
            // 
            // beszerzesDatumDataGridViewTextBoxColumn
            // 
            this.beszerzesDatumDataGridViewTextBoxColumn.DataPropertyName = "beszerzesDatum";
            this.beszerzesDatumDataGridViewTextBoxColumn.HeaderText = "beszerzesDatum";
            this.beszerzesDatumDataGridViewTextBoxColumn.Name = "beszerzesDatumDataGridViewTextBoxColumn";
            // 
            // jarmukategoriaDataGridViewTextBoxColumn
            // 
            this.jarmukategoriaDataGridViewTextBoxColumn.DataPropertyName = "jarmukategoria";
            this.jarmukategoriaDataGridViewTextBoxColumn.HeaderText = "jarmukategoria";
            this.jarmukategoriaDataGridViewTextBoxColumn.Name = "jarmukategoriaDataGridViewTextBoxColumn";
            this.jarmukategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // jarmuBindingSource
            // 
            this.jarmuBindingSource.DataSource = typeof(JarmuKolcsonzo.Models.jarmu);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PageLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(128, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(127, 7);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(2);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(82, 33);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(15, 7);
            this.FirstButton.Margin = new System.Windows.Forms.Padding(2);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(82, 33);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(463, 7);
            this.LastButton.Margin = new System.Windows.Forms.Padding(2);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(82, 33);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(351, 7);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 33);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(264, 14);
            this.PageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(31, 20);
            this.PageLabel.TabIndex = 4;
            this.PageLabel.Text = "0/0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentestoolStripButton1,
            this.toolStripSeparator1,
            this.KeresestoolStripTextBox,
            this.KeresestoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mentestoolStripButton1
            // 
            this.mentestoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentestoolStripButton1.Name = "mentestoolStripButton1";
            this.mentestoolStripButton1.Size = new System.Drawing.Size(74, 29);
            this.mentestoolStripButton1.Text = "Mentés";
            this.mentestoolStripButton1.Click += new System.EventHandler(this.mentestoolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // KeresestoolStripTextBox
            // 
            this.KeresestoolStripTextBox.Name = "KeresestoolStripTextBox";
            this.KeresestoolStripTextBox.Size = new System.Drawing.Size(164, 32);
            // 
            // KeresestoolStripButton
            // 
            this.KeresestoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("KeresestoolStripButton.Image")));
            this.KeresestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KeresestoolStripButton.Name = "KeresestoolStripButton";
            this.KeresestoolStripButton.Size = new System.Drawing.Size(99, 29);
            this.KeresestoolStripButton.Text = "Keresés";
            this.KeresestoolStripButton.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
            // 
            // JarmuListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JarmuListaForm";
            this.Text = "JarmuLista";
            this.Load += new System.EventHandler(this.JarmuListaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jarmuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ferohelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fogyasztasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elerhetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn szervizbenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szervizDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muszakiDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszerzesDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarmukategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mentestoolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox KeresestoolStripTextBox;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton;
    }
}