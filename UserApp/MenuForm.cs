using UserApp;
using CourseWork;

namespace ManagerApp;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
        Initialize();
    }

    private void Initialize()
    {
        var list = UserForm.ApplicationContext.Menu.ToList();
        dataGridView1.DataSource = list;
    }
}
