namespace BikeStore.WinForm.Helpers
{
    public static class BrandQueries
    {
        public static string GetAll()
        {
            return @"select *
                    from production.brands";
        }

        public static string GetById(int id)
        {
            return $@"select *
                    from production.brands
                    where brand_id = {id}";
        }
    }
}
