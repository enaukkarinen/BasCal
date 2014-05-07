using System.ServiceModel;

namespace Darkside.WCF4Silverlight
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        int Add(int a, int b);
    }
}