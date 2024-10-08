namespace TextBoxDemo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnComfirm = new Button();
            txtFristName = new TextBox();
            txtLastName = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(79, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 0;
            label1.Text = "FristName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(79, 113);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(88, 187);
            label3.Name = "label3";
            label3.Size = new Size(162, 41);
            label3.TabIndex = 2;
            label3.Text = "FullName";
            // 
            // btnComfirm
            // 
            btnComfirm.Font = new Font("Microsoft JhengHei UI", 24F);
            btnComfirm.Location = new Point(234, 300);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(175, 56);
            btnComfirm.TabIndex = 3;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // txtFristName
            // 
            txtFristName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtFristName.Location = new Point(301, 36);
            txtFristName.Name = "txtFristName";
            txtFristName.Size = new Size(234, 48);
            txtFristName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtLastName.Location = new Point(301, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(234, 48);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(286, 187);
            label4.Name = "label4";
            label4.Size = new Size(260, 58);
            label4.TabIndex = 7;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(txtFristName);
            Controls.Add(btnComfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnComfirm;
        private TextBox txtFristName;
        private TextBox txtLastName;
        private Label label4;
    }
}
