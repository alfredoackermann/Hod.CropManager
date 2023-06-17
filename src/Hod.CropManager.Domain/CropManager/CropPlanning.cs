using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("CropPlannings")]
    public class CropPlanning : BasicAggregateRoot<Guid>
    {
        public CropType Crop { get; set; }
        public Field Field { get; set; }
        public ICollection<IrrigationSchedule> IrrigationSchedules { get; set; }
        public ICollection<FertilizationSchedule> FertilizationSchedules { get; set; }
        public ICollection<PesticideSchedule> PesticideSchedules { get; set; }
        public DateTime PlantingDate { get; set; }
        public DateTime HarvestDate { get; set; }
        public double Size { get; set; }
        public double Yeld { get; set; }

        public CropPlanning()
        {
        }

        public CropPlanning(
            Guid id,
            CropType crop,
            Field field,
            ICollection<IrrigationSchedule> irrigationSchedule,
            ICollection<FertilizationSchedule> fertilizationSchedule,
            ICollection<PesticideSchedule> pesticideSchedule,
            DateTime plantingDate,
            DateTime harvestDate,
            double size,
            double yeld
        ) : base(id)
        {
            Crop = crop;
            Field = field;
            IrrigationSchedules = irrigationSchedule;
            FertilizationSchedules = fertilizationSchedule;
            PesticideSchedules = pesticideSchedule;
            PlantingDate = plantingDate;
            HarvestDate = harvestDate;
            Size = size;
            Yeld = yeld;
        }
    }
}
