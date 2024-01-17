using CourseWork.Entities;

namespace ManagerApp;

public partial class ReportForm : Form
{
    public ReportForm(List<Product> products)
    {
        InitializeComponent();
        dataGridView1.DataSource = products;
    }
}
