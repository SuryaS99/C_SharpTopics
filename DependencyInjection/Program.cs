using DependencyInjection;
using System;

namespace DependencyInjection
{
    public interface Iservice
    {
        void service();

    }
    public class Service1 : Iservice
    {
        public void service()
        {
            Console.WriteLine("Service 1 invoke");
        }

    }
    public class Service2 : Iservice
    {
        public void service()
        {
            Console.WriteLine("Service 2 Invoke");
        }
    }
    public class Client
    {
        private Iservice _Iservice;

        public Client(Iservice iservice)
        {
            _Iservice = iservice;
        }
        public void ServiceMethod()
        {
            _Iservice.service();
        }
    }

}
public class program
{
    public static void Main(String[] args)
    {
        Service1 s1 = new Service1();
        Client c1 = new Client(s1);
        c1.ServiceMethod();
        Console.ReadLine();

    }
}
