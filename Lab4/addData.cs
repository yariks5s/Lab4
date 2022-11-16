using System;
using System.Windows.Forms;

namespace Lab4;

public partial class AddData : Form
{
    public AddData()
    {
        InitializeComponent();
    }
    //             Adding data to list
    private void addDataTextButton_Click(object sender, EventArgs e)
    {
        Book book = Helper.CreateBook();
        Int32.TryParse(idTextBox.Text, out var id);
        book.PublishingHouseId = id;
        book.Title = titleTextBox.Text;
        book.PublishingHouse.Adress = addressTextBox.Text;
        book.PublishingHouse.Id = id;
        Form1.Instance.AddRow(book);
        this.Hide();
    }
    
}