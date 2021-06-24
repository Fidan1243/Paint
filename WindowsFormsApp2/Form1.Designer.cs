namespace WindowsFormsApp2
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
            this.FigureComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxt = new System.Windows.Forms.TextBox();
            this.htxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorbtn = new System.Windows.Forms.Button();
            this.fillbtn = new System.Windows.Forms.RadioButton();
            this.emptybtn = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // FigureComboBox
            // 
            this.FigureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureComboBox.FormattingEnabled = true;
            this.FigureComboBox.Location = new System.Drawing.Point(28, 34);
            this.FigureComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FigureComboBox.Name = "FigureComboBox";
            this.FigureComboBox.Size = new System.Drawing.Size(243, 38);
            this.FigureComboBox.TabIndex = 0;
            this.FigureComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // wtxt
            // 
            this.wtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wtxt.Location = new System.Drawing.Point(452, 34);
            this.wtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wtxt.Name = "wtxt";
            this.wtxt.Size = new System.Drawing.Size(189, 37);
            this.wtxt.TabIndex = 2;
            this.wtxt.Text = "100";
            // 
            // htxt
            // 
            this.htxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.htxt.Location = new System.Drawing.Point(859, 34);
            this.htxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htxt.Name = "htxt";
            this.htxt.Size = new System.Drawing.Size(189, 37);
            this.htxt.TabIndex = 4;
            this.htxt.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(744, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1127, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // colorbtn
            // 
            this.colorbtn.AutoSize = true;
            this.colorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorbtn.Location = new System.Drawing.Point(1241, 38);
            this.colorbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(100, 43);
            this.colorbtn.TabIndex = 6;
            this.colorbtn.Text = "Click";
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // fillbtn
            // 
            this.fillbtn.AutoSize = true;
            this.fillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillbtn.Location = new System.Drawing.Point(1392, 36);
            this.fillbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillbtn.Name = "fillbtn";
            this.fillbtn.Size = new System.Drawing.Size(74, 35);
            this.fillbtn.TabIndex = 7;
            this.fillbtn.TabStop = true;
            this.fillbtn.Text = "Fill";
            this.fillbtn.UseVisualStyleBackColor = true;
            // 
            // emptybtn
            // 
            this.emptybtn.AutoSize = true;
            this.emptybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptybtn.Location = new System.Drawing.Point(1483, 33);
            this.emptybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emptybtn.Name = "emptybtn";
            this.emptybtn.Size = new System.Drawing.Size(117, 35);
            this.emptybtn.TabIndex = 8;
            this.emptybtn.TabStop = true;
            this.emptybtn.Text = "Empty";
            this.emptybtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 791);
            this.Controls.Add(this.emptybtn);
            this.Controls.Add(this.fillbtn);
            this.Controls.Add(this.colorbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.htxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FigureComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorbtn_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorbtn_MouseClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wtxt;
        private System.Windows.Forms.TextBox htxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.RadioButton fillbtn;
        private System.Windows.Forms.RadioButton emptybtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

