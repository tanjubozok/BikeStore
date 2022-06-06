namespace BikeStore.WinForm.Helpers
{
    public static class CategoryQueries
    {
        public static string GetAll()
        {
            return @"select * from production.categories";
        }

        public static string GetById(int id)
        {
            return $@"select *
                    from production.categories
                    where category_id = {id}";
        }
    }
}
