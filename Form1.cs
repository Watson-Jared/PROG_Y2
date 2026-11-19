namespace MarkCaptureSystem
{
    public partial class markCaptureSystem : Form
    {
        public markCaptureSystem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int t1 = 0;
            int t2 = 0;
            string name = txtName.Text;



            try
            {
                t1 = int.Parse(txtTest1.Text);
                t2 = int.Parse(txtTest2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for Test1, Test2, and Final.");
                return;
            }

            Student student = new Student(name, t1, t2);

            txtFinal.Text = student.CalculateFinal().ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTest1.Clear();
            txtTest2.Clear();
            txtFinal.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string test1 = txtTest1.Text;
            string test2 = txtTest2.Text;
            string final = txtFinal.Text;
            int t1 = 0;
            int t2 = 0;


            try
            {
                t1 = int.Parse(txtTest1.Text);
                t2 = int.Parse(txtTest2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for Test1, Test2, and Final.");
                return;
            }

            Student student = new Student(name, t1, t2);
            student.CalculateFinal();

            try
            {
                student.writeTo();
            }
            catch (FormatException)
            {
                MessageBox.Show("An error occurred while saving the student data."); return;
            }


            txtName.Clear();
            txtTest1.Clear();
            txtTest2.Clear();
            txtFinal.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Students.txt");
                String line = sr.ReadLine();

                string[] token = line.Split(',');
                txtName.Text = token[0];
                txtTest1.Text = token[1];
                txtTest2.Text = token[2];
                txtFinal.Text = token[3];
            }
            catch
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
