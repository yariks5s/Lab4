using System;
using System.Windows.Forms;

namespace Lab4;

public partial class Greeting : Form
{
    public static Greeting Instance;
    public Greeting()
    {
        Instance = this;
        InitializeComponent();
    }


    private void chooseFileButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog fdlg = Form1.Instance.ChooseFile();
        if (fdlg.ShowDialog() == DialogResult.OK)
        {
            if(Helper.Deserialize(fdlg.FileName) != null) Form1.Instance._currPath = fdlg.FileName;
            Form1.Instance.FillRows(fdlg.FileName);
            Form1.Instance.Show();
            Hide();
        }
    }

    private void commonFileButton_Click(object sender, EventArgs e)
    {
        Form1.Instance.FillRows(Form1.Instance._currPath);
        Form1.Instance.Show();
        Hide();
    }
}