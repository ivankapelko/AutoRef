namespace AutoRef
{
    partial class TokenControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._paragraphText = new System.Windows.Forms.RichTextBox();
            this._tokenValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _paragraphText
            // 
            this._paragraphText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._paragraphText.Location = new System.Drawing.Point(4, 4);
            this._paragraphText.Name = "_paragraphText";
            this._paragraphText.Size = new System.Drawing.Size(605, 159);
            this._paragraphText.TabIndex = 0;
            this._paragraphText.Text = "";
            // 
            // _tokenValue
            // 
            this._tokenValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tokenValue.AutoSize = true;
            this._tokenValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._tokenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tokenValue.Location = new System.Drawing.Point(641, 67);
            this._tokenValue.Name = "_tokenValue";
            this._tokenValue.Size = new System.Drawing.Size(127, 28);
            this._tokenValue.TabIndex = 1;
            this._tokenValue.Text = "Вес токена";
            // 
            // TokenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this._tokenValue);
            this.Controls.Add(this._paragraphText);
            this.Name = "TokenControl";
            this.Size = new System.Drawing.Size(786, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox _paragraphText;
        private System.Windows.Forms.Label _tokenValue;
    }
}
