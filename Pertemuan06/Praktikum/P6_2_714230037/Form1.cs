namespace P6_2_714230037
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName.ToString();
                    MessageBox.Show(
                        $"You successfully opened: '{filePath}' ",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }
                else
                {
                    MessageBox.Show(
                        "You cenceled the open file operation",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(),
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
            }
        }
    }
}
