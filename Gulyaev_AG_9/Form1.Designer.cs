namespace Gulyaev_AG_9
{
    partial class Form1
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
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelCntStreams = new System.Windows.Forms.Label();
            this.labelFillingSpeed = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.trackBarCnt = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelRadiusValue = new System.Windows.Forms.Label();
            this.labelCntValue = new System.Windows.Forms.Label();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius.Location = new System.Drawing.Point(463, 18);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(159, 24);
            this.labelRadius.TabIndex = 0;
            this.labelRadius.Text = "Радиус круга";
            // 
            // labelCntStreams
            // 
            this.labelCntStreams.AutoSize = true;
            this.labelCntStreams.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCntStreams.Location = new System.Drawing.Point(463, 103);
            this.labelCntStreams.Name = "labelCntStreams";
            this.labelCntStreams.Size = new System.Drawing.Size(250, 24);
            this.labelCntStreams.TabIndex = 0;
            this.labelCntStreams.Text = "Количество потоков";
            // 
            // labelFillingSpeed
            // 
            this.labelFillingSpeed.AutoSize = true;
            this.labelFillingSpeed.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFillingSpeed.Location = new System.Drawing.Point(463, 189);
            this.labelFillingSpeed.Name = "labelFillingSpeed";
            this.labelFillingSpeed.Size = new System.Drawing.Size(261, 24);
            this.labelFillingSpeed.TabIndex = 0;
            this.labelFillingSpeed.Text = "Скорость заполнения";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(467, 278);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(277, 41);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(455, 44);
            this.trackBarRadius.Maximum = 150;
            this.trackBarRadius.Minimum = 20;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(245, 56);
            this.trackBarRadius.TabIndex = 4;
            this.trackBarRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRadius.Value = 20;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBarRadius_Scroll);
            // 
            // trackBarCnt
            // 
            this.trackBarCnt.Location = new System.Drawing.Point(455, 130);
            this.trackBarCnt.Minimum = 1;
            this.trackBarCnt.Name = "trackBarCnt";
            this.trackBarCnt.Size = new System.Drawing.Size(245, 56);
            this.trackBarCnt.TabIndex = 4;
            this.trackBarCnt.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarCnt.Value = 1;
            this.trackBarCnt.Scroll += new System.EventHandler(this.trackBarCnt_Scroll);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(455, 216);
            this.trackBarSpeed.Maximum = 200;
            this.trackBarSpeed.Minimum = 20;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(245, 56);
            this.trackBarSpeed.TabIndex = 4;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpeed.Value = 20;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelRadiusValue
            // 
            this.labelRadiusValue.AutoSize = true;
            this.labelRadiusValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRadiusValue.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelRadiusValue.Location = new System.Drawing.Point(706, 55);
            this.labelRadiusValue.Name = "labelRadiusValue";
            this.labelRadiusValue.Size = new System.Drawing.Size(38, 24);
            this.labelRadiusValue.TabIndex = 5;
            this.labelRadiusValue.Text = "20";
            this.labelRadiusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCntValue
            // 
            this.labelCntValue.AutoSize = true;
            this.labelCntValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCntValue.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelCntValue.Location = new System.Drawing.Point(706, 142);
            this.labelCntValue.Name = "labelCntValue";
            this.labelCntValue.Size = new System.Drawing.Size(24, 24);
            this.labelCntValue.TabIndex = 5;
            this.labelCntValue.Text = "1";
            this.labelCntValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSpeedValue.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelSpeedValue.Location = new System.Drawing.Point(706, 227);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(38, 24);
            this.labelSpeedValue.TabIndex = 5;
            this.labelSpeedValue.Text = "20";
            this.labelSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonArea
            // 
            this.buttonArea.Font = new System.Drawing.Font("Georgia Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonArea.Location = new System.Drawing.Point(467, 325);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(277, 41);
            this.buttonArea.TabIndex = 3;
            this.buttonArea.Text = "Площадь круга";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.labelSpeedValue);
            this.Controls.Add(this.labelCntValue);
            this.Controls.Add(this.labelRadiusValue);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.trackBarCnt);
            this.Controls.Add(this.trackBarRadius);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelFillingSpeed);
            this.Controls.Add(this.labelCntStreams);
            this.Controls.Add(this.labelRadius);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Circle area";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelCntStreams;
        private System.Windows.Forms.Label labelFillingSpeed;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.TrackBar trackBarCnt;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelRadiusValue;
        private System.Windows.Forms.Label labelCntValue;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.Button buttonArea;
    }
}

