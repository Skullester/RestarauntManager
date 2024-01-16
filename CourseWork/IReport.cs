namespace CourseWork;

interface IReport
{
    void Report();
}
class ProfitReport : IReport
{
    public void Report()
    {

    }
    public override string ToString()
    {
        return "Прибыль";
    }
}
class BestProductReport : IReport
{
    public void Report()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return "Лучший товар";
    }
}
//class 