namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.textBoxuzlet = new System.Windows.Forms.TextBox();
            this.labelnev = new System.Windows.Forms.Label();
            this.labeluzlet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uj ajandék felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxnev
            // 
            this.textBoxnev.Location = new System.Drawing.Point(333, 66);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(202, 20);
            this.textBoxnev.TabIndex = 2;
            this.textBoxnev.Visible = false;
            // 
            // textBoxuzlet
            // 
            this.textBoxuzlet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxuzlet.Location = new System.Drawing.Point(333, 125);
            this.textBoxuzlet.Name = "textBoxuzlet";
            this.textBoxuzlet.Size = new System.Drawing.Size(202, 20);
            this.textBoxuzlet.TabIndex = 3;
            this.textBoxuzlet.Visible = false;
            // 
            // labelnev
            // 
            this.labelnev.AutoSize = true;
            this.labelnev.Location = new System.Drawing.Point(330, 36);
            this.labelnev.Name = "labelnev";
            this.labelnev.Size = new System.Drawing.Size(27, 13);
            this.labelnev.TabIndex = 4;
            this.labelnev.Text = "Név";
            this.labelnev.Visible = false;
            // 
            // labeluzlet
            // 
            this.labeluzlet.AutoSize = true;
            this.labeluzlet.Location = new System.Drawing.Point(335, 99);
            this.labeluzlet.Name = "labeluzlet";
            this.labeluzlet.Size = new System.Drawing.Size(31, 13);
            this.labeluzlet.TabIndex = 5;
            this.labeluzlet.Text = "Uzlet";
            this.labeluzlet.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Felvesz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labeluzlet);
            this.Controls.Add(this.labelnev);
            this.Controls.Add(this.textBoxuzlet);
            this.Controls.Add(this.textBoxnev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxnev;
        private System.Windows.Forms.TextBox textBoxuzlet;
        private System.Windows.Forms.Label labelnev;
        private System.Windows.Forms.Label labeluzlet;
        private System.Windows.Forms.Button button2;
    }
}

