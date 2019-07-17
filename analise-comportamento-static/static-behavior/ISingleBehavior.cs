using System.ServiceModel;

namespace static_behavior
{
    [ServiceContract]
    public interface ISingleBehavior
    {
        [OperationContract]
        string GetVariable();
    }
}
