namespace Forms
{
    partial class SaveUserData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.accountno = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.adddata = new System.Windows.Forms.Button();
            this.exitapplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AccountNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "location";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(253, 38);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(282, 22);
            this.customername.TabIndex = 4;
            // 
            // accountno
            // 
            this.accountno.Location = new System.Drawing.Point(253, 81);
            this.accountno.Name = "accountno";
            this.accountno.Size = new System.Drawing.Size(282, 22);
            this.accountno.TabIndex = 5;
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(253, 128);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(282, 22);
            this.customerid.TabIndex = 6;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(253, 181);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(282, 22);
            this.location.TabIndex = 7;
            // 
            // adddata
            // 
            this.adddata.Location = new System.Drawing.Point(23, 296);
            this.adddata.Name = "adddata";
            this.adddata.Size = new System.Drawing.Size(183, 23);
            this.adddata.TabIndex = 8;
            this.adddata.Text = "ADD";
            this.adddata.UseVisualStyleBackColor = true;
            this.adddata.Click += new System.EventHandler(this.adddata_Click);
            // 
            // exitapplication
            // 
            this.exitapplication.Location = new System.Drawing.Point(592, 305);
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(196, 23);
            this.exitapplication.TabIndex = 9;
            this.exitapplication.Text = "exit";
            this.exitapplication.UseVisualStyleBackColor = true;
            this.exitapplication.Click += new System.EventHandler(this.exitapplication_Click);
            // 
            // SaveUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitapplication);
            this.Controls.Add(this.adddata);
            this.Controls.Add(this.location);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.accountno);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.TextBox accountno;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button adddata;
        private System.Windows.Forms.Button exitapplication;
    }
}

