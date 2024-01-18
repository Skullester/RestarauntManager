using Microsoft.EntityFrameworkCore;

namespace Airport;

public interface IReport
{
    void Report(ReportForm reportForm);
}
class NearestFlightsReport : IReport
{
    private Context context;
    public NearestFlightsReport(Context context)
    {
        this.context = context;
    }
    public void Report(ReportForm reportForm)
    {
        var query = context.Destinations
            .Include(x => x.airplane)
            .Include(x => x.start_airport)
            .Include(x => x.end_airport)
            .OrderBy(x => x.FlightDate)
            .Take(5);
        var dataSource = query.ToList();
        reportForm.dataGridView1.DataSource = dataSource;
        reportForm.label1.Text = "Ближайшие рейсы";
    }
    public override string ToString()
    {
        return "Ближайшие рейсы";
    }
}
class DestinationReport : IReport
{
    private Context context;
    public DestinationReport(Context context)
    {
        this.context = context;
    }

    public void Report(ReportForm reportForm)
    {
        var textBox = new TextBox()
        {

        };
        reportForm.Controls.Add(textBox);
    }
    public override string ToString()
    {
        return "Список маршрутов по конечному пункту";
    }
}
class C : IReport
{
    private Context context;
    public C(Context context)
    {
        this.context = context;
    }

    public void Report(ReportForm reportForm)
    {

    }
}
