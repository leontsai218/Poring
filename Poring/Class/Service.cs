namespace Poring.Class
{
    public class Service1 : IService1
    {
        public int GetId()
        {
            return 9527;
        }
    }

    public interface IService1
    {
        int GetId();
    }
}