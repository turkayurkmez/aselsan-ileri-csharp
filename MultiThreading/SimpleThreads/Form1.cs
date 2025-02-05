namespace SimpleThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonSenkronStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                labelSyncCounter.Text = i.ToString();
            }
        }

        Thread thread = null;
        private void buttonAsyncStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(() => asyncCounter());

            thread.Start();

            // thread.Join();

            MessageBox.Show("Bu mesaja dikkat");
        }

        void asyncCounter()
        {
            for (int i = 0; i < 100000; i++)
            {
                labelAsyncCounter.Text = i.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //thread.Abort();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => counter());

            MessageBox.Show("Bu mesaja dikkat");
        }

        async Task counter()
        {
            for (int i = 0; i < 100000; i++)
            {
                labelTask.Text = i.ToString();

                progressBar1.Value = (int)(i / 1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Invoke(new Action(() =>
            {
                listBox1.Items.Add("Item 1");
                listBox1.Items.Add("Item 2");
                listBox1.Items.Add("Item 3");
                listBox1.Items.Add("Item 4");
                listBox1.Items.Add("Item 5");
            }));

           var result = listBox1.BeginInvoke(new Action(() =>
            {
                listBox1.Items.Add("Item 6");
                listBox1.Items.Add("Item 7");
                listBox1.Items.Add("Item 8");
                listBox1.Items.Add("Item 9");
                listBox1.Items.Add("Item 10");
            }));

            result.AsyncWaitHandle.WaitOne();
        }
    }
}
