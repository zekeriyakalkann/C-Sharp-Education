namespace Windows_Form
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
            lb1 = new Label();
            bt1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(107, 69);
            lb1.Name = "lb1";
            lb1.Size = new Size(43, 17);
            lb1.TabIndex = 0;
            lb1.Text = "label1";
            lb1.Click += lb1_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(119, 156);
            bt1.Name = "bt1";
            bt1.Size = new Size(131, 74);
            bt1.TabIndex = 1;
            bt1.Text = "button1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 156);
            button2.Name = "button2";
            button2.Size = new Size(130, 74);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 324);
            button3.Name = "button3";
            button3.Size = new Size(83, 25);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 718);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bt1);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Button bt1;
        private Button button2;
        private Button button3;
    }
}
