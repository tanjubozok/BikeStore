using BikeStore.WinForm.Helpers;
using BikeStore.WinForm.Models.Database;
using BikeStore.WinForm.Models.StoredProcedures;
using BikeStore.WinForm.Models.ViewModels;
using BikeStore.WinForm.Repositories.Abstract;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BikeStore.WinForm.Repositories.Concrete
{
    public class ProductRepository : BaseConnection, IBaseRepository<UpdateProductSp>
    {
        public int DeleteData(UpdateProductSp dataItem)
        {
            var resultProductId = new { product_id = dataItem.product_id };
            return _sqlConnection.Execute("DeleteProductById", resultProductId, commandType: CommandType.StoredProcedure);
        }

        public List<UpdateProductSp> GetAllData()
        {
            throw new System.NotImplementedException();
        }

        public UpdateProductSp GetDataById(int dataItemId)
        {
            string query = ProductQueries.GetById(dataItemId);
            var updateProduct = _sqlConnection.QueryFirstOrDefault<UpdateProductSp>(query);
            return updateProduct;
        }

        public int InsertData(UpdateProductSp dataItem)
        {
            var resultProductData = new
            {
                product_name = dataItem.product_name,
                brand_id = dataItem.brand_id,
                category_id = dataItem.category_id,
                model_year = dataItem.model_year,
                list_price = dataItem.list_price
            };
            return _sqlConnection.Execute("InsertProduct", resultProductData, commandType: CommandType.StoredProcedure);
        }

        public int UpdateData(UpdateProductSp dataItem)
        {
            return _sqlConnection.Execute("UpdateProduct", dataItem, commandType: CommandType.StoredProcedure);
        }

        public List<ProductListViewModel> GetAll()
        {
            string query = ProductQueries.GetAll();
            var dataItemList = _sqlConnection.Query<ProductListViewModel>(query).ToList();
            return dataItemList;
        }
    }
}
