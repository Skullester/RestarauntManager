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
            .Include(x => x.airplane.name)
            .Include(x => x.start_airport)
            .Include(x => x.end_airport)
            .OrderBy(x => x)
            .Take(5);
        var dataSource = query.ToList();
        reportForm.dataGridView1.DataSource = dataSource;
    }
}
