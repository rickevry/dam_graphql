namespace Dam.Repository
{
    public interface IEntityRepositoryProvider
    {
        IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : new();
    }
}
