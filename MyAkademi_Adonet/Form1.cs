using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAkademi_Adonet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=DESKTOP-RO7ES1P;initial Catalog=DbMyPortfolio;integrated Security=true");

		private void btnList_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Select*From Project", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("insert into Project (Title,Description,ProjectCategory,CompleteDay,Price) values(@p1,@p2,@p3,@p4,@p5)",connection);
			command.Parameters.AddWithValue("@p1", txtTitle.Text);
			command.Parameters.AddWithValue("@p2", rchDetail.Text);
			command.Parameters.AddWithValue("@p3", cmbCategory.Text);
			command.Parameters.AddWithValue("@p4", txtProcessValue.Text);
			command.Parameters.AddWithValue("@p5", txtPrice.Text);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Başarıyla Eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Delete From Project Where ProjectID=@p1", connection);
			command.Parameters.AddWithValue("@p1", txtID.Text);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Silindi");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Update Project Set Title=@p1,Description=@p2,ProjectCategory=@p3,CompleteDay=@p4,Price=@p5 where ProjectID=@p6",connection);
			command.Parameters.AddWithValue("@p1", txtTitle.Text);
			command.Parameters.AddWithValue("@p2", rchDetail.Text);
			command.Parameters.AddWithValue("@p3", cmbCategory.Text);
			command.Parameters.AddWithValue("@p4", txtProcessValue.Text);
			command.Parameters.AddWithValue("@p5", txtPrice.Text);
			command.Parameters.AddWithValue("@p6", txtID.Text);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Select*From Project Where Title=@p1", connection);
			command.Parameters.AddWithValue("@p1", txtTitle.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Select*From Category", connection);
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryID";
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			cmbCategory.DataSource = dt;
			connection.Close();
		}
	}
}
