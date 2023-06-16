using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("Fields")]
    public class Field : BasicAggregateRoot<Guid>
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        public double Size { get; set; }
        public string SoilType { get; set; }
        public string Location { get; set; }
        public ICollection<IrrigationSystem> IrrigationSystems { get; set; }
        public ICollection<CropRotation> CropRotations { get; set; }
        public ICollection<Crop> Crops { get; set; }

        public Field()
        {
        }

        public Field(
            Guid id,
            string name,
            double size,
            string soilType,
            string location,
            ICollection<IrrigationSystem> irrigationSystem,
            ICollection<CropRotation> cropRotation
        ) : base(id)
        {
            Name = name;
            Size = size;
            SoilType = soilType;
            Location = location;
            IrrigationSystem = irrigationSystem;
            CropRotation = cropRotation;
        }
    }
}
