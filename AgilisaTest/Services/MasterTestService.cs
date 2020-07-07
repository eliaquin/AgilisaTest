using AgilisaTest.Data;
using AgilisaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilisaTest.Services
{
    public interface IMasterTestService: IRepository<MasterTest>
    {

    }
    public class MasterTestService : Repository<MasterTest>, IMasterTestService
    {
        public MasterTestService(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
