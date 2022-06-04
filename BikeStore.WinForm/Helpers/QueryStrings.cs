namespace BikeStore.WinForm.Helpers
{
    public static class QueryStrings
    {
        public static string GetAllBrandData()
        {
            return "select * from production.brands";
        }

        public static string GetDataBrandById(int id)
        {
            return $"select * from production.brands where brand_id={id}";
        }

        public static string GetAllCategoryData()
        {
            return "select * from production.category";
        }

        public static string GetDataCategoryById(int id)
        {
            return $"select * from production.category where category_id={id}";
        }
    }
}
