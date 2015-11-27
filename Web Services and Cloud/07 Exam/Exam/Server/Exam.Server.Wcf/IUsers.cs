namespace Exam.Server.Wcf
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    using Models;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsers" in both code and config file together.
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "users/top")]
        IEnumerable<UserResponseModel> Top();
    }
}
