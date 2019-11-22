namespace UserMaintenance
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.labelLast = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnFileSa = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 329);
            this.listBox1.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(361, 12);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(160, 20);
            this.txtLast.TabIndex = 1;
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(290, 12);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(41, 15);
            this.labelLast.TabIndex = 2;
            this.labelLast.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(290, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(290, 38);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(41, 15);
            this.labelFirst.TabIndex = 4;
            this.labelFirst.Text = "label2";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(361, 38);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(160, 20);
            this.txtFirst.TabIndex = 5;
            // 
            // btnFileSa
            // 
            this.btnFileSa.Location = new System.Drawing.Point(290, 116);
            this.btnFileSa.Name = "btnFileSa";
            this.btnFileSa.Size = new System.Drawing.Size(75, 23);
            this.btnFileSa.TabIndex = 6;
            this.btnFileSa.Text = "Save";
            this.btnFileSa.UseVisualStyleBackColor = true;
            this.btnFileSa.Click += new System.EventHandler(this.btnFileSa_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(293, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 364);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFileSa);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnFileSa;
        private System.Windows.Forms.Button btnDel;
    }
}

