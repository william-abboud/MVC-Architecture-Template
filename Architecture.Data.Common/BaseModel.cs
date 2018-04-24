namespace Architecture.Data.Common
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseModel<TKey> : IDeletableEntity
    {
        [Key]
        public TKey Id { get; set; }

        [Index]
        public bool IsDeleted { get; set; }
    }
}
