namespace OOP_abstract
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
            btnIT = new Button();
            btnBiz = new Button();
            SuspendLayout();
            // 
            // btnIT
            // 
            btnIT.Location = new Point(148, 128);
            btnIT.Name = "btnIT";
            btnIT.Size = new Size(75, 23);
            btnIT.TabIndex = 0;
            btnIT.Text = "IT";
            btnIT.UseVisualStyleBackColor = true;
            btnIT.Click += btnIT_Click;
            // 
            // btnBiz
            // 
            btnBiz.Location = new Point(361, 128);
            btnBiz.Name = "btnBiz";
            btnBiz.Size = new Size(75, 23);
            btnBiz.TabIndex = 1;
            btnBiz.Text = "Biz";
            btnBiz.UseVisualStyleBackColor = true;
            btnBiz.Click += btnBiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBiz);
            Controls.Add(btnIT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIT;
        private Button btnBiz;
    }
}
