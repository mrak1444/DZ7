
namespace DZ7
{
    partial class Form2
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
            this.RunGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadNum = new System.Windows.Forms.TextBox();
            this.RunNum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RunGame
            // 
            this.RunGame.AllowDrop = true;
            this.RunGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunGame.Location = new System.Drawing.Point(51, 12);
            this.RunGame.Name = "RunGame";
            this.RunGame.Size = new System.Drawing.Size(529, 66);
            this.RunGame.TabIndex = 0;
            this.RunGame.Text = "Загадать число";
            this.RunGame.UseVisualStyleBackColor = true;
            this.RunGame.Click += new System.EventHandler(this.RunGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отгадая число от 1 до 100";
            // 
            // ReadNum
            // 
            this.ReadNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadNum.Location = new System.Drawing.Point(51, 132);
            this.ReadNum.Name = "ReadNum";
            this.ReadNum.Size = new System.Drawing.Size(529, 55);
            this.ReadNum.TabIndex = 2;
            // 
            // RunNum
            // 
            this.RunNum.AllowDrop = true;
            this.RunNum.Enabled = false;
            this.RunNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunNum.Location = new System.Drawing.Point(51, 193);
            this.RunNum.Name = "RunNum";
            this.RunNum.Size = new System.Drawing.Size(529, 66);
            this.RunNum.TabIndex = 3;
            this.RunNum.Text = "Отгадать число";
            this.RunNum.UseVisualStyleBackColor = true;
            this.RunNum.Click += new System.EventHandler(this.RunNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отгадая число от 1 до 100";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Попыток:";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counter.Location = new System.Drawing.Point(166, 363);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(27, 29);
            this.Counter.TabIndex = 6;
            this.Counter.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunNum);
            this.Controls.Add(this.ReadNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunGame);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReadNum;
        private System.Windows.Forms.Button RunNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Counter;
    }
}