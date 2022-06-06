using BikeStore.WinForm.Helpers;
using BikeStore.WinForm.Models.Database;
using BikeStore.WinForm.Models.Entities;
using BikeStore.WinForm.Repositories.Abstract;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore.WinForm.Repositories.Concrete
{
    public class CategoryRepository : BaseConnection, IBaseRepository<Category>
    {
        public int DeleteData(Category dataItem)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAllData()
        {
            string query = CategoryQueries.GetAll();
            var data = _sqlConnection.Query<Category>(query).ToList();
            return data;
        }

        public Category GetDataById(int dataItemId)
        {
            string query = CategoryQueries.GetById(dataItemId);
            var data = _sqlConnection.QueryFirstOrDefault<Category>(query);
            return data;
        }

        public int InsertData(Category dataItem)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateData(Category dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
