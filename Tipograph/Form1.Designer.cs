namespace Tipograph
{
    partial class Tipograph
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AboutProgrammButton = new System.Windows.Forms.Button();
            this.TipographTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Типограф";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(55, 179);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 250);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.Text = "";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(467, 179);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(350, 250);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваш текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(460, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Исправленный текст";
            // 
            // AboutProgrammButton
            // 
            this.AboutProgrammButton.BackColor = System.Drawing.Color.White;
            this.AboutProgrammButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgrammButton.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgrammButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutProgrammButton.Location = new System.Drawing.Point(55, 12);
            this.AboutProgrammButton.Name = "AboutProgrammButton";
            this.AboutProgrammButton.Size = new System.Drawing.Size(121, 44);
            this.AboutProgrammButton.TabIndex = 5;
            this.AboutProgrammButton.Text = "О программе";
            this.AboutProgrammButton.UseVisualStyleBackColor = false;
            this.AboutProgrammButton.Click += new System.EventHandler(this.AboutProgrammButton_Click);
            // 
            // TipographTextButton
            // 
            this.TipographTextButton.BackColor = System.Drawing.Color.White;
            this.TipographTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipographTextButton.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipographTextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TipographTextButton.Location = new System.Drawing.Point(314, 450);
            this.TipographTextButton.Name = "TipographTextButton";
            this.TipographTextButton.Size = new System.Drawing.Size(238, 73);
            this.TipographTextButton.TabIndex = 6;
            this.TipographTextButton.Text = "Оттипографить";
            this.TipographTextButton.UseVisualStyleBackColor = false;
            this.TipographTextButton.Click += new System.EventHandler(this.TipographTextButton_Click);
            // 
            // Tipograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.TipographTextButton);
            this.Controls.Add(this.AboutProgrammButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Tipograph";
            this.Text = "Типограф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AboutProgrammButton;
        private System.Windows.Forms.Button TipographTextButton;
    }
}

