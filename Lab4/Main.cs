using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Lab4;



namespace Lab4
{
    public partial class Form1 : Form
    {
        private bool _isCollapsed;
        public static Form1 Instance;
        public List<Book> Books = new List<Book>();
        public string _currPath = @"C:\Users\bryuh\RiderProjects\Lab_4\Lab4\testing.json";
        //             Here we have common directory for JSON data 
        public Form1()
        {
            InitializeComponent();           
            //FillRows(_currPath);
            Instance = this;
            Greeting greeting = new Greeting();
            greeting.Show();
        }
        //             Filling the rows with data
        public void FillRows(string path)
        {
            dataGridView1.Rows.Clear();
            List<Book> items = Helper.Deserialize(path);
            if (items.Count <= 0)
            {
                MessageBox.Show(@"Not found any data.",@"Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var item in items)
                {
                    AddRow(item);
                }
            }
        }
        public void AddRow(Book book)
        {
            object[] list = { book.PublishingHouseId.ToString(), book.Title, book.PublishingHouse.Adress };
            dataGridView1.Rows.Add(list);
            Books.Add(book);
        }
        
        private void AboutButton_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.Show();
        }
        
        private void AddData_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData();
            addData.Show();
        }
        //             Feature for moving menu
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_isCollapsed)
            {
                menuPanel.Height += 10;
                if (menuPanel.Size == menuPanel.MaximumSize)
                {
                    timer1.Stop();
                    _isCollapsed = false;
                }
            }
            else
            {
                menuPanel.Height -= 10;
                if (menuPanel.Size == menuPanel.MinimumSize)
                {
                    timer1.Stop();
                    _isCollapsed = true;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void saveAsButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = ChooseFile();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                _currPath = fdlg.FileName;
                Helper.Serialize(Books, _currPath);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = ChooseFile();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                _currPath = fdlg.FileName;
                Books.Clear();
                dataGridView1.Rows.Clear();
                FillRows(_currPath);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Helper.Serialize(Books, _currPath);
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
        //             Deleting row from datagrid
        public void DeleteBook()
        {
            dataGridView1.Rows.Clear();
            foreach (var book in Books)
            {
                object[] list = { book.PublishingHouseId.ToString(), book.Title, book.PublishingHouse.Adress };
                dataGridView1.Rows.Add(list);
            }
        }

        public OpenFileDialog ChooseFile()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = @"Select File:";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = @"Json files (*.json)|*.json";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            return fdlg;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.Hide();
        }

        public void UpdateRows(List<Book> books)
        {
            dataGridView1.Rows.Clear();
            foreach (var book in books)
            {
                object[] list = { book.PublishingHouseId.ToString(), book.Title, book.PublishingHouse.Adress };
                dataGridView1.Rows.Add(list);
            }
        }
    }
}