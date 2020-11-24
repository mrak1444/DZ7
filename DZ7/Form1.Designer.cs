
namespace DZ7
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
            this.components = new System.ComponentModel.Container();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.StepNum = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerGame = new System.Windows.Forms.Label();
            this.StopGame = new System.Windows.Forms.Button();
            this.RndNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(83, 12);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(83, 41);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(22, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // StepNum
            // 
            this.StepNum.AutoSize = true;
            this.StepNum.Location = new System.Drawing.Point(12, 195);
            this.StepNum.Name = "StepNum";
            this.StepNum.Size = new System.Drawing.Size(46, 17);
            this.StepNum.TabIndex = 4;
            this.StepNum.Text = "label1";
            // 
            // Game
            // 
            this.Game.Location = new System.Drawing.Point(176, 12);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(95, 52);
            this.Game.TabIndex = 5;
            this.Game.Text = "button1";
            this.Game.UseVisualStyleBackColor = true;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // TimerGame
            // 
            this.TimerGame.AutoSize = true;
            this.TimerGame.Location = new System.Drawing.Point(225, 195);
            this.TimerGame.Name = "TimerGame";
            this.TimerGame.Size = new System.Drawing.Size(46, 17);
            this.TimerGame.TabIndex = 6;
            this.TimerGame.Text = "label1";
            // 
            // StopGame
            // 
            this.StopGame.Location = new System.Drawing.Point(176, 70);
            this.StopGame.Name = "StopGame";
            this.StopGame.Size = new System.Drawing.Size(95, 23);
            this.StopGame.TabIndex = 7;
            this.StopGame.Text = "button1";
            this.StopGame.UseVisualStyleBackColor = true;
            this.StopGame.Click += new System.EventHandler(this.StopGame_Click);
            // 
            // RndNum
            // 
            this.RndNum.AutoSize = true;
            this.RndNum.Location = new System.Drawing.Point(112, 144);
            this.RndNum.Name = "RndNum";
            this.RndNum.Size = new System.Drawing.Size(46, 17);
            this.RndNum.TabIndex = 8;
            this.RndNum.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 224);
            this.Controls.Add(this.RndNum);
            this.Controls.Add(this.StopGame);
            this.Controls.Add(this.TimerGame);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.StepNum);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label StepNum;
        private System.Windows.Forms.Button Game;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerGame;
        private System.Windows.Forms.Button StopGame;
        private System.Windows.Forms.Label RndNum;
    }
}

