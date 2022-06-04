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
        public int DeleteDate(Category dataItem)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAllData()
        {
            List<Category> data = new List<Category>();
            string query = QueryStrings.GetAllCategoryData();
            data = _sqlConnection.Query<Category>(query).ToList();
            return data;
        }

        public Category GetDataById(int dataItemId)
        {
            Category data = null;
            string query = QueryStrings.GetDataCategoryById(dataItemId);
            data = _sqlConnection.QueryFirstOrDefault<Category>(query);
            return data;
        }

        public int InsertDate(Category dataItem)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateDate(Category dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
