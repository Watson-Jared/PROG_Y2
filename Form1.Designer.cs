namespace MarkCaptureSystem
{
    partial class markCaptureSystem
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
            name = new Label();
            test1 = new Label();
            test2 = new Label();
            final = new Label();
            txtName = new TextBox();
            txtTest1 = new TextBox();
            txtTest2 = new TextBox();
            txtFinal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnRead = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(20, 128);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // test1
            // 
            test1.AutoSize = true;
            test1.Location = new Point(20, 171);
            test1.Name = "test1";
            test1.Size = new Size(34, 15);
            test1.TabIndex = 1;
            test1.Text = "Test1";
            test1.Click += label2_Click;
            // 
            // test2
            // 
            test2.AutoSize = true;
            test2.Location = new Point(20, 211);
            test2.Name = "test2";
            test2.Size = new Size(34, 15);
            test2.TabIndex = 2;
            test2.Text = "Test2";
            // 
            // final
            // 
            final.AutoSize = true;
            final.Location = new Point(20, 253);
            final.Name = "final";
            final.Size = new Size(32, 15);
            final.TabIndex = 3;
            final.Text = "Final";
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtTest1
            // 
            txtTest1.Location = new Point(77, 163);
            txtTest1.Name = "txtTest1";
            txtTest1.Size = new Size(100, 23);
            txtTest1.TabIndex = 5;
            // 
            // txtTest2
            // 
            txtTest2.Location = new Point(77, 203);
            txtTest2.Name = "txtTest2";
            txtTest2.Size = new Size(100, 23);
            txtTest2.TabIndex = 6;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(77, 245);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(100, 23);
            txtFinal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(196, 125);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(196, 207);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(196, 245);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 11;
            btnRead.Text = "&Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(311, 47);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 20;
            label1.Text = "Emeris University";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.Click += label1_Click;
            // 
            // markCaptureSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtFinal);
            Controls.Add(txtTest2);
            Controls.Add(txtTest1);
            Controls.Add(txtName);
            Controls.Add(final);
            Controls.Add(test2);
            Controls.Add(test1);
            Controls.Add(name);
            Name = "markCaptureSystem";
            Text = "Mark Capture System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label test1;
        private Label test2;
        private Label final;
        private TextBox txtName;
        private TextBox txtTest1;
        private TextBox txtTest2;
        private TextBox txtFinal;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnSave;
        private Button btnRead;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
