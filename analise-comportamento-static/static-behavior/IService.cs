using System.ServiceModel;

namespace static_behavior
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetVariable();        
    }
}
