using System.Windows.Forms;

namespace UserApp;
class Category
{
    private List<Sushi> sushis;
    private const int COUNT_OF_PRODUCTS = 4;
    private readonly List<PictureBox> pictureBoxes = new();
    private readonly UserForm form;
    public Category(UserForm form, string[] urls, string[] names, int cost)
    {
        this.form = form;
        sushis = new List<Sushi>();
        for (int i = 0; i < COUNT_OF_PRODUCTS; i++)
        {
            var picture = new PictureBox();
            pictureBoxes.Add(picture);
            sushis.Add(new Sushi(picture, urls[i], names[i], cost));
        }
    }
    private void AddControls()
    {
        form.TableLayoutPanel1.Controls.Clear();
        foreach (var item in pictureBoxes)
        {
            form.TableLayoutPanel1.Controls.Add(item);
        }
    }
    public void Show()
    {
        AddControls();
        foreach (var s in sushis)
            s.SetImage();

    }
}