namespace NguyenNhanShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NguyenNhanShopDbContext dbContext;

        public NguyenNhanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NguyenNhanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}