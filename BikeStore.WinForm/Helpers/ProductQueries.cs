namespace BikeStore.WinForm.Helpers
{
    public static class ProductQueries
    {
        public static string GetAll()
        {
            return @"select p.product_id,
                            p.product_name,
                            p.list_price,
                            p.model_year,
                            b.brand_name,
                            c.category_name
                    from production.products as p
                        inner join production.brands as b on b.brand_id = p.brand_id
                        inner join production.categories as c on c.category_id = p.category_id";
        }

        public static string GetById(int dataItemId)
        {
            return $@"select *
                    from production.products as p
                    where p.product_id = {dataItemId}";
        }
    }
}
