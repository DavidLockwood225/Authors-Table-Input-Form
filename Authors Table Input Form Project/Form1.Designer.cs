
namespace Authors_Table_Input_Form_Project
{
    partial class frmPublishers
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPubAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPubZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPubTelephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPubFAX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPubComments = new System.Windows.Forms.TextBox();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher ID";
            // 
            // txtPubID
            // 
            this.txtPubID.BackColor = System.Drawing.Color.White;
            this.txtPubID.Location = new System.Drawing.Point(142, 23);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.ReadOnly = true;
            this.txtPubID.Size = new System.Drawing.Size(151, 20);
            this.txtPubID.TabIndex = 1;
            this.txtPubID.TabStop = false;
            this.txtPubID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtPubName
            // 
            this.txtPubName.BackColor = System.Drawing.Color.White;
            this.txtPubName.Location = new System.Drawing.Point(142, 50);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.ReadOnly = true;
            this.txtPubName.Size = new System.Drawing.Size(297, 20);
            this.txtPubName.TabIndex = 1;
            this.txtPubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(142, 77);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(297, 20);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.Text = " ";
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(142, 309);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(106, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(286, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(93, 367);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(333, 367);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(106, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // txtPubAddress
            // 
            this.txtPubAddress.BackColor = System.Drawing.Color.White;
            this.txtPubAddress.Location = new System.Drawing.Point(142, 104);
            this.txtPubAddress.Name = "txtPubAddress";
            this.txtPubAddress.ReadOnly = true;
            this.txtPubAddress.Size = new System.Drawing.Size(297, 20);
            this.txtPubAddress.TabIndex = 3;
            this.txtPubAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "City";
            // 
            // txtPubCity
            // 
            this.txtPubCity.BackColor = System.Drawing.Color.White;
            this.txtPubCity.Location = new System.Drawing.Point(142, 130);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.ReadOnly = true;
            this.txtPubCity.Size = new System.Drawing.Size(297, 20);
            this.txtPubCity.TabIndex = 4;
            this.txtPubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "State";
            // 
            // txtPubState
            // 
            this.txtPubState.BackColor = System.Drawing.Color.White;
            this.txtPubState.Location = new System.Drawing.Point(142, 157);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.ReadOnly = true;
            this.txtPubState.Size = new System.Drawing.Size(198, 20);
            this.txtPubState.TabIndex = 6;
            this.txtPubState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zip";
            // 
            // txtPubZip
            // 
            this.txtPubZip.BackColor = System.Drawing.Color.White;
            this.txtPubZip.Location = new System.Drawing.Point(142, 184);
            this.txtPubZip.Name = "txtPubZip";
            this.txtPubZip.ReadOnly = true;
            this.txtPubZip.Size = new System.Drawing.Size(198, 20);
            this.txtPubZip.TabIndex = 6;
            this.txtPubZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telephone";
            // 
            // txtPubTelephone
            // 
            this.txtPubTelephone.BackColor = System.Drawing.Color.White;
            this.txtPubTelephone.Location = new System.Drawing.Point(142, 211);
            this.txtPubTelephone.Name = "txtPubTelephone";
            this.txtPubTelephone.ReadOnly = true;
            this.txtPubTelephone.Size = new System.Drawing.Size(198, 20);
            this.txtPubTelephone.TabIndex = 7;
            this.txtPubTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "FAX";
            // 
            // txtPubFAX
            // 
            this.txtPubFAX.BackColor = System.Drawing.Color.White;
            this.txtPubFAX.Location = new System.Drawing.Point(142, 238);
            this.txtPubFAX.Name = "txtPubFAX";
            this.txtPubFAX.ReadOnly = true;
            this.txtPubFAX.Size = new System.Drawing.Size(198, 20);
            this.txtPubFAX.TabIndex = 8;
            this.txtPubFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Comments";
            // 
            // txtPubComments
            // 
            this.txtPubComments.BackColor = System.Drawing.Color.White;
            this.txtPubComments.Location = new System.Drawing.Point(142, 265);
            this.txtPubComments.Name = "txtPubComments";
            this.txtPubComments.ReadOnly = true;
            this.txtPubComments.Size = new System.Drawing.Size(297, 20);
            this.txtPubComments.TabIndex = 9;
            this.txtPubComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(333, 397);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(106, 23);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 446);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtPubComments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPubFAX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPubTelephone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPubZip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPubAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.txtPubID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpPublishers.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "frmPublishers";
            this.hlpPublishers.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPubAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPubCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPubState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPubZip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPubTelephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPubFAX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPubComments;
        private System.Windows.Forms.HelpProvider hlpPublishers;
        private System.Windows.Forms.Button btnHelp;
    }
}

