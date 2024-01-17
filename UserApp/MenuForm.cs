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
        var context = UserForm.ApplicationContext;
        var query = from product in context.Menu
                    join category in context.Categories on product.CategoryId equals category.Id
                    select new
                    {
                        Название = product.Name,
                        Цена = product.Cost + "₽",
                        Категория = category.Name
                    };
        var result = query.ToList();
        dataGridView1.DataSource = result;
    }
}
