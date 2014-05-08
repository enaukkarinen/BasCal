using System.ServiceModel;

namespace Darkside.WCF4Silverlight
{
    [ServiceContract]
    public interface IKalenteriService
    {
        [OperationContract]
        int Add(int a, int b);
    }
}