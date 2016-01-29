using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace unitTesting
{
    public interface IDatabaseContext
    {
        IQueryable<T> Query<T>();
    }

    public class User
    {
        public int Id { get; set; }
    }

    public class MembershipService
    {
        private readonly IDatabaseContext _dbContext;

        public MembershipService(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

       [Test]
        public IDatabaseContext mocking()
        {
            var t = new Mock<IDatabaseContext>();

            return t.Object;
        }

    }


}
