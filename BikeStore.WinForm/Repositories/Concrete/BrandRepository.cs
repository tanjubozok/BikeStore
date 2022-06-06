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
        public int DeleteData(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }

        public List<Brand> GetAllData()
        {
            string query = BrandQueries.GetAll();
            var data = _sqlConnection.Query<Brand>(query).ToList();
            return data;
        }

        public Brand GetDataById(int dataItemId)
        {
            string query = BrandQueries.GetById(dataItemId);
            var data = _sqlConnection.QueryFirstOrDefault<Brand>(query);
            return data;
        }

        public int InsertData(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateData(Brand dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
