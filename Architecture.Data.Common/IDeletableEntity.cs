namespace Architecture.Data.Common
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }
    }
}
