namespace Descartin_LabAct3rd
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
            txtPatientName = new TextBox();
            label1 = new Label();
            txtPatientAge = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPatientType = new ComboBox();
            txtReason = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAddQueue = new Button();
            btnClear = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtQueueNumber = new TextBox();
            txtOutputPatientType = new TextBox();
            txtExpectedPriority = new TextBox();
            SuspendLayout();
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(107, 56);
            txtPatientName.Multiline = true;
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(166, 29);
            txtPatientName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 62);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Patient Name";
            // 
            // txtPatientAge
            // 
            txtPatientAge.Location = new Point(107, 98);
            txtPatientAge.Name = "txtPatientAge";
            txtPatientAge.Size = new Size(79, 23);
            txtPatientAge.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 98);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Patient Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Reason For Visit";
            label3.Click += label3_Click;
            // 
            // cmbPatientType
            // 
            cmbPatientType.FormattingEnabled = true;
            cmbPatientType.Items.AddRange(new object[] { "Emergency ", "Senior ", "Pregnant", "Regular" });
            cmbPatientType.Location = new Point(107, 181);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(136, 23);
            cmbPatientType.TabIndex = 5;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(107, 143);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(136, 23);
            txtReason.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 181);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Patient Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 17);
            label5.Name = "label5";
            label5.Size = new Size(304, 21);
            label5.TabIndex = 8;
            label5.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // btnAddQueue
            // 
            btnAddQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQueue.Location = new Point(107, 231);
            btnAddQueue.Name = "btnAddQueue";
            btnAddQueue.Size = new Size(105, 31);
            btnAddQueue.TabIndex = 9;
            btnAddQueue.Text = "ADD TO QUEUE";
            btnAddQueue.UseVisualStyleBackColor = true;
            btnAddQueue.Click += btnAddQueue_Click;

            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(237, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 32);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 17);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 11;
            label6.Text = " QUEUE RESULT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(406, 62);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 12;
            label7.Text = "Queue Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(423, 106);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 13;
            label8.Text = "Patient Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(399, 151);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 14;
            label9.Text = "Expected Priority";
            // 
            // txtQueueNumber
            // 
            txtQueueNumber.Location = new Point(501, 52);
            txtQueueNumber.Multiline = true;
            txtQueueNumber.Name = "txtQueueNumber";
            txtQueueNumber.Size = new Size(166, 33);
            txtQueueNumber.TabIndex = 15;
            // 
            // txtOutputPatientType
            // 
            txtOutputPatientType.Location = new Point(501, 98);
            txtOutputPatientType.Multiline = true;
            txtOutputPatientType.Name = "txtOutputPatientType";
            txtOutputPatientType.Size = new Size(166, 33);
            txtOutputPatientType.TabIndex = 16;
            // 
            // txtExpectedPriority
            // 
            txtExpectedPriority.Location = new Point(501, 143);
            txtExpectedPriority.Multiline = true;
            txtExpectedPriority.Name = "txtExpectedPriority";
            txtExpectedPriority.Size = new Size(166, 33);
            txtExpectedPriority.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtExpectedPriority);
            Controls.Add(txtOutputPatientType);
            Controls.Add(txtQueueNumber);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAddQueue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtReason);
            Controls.Add(cmbPatientType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPatientAge);
            Controls.Add(label1);
            Controls.Add(txtPatientName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPatientName;
        private Label label1;
        private TextBox txtPatientAge;
        private Label label2;
        private Label label3;
        private ComboBox cmbPatientType;
        private TextBox txtReason;
        private Label label4;
        private Label label5;
        private Button btnAddQueue;
        private Button btnClear;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtQueueNumber;
        private TextBox txtOutputPatientType;
        private TextBox txtExpectedPriority;
    }
}
