using System.ComponentModel;

namespace Programming.View.Controls
{
    partial class RectangleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.YRectangleLable = new System.Windows.Forms.Label();
            this.XRectangleLabel = new System.Windows.Forms.Label();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.LengthRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(116, 207);
            this.IdRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.IdRectangleTextBox.TabIndex = 27;
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Enabled = false;
            this.YRectangleTextBox.Location = new System.Drawing.Point(116, 171);
            this.YRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.YRectangleTextBox.TabIndex = 26;
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Enabled = false;
            this.XRectangleTextBox.Location = new System.Drawing.Point(116, 135);
            this.XRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.XRectangleTextBox.TabIndex = 25;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.Location = new System.Drawing.Point(116, 193);
            this.IdRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(35, 12);
            this.IdRectangleLabel.TabIndex = 24;
            this.IdRectangleLabel.Text = "Id:";
            // 
            // YRectangleLable
            // 
            this.YRectangleLable.Location = new System.Drawing.Point(116, 157);
            this.YRectangleLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YRectangleLable.Name = "YRectangleLable";
            this.YRectangleLable.Size = new System.Drawing.Size(35, 12);
            this.YRectangleLable.TabIndex = 23;
            this.YRectangleLable.Text = "Y:";
            // 
            // XRectangleLabel
            // 
            this.XRectangleLabel.Location = new System.Drawing.Point(116, 119);
            this.XRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XRectangleLabel.Name = "XRectangleLabel";
            this.XRectangleLabel.Size = new System.Drawing.Size(35, 14);
            this.XRectangleLabel.TabIndex = 22;
            this.XRectangleLabel.Text = "X:";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(116, 268);
            this.FindRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(71, 24);
            this.FindRectangleButton.TabIndex = 21;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(116, 58);
            this.WidthRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.WidthRectangleTextBox.TabIndex = 20;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged_1);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(116, 97);
            this.ColorRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.ColorRectangleTextBox.TabIndex = 19;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged_1);
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(116, 19);
            this.LengthRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.LengthRectangleTextBox.TabIndex = 18;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleLabel
            // 
            this.ColorRectangleLabel.Location = new System.Drawing.Point(116, 80);
            this.ColorRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorRectangleLabel.Name = "ColorRectangleLabel";
            this.ColorRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.ColorRectangleLabel.TabIndex = 17;
            this.ColorRectangleLabel.Text = "Color:";
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.Location = new System.Drawing.Point(116, 41);
            this.WidthRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.WidthRectangleLabel.TabIndex = 16;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // LengthRectangleLabel
            // 
            this.LengthRectangleLabel.Location = new System.Drawing.Point(116, 2);
            this.LengthRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthRectangleLabel.Name = "LengthRectangleLabel";
            this.LengthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.LengthRectangleLabel.TabIndex = 15;
            this.LengthRectangleLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(0, 2);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(112, 290);
            this.RectangleListBox.TabIndex = 14;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdRectangleTextBox);
            this.Controls.Add(this.YRectangleTextBox);
            this.Controls.Add(this.XRectangleTextBox);
            this.Controls.Add(this.IdRectangleLabel);
            this.Controls.Add(this.YRectangleLable);
            this.Controls.Add(this.XRectangleLabel);
            this.Controls.Add(this.FindRectangleButton);
            this.Controls.Add(this.WidthRectangleTextBox);
            this.Controls.Add(this.ColorRectangleTextBox);
            this.Controls.Add(this.LengthRectangleTextBox);
            this.Controls.Add(this.ColorRectangleLabel);
            this.Controls.Add(this.WidthRectangleLabel);
            this.Controls.Add(this.LengthRectangleLabel);
            this.Controls.Add(this.RectangleListBox);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(266, 334);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.Label YRectangleLable;
        private System.Windows.Forms.Label XRectangleLabel;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.Label ColorRectangleLabel;
        private System.Windows.Forms.Label WidthRectangleLabel;
        private System.Windows.Forms.Label LengthRectangleLabel;
        private System.Windows.Forms.ListBox RectangleListBox;

        #endregion
    }
}