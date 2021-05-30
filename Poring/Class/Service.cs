namespace Poring.Class
{
    public interface IService1
    {
        int GetId();
    }

    public class Service1 : IService1
    {
        private readonly IService3 _service3;

        public Service1(IService3 service3)
        {
            _service3 = service3;
        }

        public int GetId()
        {
            return 74 + _service3.GetSpecialNumber();
        }
    }


    public interface IService2
    {

    }

    public class Service2 : IService2
    { }


    public interface IService3
    {
        int GetSpecialNumber();
    }

    public class Service3 : IService3
    {
        public int GetSpecialNumber()
        {
            return 9453;
        }
    }
}