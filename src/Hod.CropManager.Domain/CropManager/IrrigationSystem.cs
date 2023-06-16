using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("IrrigationSystems")]
    public class IrrigationSystem : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Field Field { get; set; }
        public Guid FieldId { get; set; }

        public IrrigationSystem()
        {
        }

        public IrrigationSystem(
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
