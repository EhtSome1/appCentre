
namespace appCentre
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.BinaryTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.binaryToIPReturnButton = new System.Windows.Forms.Button();
            this.ToIPButton = new System.Windows.Forms.Button();
            this.ToBinaryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toBinaryIPconvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.85046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.14953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BinaryTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.binaryToIPReturnButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToIPButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ToBinaryButton, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPTextBox.Location = new System.Drawing.Point(319, 213);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(278, 20);
            this.IPTextBox.TabIndex = 4;
            // 
            // BinaryTextBox
            // 
            this.BinaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BinaryTextBox.Location = new System.Drawing.Point(2, 213);
            this.BinaryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BinaryTextBox.Name = "BinaryTextBox";
            this.BinaryTextBox.Size = new System.Drawing.Size(272, 20);
            this.BinaryTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 45);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Binary";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(412, 133);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(92, 45);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "IP";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // binaryToIPReturnButton
            // 
            this.binaryToIPReturnButton.Location = new System.Drawing.Point(2, 2);
            this.binaryToIPReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.binaryToIPReturnButton.Name = "binaryToIPReturnButton";
            this.binaryToIPReturnButton.Size = new System.Drawing.Size(130, 53);
            this.binaryToIPReturnButton.TabIndex = 6;
            this.binaryToIPReturnButton.Text = "Return";
            this.binaryToIPReturnButton.UseVisualStyleBackColor = true;
            this.binaryToIPReturnButton.Click += new System.EventHandler(this.binaryToIPReturnButton_Click);
            // 
            // ToIPButton
            // 
            this.ToIPButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToIPButton.Location = new System.Drawing.Point(93, 270);
            this.ToIPButton.Name = "ToIPButton";
            this.ToIPButton.Size = new System.Drawing.Size(90, 31);
            this.ToIPButton.TabIndex = 7;
            this.ToIPButton.Text = "To IP";
            this.ToIPButton.UseVisualStyleBackColor = true;
            this.ToIPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToBinaryButton
            // 
            this.ToBinaryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToBinaryButton.Location = new System.Drawing.Point(410, 270);
            this.ToBinaryButton.Name = "ToBinaryButton";
            this.ToBinaryButton.Size = new System.Drawing.Size(96, 36);
            this.ToBinaryButton.TabIndex = 8;
            this.ToBinaryButton.Text = "To Binary";
            this.ToBinaryButton.UseVisualStyleBackColor = true;
            this.ToBinaryButton.Click += new System.EventHandler(this.ToBinaryButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.toBinaryIPconvert, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // toBinaryIPconvert
            // 
            this.toBinaryIPconvert.Location = new System.Drawing.Point(3, 3);
            this.toBinaryIPconvert.Name = "toBinaryIPconvert";
            this.toBinaryIPconvert.Size = new System.Drawing.Size(87, 76);
            this.toBinaryIPconvert.TabIndex = 0;
            this.toBinaryIPconvert.Text = "binary-IP converter";
            this.toBinaryIPconvert.UseVisualStyleBackColor = true;
            this.toBinaryIPconvert.Click += new System.EventHandler(this.toBinaryIPconvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BinaryTextBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button binaryToIPReturnButton;
        private System.Windows.Forms.Button ToIPButton;
        private System.Windows.Forms.Button ToBinaryButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button toBinaryIPconvert;
    }
}

