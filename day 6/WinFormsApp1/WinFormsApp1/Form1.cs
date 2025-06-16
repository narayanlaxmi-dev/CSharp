namespace WinFormsApp1
{
    public partial class FormFirst : Form
    {
        public FormFirst()
        {
            InitializeComponent();
        }
         // await async help to asynchornous application
         // mark async
        private  void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Uploading...";
          
            
            // await async process
            //await TimeTakingProcess();

            label1.Text = "Upload Completed...";
            button1.Text = "Upload Completed";
           
        }

        private async Task TimeTakingProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
