using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-N403R9E\\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                comboBox1.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, price FROM products";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string productInfo = $"{reader["name"]} - {reader["price"]} руб.";
                        comboBox1.Items.Add(productInfo);
                    }
                    reader.Close();
                }

                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listAddProducts.Items.Add(comboBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите продукт из списка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listAddProducts.Items.Clear();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var item in listAddProducts.Items)
            {
                string itemString = item.ToString();
                // Извлекаем цену из строки формата "Название - цена руб."
                int lastDashIndex = itemString.LastIndexOf('-');
                if (lastDashIndex != -1)
                {
                    string priceString = itemString.Substring(lastDashIndex + 1)
                        .Replace("руб.", "")
                        .Trim();

                    if (decimal.TryParse(priceString, out decimal price))
                    {
                        total += price;
                    }
                }
            }
            textBox1.Text = $"{total:F2} руб.";
        }
    }
}
