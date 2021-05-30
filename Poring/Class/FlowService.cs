using System.Text;

namespace Poring.Class
{
    public class FlowService
    {
        private readonly IService1 _service1;

        public FlowService(IService1 service1)
        {
            _service1 = service1;
        }

        public string GetResult()
        {
            return _service1.GetId().ToString();
            //return _service2.GetId().ToString();
        }
    }

    public class OtherFlowService
    {
        private readonly IService1 _service1;

        public OtherFlowService(IService1 service1)
        {
            _service1 = service1;
        }

        public string GetResult()
        {
            var sb = new StringBuilder();
            var id = _service1.GetId();
            //var id = _service2.GetId();
            foreach (var c in id.ToString())
            {
                sb.Insert(0, c);
            }

            return sb.ToString();
        }
    }
}