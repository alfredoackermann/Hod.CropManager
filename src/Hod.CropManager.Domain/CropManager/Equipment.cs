using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("Equipments")]
    public class Equipment : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Equipment()
        {
        }

        public Equipment(
            Guid id,
            string name,
            string type
        ) : base(id)
        {
            Name = name;
            Type = type;
        }
    }
}
