namespace api_login_excercise.Forms
{
    partial class CallAPI
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(630, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(531, 55);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(94, 29);
            this.btnPut.TabIndex = 1;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(431, 55);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(94, 29);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(12, 53);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(94, 29);
            this.GetAll.TabIndex = 3;
            this.GetAll.Text = "GetAll";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 177);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(776, 261);
            this.txtResponse.TabIndex = 4;
            this.txtResponse.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(278, 123);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(125, 27);
            this.txtJob.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 7;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(131, 121);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(125, 29);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Job:";
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnDelete);
            this.Name = "CallAPI";
            this.Text = "CallAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}