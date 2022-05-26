using System.ComponentModel;

namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.YSelectedTextBox = new System.Windows.Forms.TextBox();
            this.HeightSelectedTextBox = new System.Windows.Forms.TextBox();
            this.WidthSelectedTextBox = new System.Windows.Forms.TextBox();
            this.XSelectedTextBox = new System.Windows.Forms.TextBox();
            this.IdSelectedTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(227, 0);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(374, 420);
            this.CanvasPanel.TabIndex = 33;
            // 
            // YSelectedTextBox
            // 
            this.YSelectedTextBox.Location = new System.Drawing.Point(59, 241);
            this.YSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YSelectedTextBox.Name = "YSelectedTextBox";
            this.YSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.YSelectedTextBox.TabIndex = 32;
            this.YSelectedTextBox.TextChanged += new System.EventHandler(this.YSelectedTextBox_TextChanged);
            // 
            // HeightSelectedTextBox
            // 
            this.HeightSelectedTextBox.Location = new System.Drawing.Point(59, 289);
            this.HeightSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightSelectedTextBox.Name = "HeightSelectedTextBox";
            this.HeightSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.HeightSelectedTextBox.TabIndex = 31;
            this.HeightSelectedTextBox.TextChanged += new System.EventHandler(this.HeightSelectedTextBox_TextChanged);
            // 
            // WidthSelectedTextBox
            // 
            this.WidthSelectedTextBox.Location = new System.Drawing.Point(59, 265);
            this.WidthSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthSelectedTextBox.Name = "WidthSelectedTextBox";
            this.WidthSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.WidthSelectedTextBox.TabIndex = 30;
            this.WidthSelectedTextBox.TextChanged += new System.EventHandler(this.WidthSelectedTextBox_TextChanged);
            // 
            // XSelectedTextBox
            // 
            this.XSelectedTextBox.Location = new System.Drawing.Point(59, 219);
            this.XSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XSelectedTextBox.Name = "XSelectedTextBox";
            this.XSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.XSelectedTextBox.TabIndex = 29;
            this.XSelectedTextBox.TextChanged += new System.EventHandler(this.XSelectedTextBox_TextChanged);
            // 
            // IdSelectedTextBox
            // 
            this.IdSelectedTextBox.Enabled = false;
            this.IdSelectedTextBox.Location = new System.Drawing.Point(59, 196);
            this.IdSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdSelectedTextBox.Name = "IdSelectedTextBox";
            this.IdSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.IdSelectedTextBox.TabIndex = 28;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(12, 292);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(47, 20);
            this.HeightLabel.TabIndex = 27;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(14, 270);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(47, 20);
            this.WidthLabel.TabIndex = 26;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.Location = new System.Drawing.Point(34, 246);
            this.YLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(21, 20);
            this.YLabel.TabIndex = 25;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.Location = new System.Drawing.Point(34, 223);
            this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(21, 20);
            this.XLabel.TabIndex = 24;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(34, 199);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 20);
            this.IdLabel.TabIndex = 23;
            this.IdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(2, 180);
            this.SelectedRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(120, 19);
            this.SelectedRectangleLabel.TabIndex = 22;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(12, 21);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(208, 121);
            this.RectanglesListBox.TabIndex = 21;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleLabel
            // 
            this.RectangleLabel.Location = new System.Drawing.Point(12, 0);
            this.RectangleLabel.Name = "RectangleLabel";
            this.RectangleLabel.Size = new System.Drawing.Size(64, 19);
            this.RectangleLabel.TabIndex = 20;
            this.RectangleLabel.Text = "Rectangles:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (250)))), ((int) (((byte) (250)))));
            this.RemoveRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("RemoveRectangleButton.Image")));
            this.RemoveRectangleButton.Location = new System.Drawing.Point(145, 141);
            this.RemoveRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 30);
            this.RemoveRectangleButton.TabIndex = 19;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (250)))), ((int) (((byte) (250)))));
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(2, 141);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 30);
            this.AddRectangleButton.TabIndex = 18;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.YSelectedTextBox);
            this.Controls.Add(this.HeightSelectedTextBox);
            this.Controls.Add(this.WidthSelectedTextBox);
            this.Controls.Add(this.XSelectedTextBox);
            this.Controls.Add(this.IdSelectedTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.RectangleLabel);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(616, 439);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox YSelectedTextBox;
        private System.Windows.Forms.TextBox HeightSelectedTextBox;
        private System.Windows.Forms.TextBox WidthSelectedTextBox;
        private System.Windows.Forms.TextBox XSelectedTextBox;
        private System.Windows.Forms.TextBox IdSelectedTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectangleLabel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;

        #endregion
    }
}