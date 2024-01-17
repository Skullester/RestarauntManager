
namespace Airport;

public partial class MainForm : Form
{
    private Context Context { get; set; }
    public MainForm()
    {
        InitializeComponent();
        Initialize();
    }

    private void Initialize()
    {
        Context = new();
    }
}
