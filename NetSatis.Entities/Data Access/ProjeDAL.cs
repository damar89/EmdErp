using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System.Linq;

namespace NetSatis.Entities.Data_Access
{
    public class ProjeDAL : EntityRepositoryBase<NetSatisContext, Proje, ProjeValidator>
    {
        public ProjeDAL()
        {

        }
    }
}
