
namespace CarRentingManagementWinApp_DOHOANGANH
{
    partial class frmCustomerManagement
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
            lbCustomerID = new System.Windows.Forms.Label();
            txtCustomerID = new System.Windows.Forms.TextBox();
            lbCustomerName = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            lbShortDescription = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            lbActors = new System.Windows.Forms.Label();
            txtActors = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCustomerList = new System.Windows.Forms.DataGridView();
            lbSearch = new System.Windows.Forms.Label();
            txtSearchValue = new System.Windows.Forms.TextBox();
            lbSearchCountry = new System.Windows.Forms.Label();
            cboCountry = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            grSearch = new System.Windows.Forms.GroupBox();
            radioByActor = new System.Windows.Forms.RadioButton();
            radioByProducer = new System.Windows.Forms.RadioButton();
            grFilter = new System.Windows.Forms.GroupBox();
            txtDuration = new System.Windows.Forms.TextBox();
            lbDurartion = new System.Windows.Forms.Label();
            txtProducer = new System.Windows.Forms.TextBox();
            lbProducer = new System.Windows.Forms.Label();
            txtCustomerType = new System.Windows.Forms.TextBox();
            lbCustomerType = new System.Windows.Forms.Label();
            txtLaunchDate = new System.Windows.Forms.TextBox();
            lbLaunchDate = new System.Windows.Forms.Label();
            txtDirector = new System.Windows.Forms.TextBox();
            lbDirector = new System.Windows.Forms.Label();
            CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TelePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new System.Drawing.Point(26, 30);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(73, 15);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID";
            lbCustomerID.Click += lbCustomerID_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(130, 27);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(184, 23);
            txtCustomerID.TabIndex = 1;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(26, 71);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(94, 15);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(130, 68);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(184, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(26, 111);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(67, 15);
            lbShortDescription.TabIndex = 4;
            lbShortDescription.Text = "Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(130, 109);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new System.Drawing.Size(184, 23);
            txtShortDescription.TabIndex = 5;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new System.Drawing.Point(380, 71);
            lbActors.Name = "lbActors";
            lbActors.Size = new System.Drawing.Size(41, 15);
            lbActors.TabIndex = 8;
            lbActors.Text = "Actors";
            // 
            // txtActors
            // 
            txtActors.Location = new System.Drawing.Point(446, 68);
            txtActors.Name = "txtActors";
            txtActors.Size = new System.Drawing.Size(184, 23);
            txtActors.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(380, 112);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(50, 15);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(446, 109);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(184, 23);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(61, 148);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(109, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(290, 149);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(109, 23);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(521, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(109, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CustomerID, CustomerName, TelePhone, CustomerEmail, CustomerBirthday, CustomerStatus });
            dgvCustomerList.Location = new System.Drawing.Point(26, 297);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.RowTemplate.Height = 25;
            dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerList.Size = new System.Drawing.Size(951, 200);
            dgvCustomerList.TabIndex = 15;
            dgvCustomerList.CellDoubleClick += dgvCustomerList_CellDoubleClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(24, 24);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(88, 21);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(320, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new System.Drawing.Point(34, 35);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new System.Drawing.Size(50, 15);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.Location = new System.Drawing.Point(101, 33);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(286, 23);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(298, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByActor);
            grSearch.Controls.Add(radioByProducer);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(25, 191);
            grSearch.Name = "grSearch";
            grSearch.Size = new System.Drawing.Size(434, 89);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            grSearch.Enter += grSearch_Enter;
            // 
            // radioByActor
            // 
            radioByActor.AutoSize = true;
            radioByActor.Checked = true;
            radioByActor.Location = new System.Drawing.Point(36, 56);
            radioByActor.Name = "radioByActor";
            radioByActor.Size = new System.Drawing.Size(70, 19);
            radioByActor.TabIndex = 23;
            radioByActor.TabStop = true;
            radioByActor.Text = "By Actor";
            radioByActor.UseVisualStyleBackColor = true;
            // 
            // radioByProducer
            // 
            radioByProducer.AutoSize = true;
            radioByProducer.Location = new System.Drawing.Point(142, 56);
            radioByProducer.Name = "radioByProducer";
            radioByProducer.Size = new System.Drawing.Size(89, 19);
            radioByProducer.TabIndex = 22;
            radioByProducer.TabStop = true;
            radioByProducer.Text = "By Producer";
            radioByProducer.UseVisualStyleBackColor = true;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new System.Drawing.Point(543, 196);
            grFilter.Name = "grFilter";
            grFilter.Size = new System.Drawing.Size(433, 84);
            grFilter.TabIndex = 23;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // txtDuration
            // 
            txtDuration.Location = new System.Drawing.Point(793, 108);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new System.Drawing.Size(184, 23);
            txtDuration.TabIndex = 29;
            // 
            // lbDurartion
            // 
            lbDurartion.AutoSize = true;
            lbDurartion.Location = new System.Drawing.Point(689, 111);
            lbDurartion.Name = "lbDurartion";
            lbDurartion.Size = new System.Drawing.Size(53, 15);
            lbDurartion.TabIndex = 28;
            lbDurartion.Text = "Duration";
            // 
            // txtProducer
            // 
            txtProducer.Location = new System.Drawing.Point(793, 68);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new System.Drawing.Size(184, 23);
            txtProducer.TabIndex = 27;
            // 
            // lbProducer
            // 
            lbProducer.AutoSize = true;
            lbProducer.Location = new System.Drawing.Point(689, 70);
            lbProducer.Name = "lbProducer";
            lbProducer.Size = new System.Drawing.Size(55, 15);
            lbProducer.TabIndex = 26;
            lbProducer.Text = "Producer";
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new System.Drawing.Point(793, 26);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new System.Drawing.Size(184, 23);
            txtCustomerType.TabIndex = 25;
            // 
            // lbCustomerType
            // 
            lbCustomerType.AutoSize = true;
            lbCustomerType.Location = new System.Drawing.Point(689, 29);
            lbCustomerType.Name = "lbCustomerType";
            lbCustomerType.Size = new System.Drawing.Size(85, 15);
            lbCustomerType.TabIndex = 24;
            lbCustomerType.Text = "Customer type";
            // 
            // txtLaunchDate
            // 
            txtLaunchDate.Location = new System.Drawing.Point(793, 150);
            txtLaunchDate.Name = "txtLaunchDate";
            txtLaunchDate.Size = new System.Drawing.Size(184, 23);
            txtLaunchDate.TabIndex = 31;
            // 
            // lbLaunchDate
            // 
            lbLaunchDate.AutoSize = true;
            lbLaunchDate.Location = new System.Drawing.Point(689, 153);
            lbLaunchDate.Name = "lbLaunchDate";
            lbLaunchDate.Size = new System.Drawing.Size(73, 15);
            lbLaunchDate.TabIndex = 30;
            lbLaunchDate.Text = "Launch Date";
            lbLaunchDate.Click += label4_Click;
            // 
            // txtDirector
            // 
            txtDirector.Location = new System.Drawing.Point(446, 28);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new System.Drawing.Size(184, 23);
            txtDirector.TabIndex = 33;
            // 
            // lbDirector
            // 
            lbDirector.AutoSize = true;
            lbDirector.Location = new System.Drawing.Point(380, 29);
            lbDirector.Name = "lbDirector";
            lbDirector.Size = new System.Drawing.Size(49, 15);
            lbDirector.TabIndex = 32;
            lbDirector.Text = "Director";
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Id";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 30;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // TelePhone
            // 
            TelePhone.HeaderText = "Phone";
            TelePhone.Name = "TelePhone";
            TelePhone.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            CustomerEmail.HeaderText = "Email";
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.ReadOnly = true;
            // 
            // CustomerBirthday
            // 
            CustomerBirthday.HeaderText = "Birthday";
            CustomerBirthday.Name = "CustomerBirthday";
            CustomerBirthday.ReadOnly = true;
            // 
            // CustomerStatus
            // 
            CustomerStatus.HeaderText = "Status";
            CustomerStatus.Name = "CustomerStatus";
            CustomerStatus.ReadOnly = true;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 509);
            Controls.Add(txtDirector);
            Controls.Add(lbDirector);
            Controls.Add(txtLaunchDate);
            Controls.Add(lbLaunchDate);
            Controls.Add(txtDuration);
            Controls.Add(lbDurartion);
            Controls.Add(txtProducer);
            Controls.Add(lbProducer);
            Controls.Add(txtCustomerType);
            Controls.Add(lbCustomerType);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtActors);
            Controls.Add(lbActors);
            Controls.Add(txtShortDescription);
            Controls.Add(lbShortDescription);
            Controls.Add(txtCustomerName);
            Controls.Add(lbCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lbCustomerID);
            Name = "frmCustomerManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customer Management";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lbActors;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByProducer;
        private System.Windows.Forms.RadioButton radioByActor;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lbDurartion;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lbProducer;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.TextBox txtLaunchDate;
        private System.Windows.Forms.Label lbLaunchDate;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerStatus;
    }
}