using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Values;

namespace CropManager.Domain
{
    [Table("CropRotations")]
    public class CropRotation : ValueObject
    {
        public Field Field { get; set; }
        public Guid FieldId { get; set; }
        public CropType CropType { get; set; }
        public Guid CropTypeId { get; set; }
        public int RotationOrder { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public CropRotation()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}