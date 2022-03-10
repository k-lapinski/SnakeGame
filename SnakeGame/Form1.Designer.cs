namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.textHighScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(117)))), ((int)(((byte)(71)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Location = new System.Drawing.Point(611, 24);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(2);
            this.startButton.Size = new System.Drawing.Size(123, 49);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(117)))), ((int)(((byte)(71)))));
            this.snapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snapButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snapButton.Location = new System.Drawing.Point(611, 91);
            this.snapButton.Name = "snapButton";
            this.snapButton.Padding = new System.Windows.Forms.Padding(2);
            this.snapButton.Size = new System.Drawing.Size(123, 52);
            this.snapButton.TabIndex = 1;
            this.snapButton.Text = "snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.Image = ((System.Drawing.Image)(resources.GetObject("picCanvas.Image")));
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textScore.Location = new System.Drawing.Point(608, 162);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(71, 22);
            this.textScore.TabIndex = 3;
            this.textScore.Text = "score: 0";
            // 
            // textHighScore
            // 
            this.textHighScore.AutoSize = true;
            this.textHighScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textHighScore.Location = new System.Drawing.Point(608, 191);
            this.textHighScore.Name = "textHighScore";
            this.textHighScore.Size = new System.Drawing.Size(92, 22);
            this.textHighScore.TabIndex = 4;
            this.textHighScore.Text = "high score";
            this.textHighScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(746, 717);
            this.Controls.Add(this.textHighScore);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textHighScore;
        private System.Windows.Forms.Timer GameTimer;
    }
}

