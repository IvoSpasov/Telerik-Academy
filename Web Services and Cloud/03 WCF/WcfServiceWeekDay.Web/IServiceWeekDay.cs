namespace WcfServiceWeekDay.Web
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceWeekDay
    {
        [OperationContract]
        string GetWeekDay(DateTime date);
    }
}
