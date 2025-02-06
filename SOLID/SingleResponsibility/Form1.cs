using Microsoft.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        /*
         * Prensip diyor ki:
         * Bir sınıfın sadece bir sorumluluğu olmalıdır.
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var productService = new ProductService();
            var result = productService.CreateProduct(name, price);

            string message = result > 0 ? "Ürün eklendi" : "Ürün eklenemedi";
            MessageBox.Show(message);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }

        //int createProduct(string name, decimal price)
        //{
        //    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, UnitPrice) VALUES (@name, @price)", connection);
        //    cmd.Parameters.AddWithValue("@name", name);
        //    cmd.Parameters.AddWithValue("@price", price);
        //    connection.Open();
        //    var result = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    return result;
        //}
    }
}
