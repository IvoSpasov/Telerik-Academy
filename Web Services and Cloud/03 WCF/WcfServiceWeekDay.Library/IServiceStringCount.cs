namespace WcfServiceWeekDay.Library
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceStringCount
    {
        [OperationContract]
        int StringCount(string text, string word);
    }
}
