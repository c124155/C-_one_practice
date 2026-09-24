namespace homework_assignment
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dayOfmonthPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(314, 422);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(230, 59);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(571, 422);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(230, 59);
            this.btnclose.TabIndex = 25;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(60, 422);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(230, 59);
            this.btnshow.TabIndex = 24;
            this.btnshow.Text = "Show Data";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutputLabel.Location = new System.Drawing.Point(60, 312);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(741, 77);
            this.dateOutputLabel.TabIndex = 23;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(466, 245);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(335, 30);
            this.yearTextBox.TabIndex = 21;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(466, 182);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(335, 30);
            this.dayOfMonthTextBox.TabIndex = 20;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Location = new System.Drawing.Point(466, 117);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(335, 30);
            this.monthTextBox.TabIndex = 19;
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(466, 56);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(335, 30);
            this.dayOfWeekTextBox.TabIndex = 18;
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPromptLabel.Location = new System.Drawing.Point(277, 241);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(161, 29);
            this.yearPromptLabel.TabIndex = 17;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dayOfmonthPromptLabel
            // 
            this.dayOfmonthPromptLabel.AutoSize = true;
            this.dayOfmonthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfmonthPromptLabel.Location = new System.Drawing.Point(56, 179);
            this.dayOfmonthPromptLabel.Name = "dayOfmonthPromptLabel";
            this.dayOfmonthPromptLabel.Size = new System.Drawing.Size(382, 29);
            this.dayOfmonthPromptLabel.TabIndex = 16;
            this.dayOfmonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthPromptLabel.Location = new System.Drawing.Point(126, 117);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(312, 29);
            this.monthPromptLabel.TabIndex = 15;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(156, 56);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(282, 29);
            this.dayOfWeekPromptLabel.TabIndex = 14;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfmonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dayOfmonthPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
    }
}

