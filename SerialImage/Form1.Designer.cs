namespace SerialImage
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.destImage = new System.Windows.Forms.PictureBox();
            this.loadImg = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.comPortsSelect = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.baudrateSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // srcImage
            // 
            this.srcImage.Location = new System.Drawing.Point(12, 12);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(492, 459);
            this.srcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.srcImage.TabIndex = 0;
            this.srcImage.TabStop = false;
            // 
            // destImage
            // 
            this.destImage.Location = new System.Drawing.Point(519, 12);
            this.destImage.Name = "destImage";
            this.destImage.Size = new System.Drawing.Size(492, 459);
            this.destImage.TabIndex = 1;
            this.destImage.TabStop = false;
            // 
            // loadImg
            // 
            this.loadImg.Location = new System.Drawing.Point(429, 477);
            this.loadImg.Name = "loadImg";
            this.loadImg.Size = new System.Drawing.Size(75, 23);
            this.loadImg.TabIndex = 2;
            this.loadImg.Text = "Загрузить";
            this.loadImg.UseVisualStyleBackColor = true;
            this.loadImg.Click += new System.EventHandler(this.loadImg_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(936, 477);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // comPortsSelect
            // 
            this.comPortsSelect.FormattingEnabled = true;
            this.comPortsSelect.Location = new System.Drawing.Point(519, 479);
            this.comPortsSelect.Name = "comPortsSelect";
            this.comPortsSelect.Size = new System.Drawing.Size(121, 21);
            this.comPortsSelect.TabIndex = 4;
            this.comPortsSelect.Text = "COM";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 477);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(157, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 70;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // baudrateSelect
            // 
            this.baudrateSelect.FormattingEnabled = true;
            this.baudrateSelect.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "5600",
            "57600",
            "115200",
            "128000",
            "256000",
            "",
            ""});
            this.baudrateSelect.Location = new System.Drawing.Point(646, 479);
            this.baudrateSelect.Name = "baudrateSelect";
            this.baudrateSelect.Size = new System.Drawing.Size(121, 21);
            this.baudrateSelect.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 508);
            this.Controls.Add(this.baudrateSelect);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comPortsSelect);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.loadImg);
            this.Controls.Add(this.destImage);
            this.Controls.Add(this.srcImage);
            this.Name = "Form1";
            this.Text = "Передача изображения";
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox srcImage;
        private System.Windows.Forms.PictureBox destImage;
        private System.Windows.Forms.Button loadImg;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ComboBox comPortsSelect;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox baudrateSelect;
    }
}

