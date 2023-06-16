using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Values;

namespace CropManager.Domain
{
    [Table("FertilizationSchedules")]
    public class FertilizationSchedule : ValueObject
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public Fertilizer Fertilizer { get; set; }
        public Guid FertilizerId { get; set; }
        public DateTime Date { get; set; }
        public string ApplicationMethod { get; set; }
        public double Quantity { get; set; }
        public Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }


        public FertilizationSchedule()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
