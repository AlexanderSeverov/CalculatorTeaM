namespace CalculatorTeaM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Indication = new System.Windows.Forms.TextBox();
            this.btn_Start_Test = new System.Windows.Forms.Button();
            this.tb_Test = new System.Windows.Forms.TextBox();
            this.lbl_Test1 = new System.Windows.Forms.Label();
            this.btn_Finish_Test = new System.Windows.Forms.Button();
            this.lbl_Test2 = new System.Windows.Forms.Label();
            this.lbl_History = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Indication
            // 
            this.lbl_Indication.Location = new System.Drawing.Point(12, 12);
            this.lbl_Indication.Name = "lbl_Indication";
            this.lbl_Indication.Size = new System.Drawing.Size(266, 20);
            this.lbl_Indication.TabIndex = 0;
            // 
            // btn_Start_Test
            // 
            this.btn_Start_Test.Location = new System.Drawing.Point(12, 396);
            this.btn_Start_Test.Name = "btn_Start_Test";
            this.btn_Start_Test.Size = new System.Drawing.Size(101, 23);
            this.btn_Start_Test.TabIndex = 1;
            this.btn_Start_Test.Text = "Режим теста";
            this.btn_Start_Test.UseVisualStyleBackColor = true;
            this.btn_Start_Test.Click += new System.EventHandler(this.button1_Click);
            
            // 
            // tb_Test
            // 
            this.tb_Test.Location = new System.Drawing.Point(12, 425);
            this.tb_Test.Multiline = true;
            this.tb_Test.Name = "tb_Test";
            this.tb_Test.ReadOnly = true;
            this.tb_Test.Size = new System.Drawing.Size(202, 33);
            this.tb_Test.TabIndex = 2;
            this.tb_Test.Text = "Понажимайте на кнопки для теста \r\nНиже отобразится татус прохождения";
            this.tb_Test.Visible = false;
            // 
            // lbl_Test1
            // 
            this.lbl_Test1.AutoSize = true;
            this.lbl_Test1.Location = new System.Drawing.Point(54, 459);
            this.lbl_Test1.Name = "lbl_Test1";
            this.lbl_Test1.Size = new System.Drawing.Size(40, 13);
            this.lbl_Test1.TabIndex = 3;
            this.lbl_Test1.Text = "waiting";
            this.lbl_Test1.Visible = false;
            // 
            // btn_Finish_Test
            // 
            this.btn_Finish_Test.Location = new System.Drawing.Point(12, 488);
            this.btn_Finish_Test.Name = "btn_Finish_Test";
            this.btn_Finish_Test.Size = new System.Drawing.Size(142, 23);
            this.btn_Finish_Test.TabIndex = 4;
            this.btn_Finish_Test.Text = "Выход из режима теста";
            this.btn_Finish_Test.UseVisualStyleBackColor = true;
            this.btn_Finish_Test.Visible = false;
            this.btn_Finish_Test.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Test2
            // 
            this.lbl_Test2.AutoSize = true;
            this.lbl_Test2.Location = new System.Drawing.Point(54, 472);
            this.lbl_Test2.Name = "lbl_Test2";
            this.lbl_Test2.Size = new System.Drawing.Size(40, 13);
            this.lbl_Test2.TabIndex = 12;
            this.lbl_Test2.Text = "waiting";
            this.lbl_Test2.Visible = false;
            // 
            // lbl_History
            // 
            this.lbl_History.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_History.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_History.Location = new System.Drawing.Point(284, 12);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(138, 23);
            this.lbl_History.TabIndex = 15;
            this.lbl_History.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 531);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.lbl_Test2);
            this.Controls.Add(this.btn_Finish_Test);
            this.Controls.Add(this.lbl_Test1);
            this.Controls.Add(this.tb_Test);
            this.Controls.Add(this.btn_Start_Test);
            this.Controls.Add(this.lbl_Indication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbl_Indication;
        private System.Windows.Forms.Button btn_Start_Test;
        private System.Windows.Forms.TextBox tb_Test;
        private System.Windows.Forms.Label lbl_Test1;
        private System.Windows.Forms.Button btn_Finish_Test;
        private System.Windows.Forms.Label lbl_Test2;
        private System.Windows.Forms.Label lbl_History;
    }
}

