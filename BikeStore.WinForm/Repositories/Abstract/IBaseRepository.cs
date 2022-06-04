using System.Collections.Generic;

namespace BikeStore.WinForm.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int InsertDate(T dataItem);
        int UpdateDate(T dataItem);
        int DeleteDate(T dataItem);

        List<T> GetAllData();
        T GetDataById(int dataItemId);
    }
}
