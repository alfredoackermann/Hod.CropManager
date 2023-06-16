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
    [Table("CropTypes")]
    public class CropType : BasicAggregateRoot<Guid>
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        [StringLength(64 * 1024)]
        public string Description { get; set; }
        public TimeSpan GrowthDuration { get; set; }
        public double WaterRequirements { get; set; }
        public string SoilRequirements { get; set; }
        public string SunRequirements { get; set; }
        public string TemperatureRange { get; set; }
        public string HumidityRange { get; set; }
        public string NutrientRequirements { get; set; }
        public string PestsAndDisease { get; set; }

        public CropType()
        {
        }

        public CropType(
            Guid id,
            string name,
            string description,
            TimeSpan growthDuration,
            double waterRequirements,
            string soilRequirements,
            string sunRequirements,
            string temperatureRange,
            string humidityRange,
            string nutrientRequirements,
            string pestsAndDisease
        ) : base(id)
        {
            Name = name;
            Description = description;
            GrowthDuration = growthDuration;
            WaterRequirements = waterRequirements;
            SoilRequirements = soilRequirements;
            SunRequirements = sunRequirements;
            TemperatureRange = temperatureRange;
            HumidityRange = humidityRange;
            NutrientRequirements = nutrientRequirements;
            PestsAndDisease = pestsAndDisease;
        }
    }
}
