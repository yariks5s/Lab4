using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4;

public partial class SearchForm : Form
{
    private bool _isCollapsed;
    private bool _isOpened;
    private Form1 _main = null;

    public SearchForm()
    {
        InitializeComponent();
    }
    
    private void timer1_Elapsed(object sender, EventArgs e)
    {
        if (_isCollapsed)
        {
            panel1.Height += 10;
            if (panel1.Size == panel1.MaximumSize)
            {
                timer1.Stop();
                _isCollapsed = false;
            }

            _isOpened = true;
        }
        else
        {
            panel1.Height -= 10;
            if (panel1.Size == panel1.MinimumSize)
            {
                timer1.Stop();
                _isCollapsed = true;
            }
        }
    }
    //             Here we have search buttons
    private void searchByTitleButton_Click(object sender, EventArgs e)
    {
        dataGridView1.Rows.Clear();
        if (!_isOpened) timer1.Start();
        if (searchTextBox.Text == "")
            MessageBox.Show(@"Please, Enter the right input", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            List<Book> booklist = Helper.SearchByTitle(Form1.Instance.Books, searchTextBox.Text);
            FillDataGrid(booklist);
        }

        _isOpened = true;
    }
    private void searchByIdButton_Click(object sender, EventArgs e)
    {
        dataGridView1.Rows.Clear();
        if (!_isOpened) timer1.Start();
        if (searchTextBox.Text == "")
            MessageBox.Show(@"Please, Enter the right input", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            List<Book> booklist = Helper.SearchByIds(Form1.Instance.Books, searchTextBox.Text);
            FillDataGrid(booklist);
        }
        _isOpened = true;
    }
    private void searchByAddressButton_Click(object sender, EventArgs e)
    {
        dataGridView1.Rows.Clear();
        if (!_isOpened) timer1.Start();
        if (searchTextBox.Text == "")
            MessageBox.Show(@"Please, Enter the right input", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            List<Book> booklist = Helper.SearchByAddresses(Form1.Instance.Books, searchTextBox.Text);
            FillDataGrid(booklist);
        }
        _isOpened = true;
    }
    //             Just feature
    private void closeTableButton_Click(object sender, EventArgs e)
    {
        if(_isOpened) timer1.Start();
        _isOpened = false;
    }
    //             Button for deleting row
    private void deleteSelectedButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form1.Instance.Books = Helper.DeleteBook(Form1.Instance.Books, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                Form1.Instance.DeleteBook();
            }
        }
        catch (Exception) {MessageBox.Show(@"You cannot delete it.", @"Error");}
    }
    //             Fills the dataGrid with data
    void FillDataGrid(List<Book> booklist)
    {
        if (booklist.Count <= 0)
        {
            MessageBox.Show(@"Not found any data.",@"Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            foreach (var book in booklist)
            {
                object[] list = { book.PublishingHouseId.ToString(), book.Title, book.PublishingHouse.Adress };
                dataGridView1.Rows.Add(list);
            }
        }
    }
}