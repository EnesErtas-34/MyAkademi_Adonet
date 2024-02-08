
namespace MyAkademi_Adonet
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
			this.btnList = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProcessValue = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rchDetail = new System.Windows.Forms.RichTextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(12, 12);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(146, 35);
			this.btnList.TabIndex = 0;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 53);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(146, 35);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Ekle";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(12, 94);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(146, 35);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(12, 135);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(146, 35);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(12, 176);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(146, 35);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Getir";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 217);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(863, 229);
			this.dataGridView1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(193, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Proje Başlığı:";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(289, 18);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(157, 22);
			this.txtTitle.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(218, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Kategori:";
			// 
			// txtProcessValue
			// 
			this.txtProcessValue.Location = new System.Drawing.Point(289, 76);
			this.txtProcessValue.Name = "txtProcessValue";
			this.txtProcessValue.Size = new System.Drawing.Size(157, 22);
			this.txtProcessValue.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Tamamlama Oranı:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(289, 104);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(157, 22);
			this.txtPrice.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(241, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Fiyat:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(492, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "Proje Detayları:";
			// 
			// rchDetail
			// 
			this.rchDetail.Location = new System.Drawing.Point(495, 46);
			this.rchDetail.Name = "rchDetail";
			this.rchDetail.Size = new System.Drawing.Size(380, 150);
			this.rchDetail.TabIndex = 15;
			this.rchDetail.Text = "";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(289, 46);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(157, 24);
			this.cmbCategory.TabIndex = 16;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(289, 141);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(157, 22);
			this.txtID.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(218, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Proje ID:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.rchDetail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProcessValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProcessValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox rchDetail;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label6;
	}
}

