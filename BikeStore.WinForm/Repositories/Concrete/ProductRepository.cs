using BikeStore.WinForm.Models.Database;
using BikeStore.WinForm.Models.StoredProcedures;
using BikeStore.WinForm.Repositories.Abstract;
using System.Collections.Generic;

namespace BikeStore.WinForm.Repositories.Concrete
{
    public class ProductRepository : BaseConnection, IBaseRepository<UpdateProductSp>
    {
        public int DeleteDate(UpdateProductSp dataItem)
        {
            throw new System.NotImplementedException();
        }

        public List<UpdateProductSp> GetAllData()
        {
            throw new System.NotImplementedException();
        }

        public UpdateProductSp GetDataById(int dataItemId)
        {
            throw new System.NotImplementedException();
        }

        public int InsertDate(UpdateProductSp dataItem)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateDate(UpdateProductSp dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
