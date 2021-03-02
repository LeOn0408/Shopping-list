using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_list
{
    public partial class Home : Form
    {
        
        Xml xml = new Xml();
        public Home()
        {
            
            xml = new Xml(this);
            InitializeComponent();
            createMenu();
            addText("Программа запущена");
        }
        public void createMenu()
        {
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            ToolStripMenuItem setup = new ToolStripMenuItem("Настройки");
            ToolStripMenuItem about = new ToolStripMenuItem("О программе");

            fileItem.DropDownItems.Add(setup);

            setup.Click += setup_Click;
            about.Click += about_Click;

            menuStrip1.Items.Add(fileItem);
            menuStrip1.Items.Add(about);
        }
        protected void setup_Click(object sender, EventArgs e)
        {

            
        }
        protected void about_Click(object sender, EventArgs e)
        {
            
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void create_Click(object sender, EventArgs e)
        {

        }
        public void addText(string text)
        {
            log.Clear();
            log.AppendText(text);
        }
        public void addProduct(string text, bool bought)
        {
            
            if (bought == true)
                list.SelectionColor = Color.Green;
            else
                list.SelectionColor = Color.Red;
            list.AppendText(text+"\n");
        }
        private void list_TextChanged(object sender, EventArgs e)
        {

        }
        private void openList_Click(object sender, EventArgs e)
        {
            list.Clear();//пока чистим. Далее прикрутить запрос про очистку после смены листа
            xml.loadXml();
            list.DoubleClick += List_DoubleClick;
        }
        private void List_DoubleClick(object sender, EventArgs e)
        {
            int charindex = list.GetFirstCharIndexOfCurrentLine();
            int nline = list.GetLineFromCharIndex(charindex);
            addText(list.Lines[nline]);
        }
        private void add_Click(object sender, EventArgs e)
        {
            string add;
            int count = xml.getCount() + 1;
            string checkList = list.Text;//проверка на загруженный список
            add = addPosition.Text;
            add = add.Trim();//чистим от пробелов
            if (add.Length != 0 && checkList.Length != 0 )
            {
                
                xml.addProduct(add,count);
                addProduct(add, false);
                addPosition.Clear();
                addText("Продукт добавлен");

            }
            else if (add.Length == 0 && checkList.Length != 0)
                addText("Вы не можете добавить пустую строку");
            else 
                addText("Загрузите список продуктов");
            add = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect net = new();
            for (int i = 1; i <= xml.getCount(); i++)
            {
                string id = i.ToString();
                string product = net.getConnect(id);
                if (product != null)
                    list.AppendText(product + "\n");
            }
            
        }
    }
    
}
