namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        UserControl3 button;
        public Form1()
        {
            InitializeComponent();
            
            button = new UserControl3(this);

            createNewList();
        }

        
        int tasksCount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void createNewList()
        {
            tableLayoutPanel1.Controls.Add(button,0,0);
            tasksCount++;
        }
        public void addTask()
        {
            tableLayoutPanel1.SetRow(button, tasksCount + 1);
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

    }
}
