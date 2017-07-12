namespace SlackWebApiClient.Interfaces.Models
{
    public interface IResponse
    {
        string Error { get; set; }
        bool Ok { get; set; }
    }
}