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
    [Table("Crops")]
    public class Crop : BasicAggregateRoot<Guid>
    {
        public CropType CropType { get; set; }
        public Guid CropTypeId { get; set; }
        public Field Field { get; set; }
        public Guid FieldId { get; set; }
        public double Size { get; set; }
        public string PlantingMethod { get; set; }
        public ICollection<GrowthStage> GrowthStages { get; set; }
        public ICollection<IrrigationSchedule> IrrigationSchedules { get; set; }
        public ICollection<FertilizationSchedule> FertilizationSchedules { get; set; }
        public ICollection<PesticideSchedule> PesticideSchedules { get; set; }
        public ICollection<Harvest> Harvests { get; set; }
        public ICollection<CropIssue> CropIssues { get; set; }
        public DateTime PlantingDate { get; set; }
        public DateTime HarvestDate { get; set; }
        public DateTime CreationTime { get; set; }


        protected Crop()
        {
        }

        public Crop(
            Guid id,
            CropType cropType,
            Field field,
            double size,
            string plantingMethod,
            ICollection<GrowthStage> growthStages,
            ICollection<IrrigationSchedule> irrigationSchedules,
            ICollection<FertilizationSchedule> fertilizationSchedules,
            ICollection<PesticideSchedule> pesticideSchedules,
            ICollection<Harvest> harvests,
            ICollection<CropIssue> cropIssues,
            DateTime plantingDate,
            DateTime harvestDate
        ) : base(id)
        {
            CropType = cropType;
            Field = field;
            Size = size;
            PlantingMethod = plantingMethod;
            GrowthStages = growthStages;
            IrrigationSchedules = irrigationSchedules;
            FertilizationSchedules = fertilizationSchedules;
            PesticideSchedules = pesticideSchedules;
            Harvests = harvests;
            CropIssues = cropIssues;
            PlantingDate = plantingDate;
            HarvestDate = harvestDate;
            CreationTime = DateTime.Now;
        }
    }
}
