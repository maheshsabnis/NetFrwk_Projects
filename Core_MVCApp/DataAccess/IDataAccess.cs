namespace Core_MVCApp.DataAccess
{
    /// <summary>
    /// Multi-Type Generic Interface
    /// </summary>
    /// <typeparam name="TEntity">The Entyty Class (Department, Employee) for which Methods will be used</typeparam>
    /// <typeparam name="TPk">The 'in' as input parameter to the method and TPk will be the DataType for the parameter e.g. int, string, etc</typeparam>
    public interface IDataAccess<TEntity, in TPk>
    {
        // Get all Records
        IEnumerable<TEntity> Get();
        // Get a single records based on the id
        TEntity Get(TPk id);
        // Create a new Record
        TEntity Craete(TEntity entity);
        // Update
        TEntity Update(TPk id, TEntity entity);
        // Delete
        TEntity Delete(TPk id);
    }
}
