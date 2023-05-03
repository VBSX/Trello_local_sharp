using SQLitePCL;
using System.Windows.Forms;
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
            configure_list_box();
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

            for (int i = 0; i < items.Count; i++)
            {

                string item_title = items[i][0];
                string description_title = items[i][1];
                string final_item = item_title + '\n' + description_title;
                listBox_status_new.Items.Add(final_item);

            }
            listBox_status_new.DrawMode = DrawMode.OwnerDrawFixed; // define o modo de desenho para OwnerDrawFixed
            listBox_status_new.DrawItem += listBox_status_new_DrawItem;
        }
        private void listBox_status_new_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            var listBox = sender as ListBox;
            var item = listBox.Items[e.Index].ToString().Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            e.DrawBackground();

            var itemFont = new Font(FontFamily.GenericSansSerif, 10.0f);
            var titleBrush = new SolidBrush(Color.Black);
            var descriptionBrush = new SolidBrush(Color.Gray);

            var titleRect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height / 2);
            var descriptionRect = new Rectangle(e.Bounds.X, e.Bounds.Y + e.Bounds.Height / 2, e.Bounds.Width, e.Bounds.Height / 2);

            e.Graphics.DrawString(item[0], itemFont, titleBrush, titleRect);
            e.Graphics.DrawString(item[1], itemFont, descriptionBrush, descriptionRect);

            e.DrawFocusRectangle();
        }
        private void configure_list_box()
        {
            listBox_status_new.IntegralHeight = false;
            listBox_status_new.HorizontalScrollbar = false;
            int maxWidth = 0;
            foreach (var item in listBox_status_new.Items)
            {
                var size = TextRenderer.MeasureText(item.ToString(), listBox_status_new.Font);
                if (size.Width > maxWidth)
                {
                    maxWidth = size.Width;
                }
            }
            listBox_status_new.Width = maxWidth + 10; // adiciona um pequeno espaço extra
        }
    }

    }
}