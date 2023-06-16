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
    [Table("LandPreparations")]
    public class LandPreparation : ValueObject
    {
        public Field Field { get; set; }
        public Guid FieldId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }
        public string SoilTreatment { get; set; }
        
        public LandPreparation()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
