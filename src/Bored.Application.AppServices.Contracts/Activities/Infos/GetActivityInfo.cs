namespace Bored.Application.Appservices.Contracts.Activities.Infos;

public class GetActivityInfo
{
    public string Activity {  get; set; }
    public string Link {  get; set; }
    public string Key { get; set; }
    public double Price { get; set; }
    public int Participants { get; set; }
    public double Accessibility { get; set; }
}