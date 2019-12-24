using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class KategoriDAL : EntityRepositoryBase<NetSatisContext, Kategori, KategoriValidator>
    {
    }
}
