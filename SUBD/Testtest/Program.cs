using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Mapping;
using Domain;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Proxy;

namespace Testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Set();
            var n = Get();

        }

        static List<Server> Get()
        {
            using (ISession session = NHibernateHelper.OpenSession<Server>())
            {
                return session.Query<Server>().ToList();
            }
        }

        static void Set()
        {

            using (var session = NHibernateHelper.FluentNHibernateHelper.OpenSession())

            {

                var product = new Server { Address = "Lenovo Laptop", Login = "Sample product" };

                session.SaveOrUpdate(product);

            }

        }
    }
}
