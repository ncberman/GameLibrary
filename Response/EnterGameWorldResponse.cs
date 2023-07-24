using GameLibrary.Model;
namespace GameLibrary.Response
{
    public class EnterGameWorldResponse : IResponse
    {
        private string _InstanceName;
        public string InstanceName { get { return _InstanceName; } set { _InstanceName = value; } }

        public EnterGameWorldResponse(string instanceName) 
        {
            _InstanceName = instanceName;
        }
    }
}
