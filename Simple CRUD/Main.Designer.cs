namespace Simple_CRUD
{
    partial class Main
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            txt_firstname = new System.Windows.Forms.TextBox();
            txt_lastname = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txt_address = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btn_blazor = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new System.Drawing.Size(711, 243);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += GetIdToDelete;
            dataGridView1.CellDoubleClick += Edit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 41);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 18);
            label1.TabIndex = 8;
            label1.Text = "Firstname: ";
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_firstname.Location = new System.Drawing.Point(30, 61);
            txt_firstname.Margin = new System.Windows.Forms.Padding(2);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new System.Drawing.Size(222, 26);
            txt_firstname.TabIndex = 9;
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_lastname.Location = new System.Drawing.Point(277, 61);
            txt_lastname.Margin = new System.Windows.Forms.Padding(2);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new System.Drawing.Size(222, 26);
            txt_lastname.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(277, 41);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 18);
            label2.TabIndex = 10;
            label2.Text = "Lastname :";
            // 
            // txt_address
            // 
            txt_address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_address.Location = new System.Drawing.Point(529, 61);
            txt_address.Margin = new System.Windows.Forms.Padding(2);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(222, 26);
            txt_address.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(529, 41);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 18);
            label3.TabIndex = 12;
            label3.Text = "Address:";
            // 
            // btn_blazor
            // 
            btn_blazor.Location = new System.Drawing.Point(655, 406);
            btn_blazor.Margin = new System.Windows.Forms.Padding(2);
            btn_blazor.Name = "btn_blazor";
            btn_blazor.Size = new System.Drawing.Size(100, 41);
            btn_blazor.TabIndex = 17;
            btn_blazor.Text = "BLAZOR";
            btn_blazor.UseVisualStyleBackColor = true;
            btn_blazor.Click += btn_blazor_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(30, 107);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(725, 277);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(717, 249);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DataGridView";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(blazorWebView1);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(717, 249);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Blazor View";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // blazorWebView1
            // 
            blazorWebView1.Location = new System.Drawing.Point(274, 125);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new System.Drawing.Size(75, 23);
            blazorWebView1.TabIndex = 0;
            blazorWebView1.Text = "blazorWebView1";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(776, 477);
            Controls.Add(tabControl1);
            Controls.Add(btn_blazor);
            Controls.Add(txt_address);
            Controls.Add(label3);
            Controls.Add(txt_lastname);
            Controls.Add(label2);
            Controls.Add(txt_firstname);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_blazor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
    }
}

