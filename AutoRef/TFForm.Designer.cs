namespace AutoRef
{
    partial class TFForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._wordShowButton = new System.Windows.Forms.Button();
            this._paragraphShowButton = new System.Windows.Forms.Button();
            this._sentenceShowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoubleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._showReferat = new System.Windows.Forms.Button();
            this._percentcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._percentcomboBox);
            this.groupBox1.Controls.Add(this._showReferat);
            this.groupBox1.Controls.Add(this._wordShowButton);
            this.groupBox1.Controls.Add(this._paragraphShowButton);
            this.groupBox1.Controls.Add(this._sentenceShowButton);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отабразить";
            // 
            // _wordShowButton
            // 
            this._wordShowButton.Location = new System.Drawing.Point(180, 13);
            this._wordShowButton.Name = "_wordShowButton";
            this._wordShowButton.Size = new System.Drawing.Size(75, 23);
            this._wordShowButton.TabIndex = 4;
            this._wordShowButton.Text = "Слова";
            this._wordShowButton.UseVisualStyleBackColor = true;
            this._wordShowButton.Click += new System.EventHandler(this._wordShowButton_Click);
            // 
            // _paragraphShowButton
            // 
            this._paragraphShowButton.Location = new System.Drawing.Point(6, 13);
            this._paragraphShowButton.Name = "_paragraphShowButton";
            this._paragraphShowButton.Size = new System.Drawing.Size(75, 23);
            this._paragraphShowButton.TabIndex = 3;
            this._paragraphShowButton.Text = "Параграфы";
            this._paragraphShowButton.UseVisualStyleBackColor = true;
            this._paragraphShowButton.Click += new System.EventHandler(this._paragraphShowButton_Click);
            // 
            // _sentenceShowButton
            // 
            this._sentenceShowButton.Location = new System.Drawing.Point(87, 13);
            this._sentenceShowButton.Name = "_sentenceShowButton";
            this._sentenceShowButton.Size = new System.Drawing.Size(87, 23);
            this._sentenceShowButton.TabIndex = 5;
            this._sentenceShowButton.Text = "Предложения";
            this._sentenceShowButton.UseVisualStyleBackColor = true;
            this._sentenceShowButton.Click += new System.EventHandler(this._sentenceShowButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextValue,
            this.DoubleValue});
            this.dataGridView1.Location = new System.Drawing.Point(8, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 319);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TextValue
            // 
            this.TextValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextValue.HeaderText = "Текстовое значение";
            this.TextValue.Name = "TextValue";
            // 
            // DoubleValue
            // 
            this.DoubleValue.HeaderText = "Вес";
            this.DoubleValue.Name = "DoubleValue";
            // 
            // _showReferat
            // 
            this._showReferat.Location = new System.Drawing.Point(262, 13);
            this._showReferat.Name = "_showReferat";
            this._showReferat.Size = new System.Drawing.Size(120, 23);
            this._showReferat.TabIndex = 6;
            this._showReferat.Text = "Показать реферат";
            this._showReferat.UseVisualStyleBackColor = true;
            this._showReferat.Click += new System.EventHandler(this._showReferat_Click);
            // 
            // _percentcomboBox
            // 
            this._percentcomboBox.FormattingEnabled = true;
            this._percentcomboBox.Items.AddRange(new object[] {
            "15",
            "30",
            "50"});
            this._percentcomboBox.Location = new System.Drawing.Point(389, 14);
            this._percentcomboBox.Name = "_percentcomboBox";
            this._percentcomboBox.Size = new System.Drawing.Size(65, 21);
            this._percentcomboBox.TabIndex = 8;
            // 
            // TFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TFForm";
            this.Text = "TFForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _wordShowButton;
        private System.Windows.Forms.Button _paragraphShowButton;
        private System.Windows.Forms.Button _sentenceShowButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoubleValue;
        private System.Windows.Forms.ComboBox _percentcomboBox;
        private System.Windows.Forms.Button _showReferat;
    }
}