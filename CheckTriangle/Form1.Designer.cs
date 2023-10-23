namespace CheckTriangle
{
    partial class CheckTriangle
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
            this.FirstSideSizeTextBox = new System.Windows.Forms.TextBox();
            this.ThirdSideSizeTextBox = new System.Windows.Forms.TextBox();
            this.SecondSideSizeTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstSideSizeTextBox
            // 
            this.FirstSideSizeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.FirstSideSizeTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSideSizeTextBox.Location = new System.Drawing.Point(140, 85);
            this.FirstSideSizeTextBox.Multiline = true;
            this.FirstSideSizeTextBox.Name = "FirstSideSizeTextBox";
            this.FirstSideSizeTextBox.Size = new System.Drawing.Size(68, 26);
            this.FirstSideSizeTextBox.TabIndex = 2;
            this.FirstSideSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThirdSideSizeTextBox
            // 
            this.ThirdSideSizeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.ThirdSideSizeTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdSideSizeTextBox.Location = new System.Drawing.Point(359, 85);
            this.ThirdSideSizeTextBox.Multiline = true;
            this.ThirdSideSizeTextBox.Name = "ThirdSideSizeTextBox";
            this.ThirdSideSizeTextBox.Size = new System.Drawing.Size(68, 26);
            this.ThirdSideSizeTextBox.TabIndex = 3;
            this.ThirdSideSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondSideSizeTextBox
            // 
            this.SecondSideSizeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.SecondSideSizeTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSideSizeTextBox.Location = new System.Drawing.Point(249, 85);
            this.SecondSideSizeTextBox.Multiline = true;
            this.SecondSideSizeTextBox.Name = "SecondSideSizeTextBox";
            this.SecondSideSizeTextBox.Size = new System.Drawing.Size(68, 26);
            this.SecondSideSizeTextBox.TabIndex = 4;
            this.SecondSideSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.GhostWhite;
            this.CheckButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(209, 193);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(145, 42);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check";
            this.CheckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите стороны треугольника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(36, 124);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(495, 44);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(559, 270);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.SecondSideSizeTextBox);
            this.Controls.Add(this.ThirdSideSizeTextBox);
            this.Controls.Add(this.FirstSideSizeTextBox);
            this.Name = "CheckTriangle";
            this.Text = "CheckTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstSideSizeTextBox;
        private System.Windows.Forms.TextBox ThirdSideSizeTextBox;
        private System.Windows.Forms.TextBox SecondSideSizeTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

