namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createNewList();

        }
        int tasksCount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void createNewList()
        {
            TextBoxUC tb = new TextBoxUC();
            CheckboxUC cb = new CheckboxUC();
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.Controls.Add(cb, 0, 0);
            tableLayoutPanel1.Controls.Add(tb, 1, 0);
            tasksCount++;
        }
        private void addTask()
        {
            TextBoxUC tb = new TextBoxUC();
            CheckboxUC cb = new CheckboxUC();
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.Controls.Add(cb, 0, tasksCount);
            tableLayoutPanel1.Controls.Add(tb, 1, tasksCount);
            tasksCount++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTask();
        }
    }
}
