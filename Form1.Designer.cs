namespace testsqlperformance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tQuery = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // tServer
            // 
            this.tServer.Location = new System.Drawing.Point(57, 26);
            this.tServer.Name = "tServer";
            this.tServer.Size = new System.Drawing.Size(329, 20);
            this.tServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            // 
            // tDB
            // 
            this.tDB.Location = new System.Drawing.Point(57, 52);
            this.tDB.Name = "tDB";
            this.tDB.Size = new System.Drawing.Size(329, 20);
            this.tDB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DB";
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(57, 78);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(329, 20);
            this.tUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pass";
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(57, 104);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(329, 20);
            this.tPass.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Query";
            // 
            // tQuery
            // 
            this.tQuery.Location = new System.Drawing.Point(57, 130);
            this.tQuery.Multiline = true;
            this.tQuery.Name = "tQuery";
            this.tQuery.Size = new System.Drawing.Size(329, 68);
            this.tQuery.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Result";
            // 
            // tResult
            // 
            this.tResult.Location = new System.Drawing.Point(57, 204);
            this.tResult.Multiline = true;
            this.tResult.Name = "tResult";
            this.tResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tResult.Size = new System.Drawing.Size(329, 237);
            this.tResult.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time";
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(57, 447);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(329, 20);
            this.tTime.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tResult);
            this.Controls.Add(this.tQuery);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tTime;
    }
}

