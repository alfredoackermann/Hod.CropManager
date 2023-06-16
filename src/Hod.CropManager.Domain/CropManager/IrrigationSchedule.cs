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
    [Table("IrrigationSchedules")]
    public class IrrigationSchedule : ValueObject
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Volume { get; set; }
        public IrrigationSystem IrrigationSystem { get; set; }

        public IrrigationSchedule()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
