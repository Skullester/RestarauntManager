using UserApp;
using CourseWork;
using Microsoft.EntityFrameworkCore;

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
        UserForm.ApplicationContext = new();
        var list = UserForm.ApplicationContext.Menu.Include(x => x.Category).ToList();
        dataGridView1.DataSource = list;
    }
}
