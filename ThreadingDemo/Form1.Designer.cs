namespace ThreadingDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcess1 = new Button();
            btnProcess2 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnProcess1
            // 
            btnProcess1.Location = new Point(143, 93);
            btnProcess1.Margin = new Padding(5);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new Size(158, 67);
            btnProcess1.TabIndex = 0;
            btnProcess1.Text = "İşlem1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Location = new Point(367, 83);
            btnProcess2.Margin = new Padding(5);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new Size(125, 63);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "İşlem2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(548, 188);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 750);
            Controls.Add(listView1);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess1;
        private Button btnProcess2;
        private ListView listView1;
    }
}
