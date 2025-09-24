namespace tutorial__2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardFace_pictureBox = new System.Windows.Forms.PictureBox();
            this.cardBack_pictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFace_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFace_pictureBox
            // 
            this.cardFace_pictureBox.Image = global::tutorial__2_5.Properties.Resources.Ace_Spades;
            this.cardFace_pictureBox.Location = new System.Drawing.Point(409, 73);
            this.cardFace_pictureBox.Name = "cardFace_pictureBox";
            this.cardFace_pictureBox.Size = new System.Drawing.Size(160, 237);
            this.cardFace_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFace_pictureBox.TabIndex = 1;
            this.cardFace_pictureBox.TabStop = false;
            // 
            // cardBack_pictureBox
            // 
            this.cardBack_pictureBox.Image = global::tutorial__2_5.Properties.Resources.Backface_Blue;
            this.cardBack_pictureBox.Location = new System.Drawing.Point(135, 73);
            this.cardBack_pictureBox.Name = "cardBack_pictureBox";
            this.cardBack_pictureBox.Size = new System.Drawing.Size(160, 237);
            this.cardBack_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBack_pictureBox.TabIndex = 0;
            this.cardBack_pictureBox.TabStop = false;
            this.cardBack_pictureBox.Visible = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(168, 349);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(105, 59);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(436, 349);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(105, 59);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardFace_pictureBox);
            this.Controls.Add(this.cardBack_pictureBox);
            this.Name = "Form1";
            this.Text = "翻轉樸克牌";
            ((System.ComponentModel.ISupportInitialize)(this.cardFace_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBack_pictureBox;
        private System.Windows.Forms.PictureBox cardFace_pictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

