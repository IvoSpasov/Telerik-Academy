namespace Exam.Server.Wcf.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UserResponseModel
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public double Rating { get; set; }
    }
}