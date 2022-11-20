using System;
using System.Windows.Forms;

namespace Lab4;

public partial class aboutForm : Form
{
    public aboutForm()
    {
        InitializeComponent();
    }
    

    private void okButton_Click(object sender, EventArgs e)
    {
        Hide();
    }
}