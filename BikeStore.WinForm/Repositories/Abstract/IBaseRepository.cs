using System.Collections.Generic;

namespace BikeStore.WinForm.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int InsertData(T dataItem);
        int UpdateData(T dataItem);
        int DeleteData(T dataItem);

        List<T> GetAllData();
        T GetDataById(int dataItemId);
    }
}
