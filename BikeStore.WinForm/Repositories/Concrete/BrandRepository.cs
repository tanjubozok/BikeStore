using BikeStore.WinForm.Helpers;
using BikeStore.WinForm.Models.Database;
using BikeStore.WinForm.Models.Entities;
using BikeStore.WinForm.Repositories.Abstract;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore.WinForm.Repositories.Concrete
{
    public class BrandRepository : BaseConnection, IBaseRepository<Brand>
    {
        public int DeleteDate(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }

        public List<Brand> GetAllData()
        {
            List<Brand> data = new List<Brand>();
            string query = QueryStrings.GetAllBrandData();
            data = _sqlConnection.Query<Brand>(query).ToList();
            return data;
        }

        public Brand GetDataById(int dataItemId)
        {
            Brand data = null;
            string query = QueryStrings.GetDataBrandById(dataItemId);
            data = _sqlConnection.QueryFirstOrDefault<Brand>(query);
            return data;
        }

        public int InsertDate(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateDate(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
