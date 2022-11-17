using System;
using System.Windows.Forms;

namespace Lab4;

public partial class AddData : Form
{
    private bool isUnique;
    public AddData()
    {
        InitializeComponent();
    }
    //             Adding data to list
    private void addDataTextButton_Click(object sender, EventArgs e)
    {
        Book book = Helper.CreateBook();
        if (Int32.TryParse(idTextBox.Text, out var id) && Helper.UniqueCheck(Form1.Instance.Books, id))
        {
            book.PublishingHouseId = id;
            book.Title = titleTextBox.Text;
            book.PublishingHouse.Adress = addressTextBox.Text;
            book.PublishingHouse.Id = id;
            Form1.Instance.AddRow(book);
            this.Hide();
        }
        else
        {
            MessageBox.Show(@"Please, enter the correct data.", @"Error");
            idTextBox.Clear();
            titleTextBox.Clear();
            addressTextBox.Clear();
        }
    }
    
}