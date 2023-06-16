using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Values;

namespace CropManager.Domain
{
    [Table("PesticideSchedules")]
    public class PesticideSchedule : ValueObject
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public Pesticide Pesticide { get; set; }
        public Guid PesticideId { get; set; }
        public DateTime Date { get; set; }
        public string ApplicationMethod { get; set; }
        public double Quantity { get; set; }
        public Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }

        public PesticideSchedule()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}