
namespace ImagePixelMover
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadImage = new System.Windows.Forms.Button();
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.ImagePathLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.numericUpDown_movePixel_X = new System.Windows.Forms.NumericUpDown();
            this.movePixelLabel_X = new System.Windows.Forms.Label();
            this.movePixellabe_Y = new System.Windows.Forms.Label();
            this.numericUpDown_movePixel_Y = new System.Windows.Forms.NumericUpDown();
            this.movePixelButton = new System.Windows.Forms.Button();
            this.savePathButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imagePathListView = new System.Windows.Forms.ListView();
            this.previewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_movePixel_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_movePixel_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImage
            // 
            this.LoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadImage.Location = new System.Drawing.Point(542, 416);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(187, 63);
            this.LoadImage.TabIndex = 0;
            this.LoadImage.Text = "이미지 불러오기";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.OnLoadImageClicked);
            // 
            // savePathBox
            // 
            this.savePathBox.Location = new System.Drawing.Point(121, 45);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.Size = new System.Drawing.Size(707, 21);
            this.savePathBox.TabIndex = 1;
            // 
            // ImagePathLabel
            // 
            this.ImagePathLabel.AutoSize = true;
            this.ImagePathLabel.Location = new System.Drawing.Point(40, 48);
            this.ImagePathLabel.Name = "ImagePathLabel";
            this.ImagePathLabel.Size = new System.Drawing.Size(59, 15);
            this.ImagePathLabel.TabIndex = 2;
            this.ImagePathLabel.Text = "저장 경로";
            this.ImagePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImagePictureBox.BackColor = System.Drawing.Color.White;
            this.ImagePictureBox.Location = new System.Drawing.Point(436, 166);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 3;
            this.ImagePictureBox.TabStop = false;
            // 
            // numericUpDown_movePixel_X
            // 
            this.numericUpDown_movePixel_X.Location = new System.Drawing.Point(389, 416);
            this.numericUpDown_movePixel_X.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_movePixel_X.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_movePixel_X.Name = "numericUpDown_movePixel_X";
            this.numericUpDown_movePixel_X.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_movePixel_X.TabIndex = 9;
            // 
            // movePixelLabel_X
            // 
            this.movePixelLabel_X.AutoSize = true;
            this.movePixelLabel_X.Location = new System.Drawing.Point(303, 418);
            this.movePixelLabel_X.Name = "movePixelLabel_X";
            this.movePixelLabel_X.Size = new System.Drawing.Size(80, 15);
            this.movePixelLabel_X.TabIndex = 10;
            this.movePixelLabel_X.Text = "움직일 픽셀X";
            // 
            // movePixellabe_Y
            // 
            this.movePixellabe_Y.AutoSize = true;
            this.movePixellabe_Y.Location = new System.Drawing.Point(303, 469);
            this.movePixellabe_Y.Name = "movePixellabe_Y";
            this.movePixellabe_Y.Size = new System.Drawing.Size(79, 15);
            this.movePixellabe_Y.TabIndex = 12;
            this.movePixellabe_Y.Text = "움직일 픽셀Y";
            // 
            // numericUpDown_movePixel_Y
            // 
            this.numericUpDown_movePixel_Y.Location = new System.Drawing.Point(389, 467);
            this.numericUpDown_movePixel_Y.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_movePixel_Y.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_movePixel_Y.Name = "numericUpDown_movePixel_Y";
            this.numericUpDown_movePixel_Y.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_movePixel_Y.TabIndex = 11;
            // 
            // movePixelButton
            // 
            this.movePixelButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.movePixelButton.Location = new System.Drawing.Point(745, 416);
            this.movePixelButton.Name = "movePixelButton";
            this.movePixelButton.Size = new System.Drawing.Size(188, 66);
            this.movePixelButton.TabIndex = 13;
            this.movePixelButton.Text = "픽셀 이동";
            this.movePixelButton.UseVisualStyleBackColor = true;
            this.movePixelButton.Click += new System.EventHandler(this.OnMovePixelButtonClicked);
            // 
            // savePathButton
            // 
            this.savePathButton.Location = new System.Drawing.Point(848, 33);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(98, 44);
            this.savePathButton.TabIndex = 14;
            this.savePathButton.Text = "저장 경로 선택";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.SavePathButtonClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imagePathListView
            // 
            this.imagePathListView.HideSelection = false;
            this.imagePathListView.LargeImageList = this.imageList1;
            this.imagePathListView.Location = new System.Drawing.Point(12, 110);
            this.imagePathListView.Name = "imagePathListView";
            this.imagePathListView.Size = new System.Drawing.Size(285, 393);
            this.imagePathListView.SmallImageList = this.imageList1;
            this.imagePathListView.TabIndex = 15;
            this.imagePathListView.UseCompatibleStateImageBehavior = false;
            this.imagePathListView.SelectedIndexChanged += new System.EventHandler(this.OnImagePathListItemSelected);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(433, 131);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(59, 15);
            this.previewLabel.TabIndex = 16;
            this.previewLabel.Text = "크게 보기";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1006, 531);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.imagePathListView);
            this.Controls.Add(this.savePathButton);
            this.Controls.Add(this.movePixelButton);
            this.Controls.Add(this.movePixellabe_Y);
            this.Controls.Add(this.numericUpDown_movePixel_Y);
            this.Controls.Add(this.movePixelLabel_X);
            this.Controls.Add(this.numericUpDown_movePixel_X);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.ImagePathLabel);
            this.Controls.Add(this.savePathBox);
            this.Controls.Add(this.LoadImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "픽셀 이동 툴";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_movePixel_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_movePixel_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.TextBox savePathBox;
        private System.Windows.Forms.Label ImagePathLabel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.NumericUpDown numericUpDown_movePixel_X;
        private System.Windows.Forms.Label movePixelLabel_X;
        private System.Windows.Forms.Label movePixellabe_Y;
        private System.Windows.Forms.NumericUpDown numericUpDown_movePixel_Y;
        private System.Windows.Forms.Button movePixelButton;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView imagePathListView;
        private System.Windows.Forms.Label previewLabel;
    }
}

