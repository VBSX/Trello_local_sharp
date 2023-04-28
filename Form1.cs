using Trello_local_sharp.database_handle;
namespace Trello_local_sharp
{
    public partial class Form1 : Form
    {
        private readonly database_get databaseHandle;
        public Form1()
        {
            InitializeComponent();
            databaseHandle = new database_get();
            construct_all_tasks();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void construct_all_tasks()
        {
            contruct_task_new();
        }
        private void contruct_task_new()
        {

            var items = databaseHandle.GetItemsOfList("1");
            for (int i = 0; i < items.Length; i++)
            {
                listBox_status_new.Items.Add(items[i]);
            }
        }
    }
}