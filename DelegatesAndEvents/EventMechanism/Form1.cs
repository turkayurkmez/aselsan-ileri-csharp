namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CategoryService categoryService = new CategoryService();
        private void buttonDandik_KeyDown(object sender, KeyEventArgs e)
        {
            var randomizer = new Random();
            var anonim = new { Color = "Red", Info = "Bu nesnenin sınıfı yok!" };
            

        }

        private void common_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Red;

            if (button.Tag != null && button.Tag.ToString() == "Check")
            {
                MessageBox.Show("Checked....");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            categoryService.CategoryAdded += CategoryService_CategoryAdded;

            categoryService.CreateNewCategory(new Category { Name = "Beverages" });
        }

        private void CategoryService_CategoryAdded(object sender, CategoryCreatedEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} kategorisi, {e.CreatedTime.ToString()} tarihinde eklendi");
        }
    }
}
