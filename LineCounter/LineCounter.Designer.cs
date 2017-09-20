namespace LineCounter
{
    partial class LineCounter
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
            this.output = new System.Windows.Forms.TextBox();
            this.excludeComments = new System.Windows.Forms.CheckBox();
            this.useRecursive = new System.Windows.Forms.CheckBox();
            this.singleline = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.fileEndings = new LineCounter.CustomTextBox();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.multiline = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(12, 216);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(480, 181);
            this.output.TabIndex = 0;
            this.output.WordWrap = false;
            // 
            // excludeComments
            // 
            this.excludeComments.AutoSize = true;
            this.excludeComments.Location = new System.Drawing.Point(12, 102);
            this.excludeComments.Name = "excludeComments";
            this.excludeComments.Size = new System.Drawing.Size(124, 17);
            this.excludeComments.TabIndex = 1;
            this.excludeComments.Text = "Exclude special lines";
            this.excludeComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.excludeComments.UseVisualStyleBackColor = true;
            this.excludeComments.CheckedChanged += new System.EventHandler(this.excludeComments_CheckedChanged);
            // 
            // useRecursive
            // 
            this.useRecursive.AutoSize = true;
            this.useRecursive.Location = new System.Drawing.Point(12, 79);
            this.useRecursive.Name = "useRecursive";
            this.useRecursive.Size = new System.Drawing.Size(180, 17);
            this.useRecursive.TabIndex = 2;
            this.useRecursive.Text = "Recursively check for subfolders";
            this.useRecursive.UseVisualStyleBackColor = true;
            // 
            // singleline
            // 
            this.singleline.Enabled = false;
            this.singleline.Location = new System.Drawing.Point(3, 43);
            this.singleline.Name = "singleline";
            this.singleline.Size = new System.Drawing.Size(222, 20);
            this.singleline.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Special Symbols";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(215, 430);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 6;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "File endings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project folder";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(417, 24);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 11;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // fileEndings
            // 
            this.fileEndings.Location = new System.Drawing.Point(84, 53);
            this.fileEndings.Name = "fileEndings";
            this.fileEndings.Size = new System.Drawing.Size(408, 20);
            this.fileEndings.TabIndex = 12;
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(84, 26);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(326, 20);
            this.folderBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.multiline);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.singleline);
            this.panel1.Location = new System.Drawing.Point(13, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 72);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ignore within";
            // 
            // multiline
            // 
            this.multiline.Enabled = false;
            this.multiline.Location = new System.Drawing.Point(254, 43);
            this.multiline.Name = "multiline";
            this.multiline.Size = new System.Drawing.Size(222, 20);
            this.multiline.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ignore starting with";
            // 
            // LineCounter
            // 
            this.AcceptButton = this.analyzeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.fileEndings);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.useRecursive);
            this.Controls.Add(this.excludeComments);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LineCounter";
            this.Text = "Code Line Counter";
            this.Load += new System.EventHandler(this.LineCounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.CheckBox excludeComments;
        private System.Windows.Forms.CheckBox useRecursive;
        private System.Windows.Forms.MaskedTextBox singleline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browse;
        private CustomTextBox fileEndings;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox multiline;
        private System.Windows.Forms.Label label5;

        private class CustomTextBox : global::LineCounter.CustomTextBox
        {
        }
    }
}

