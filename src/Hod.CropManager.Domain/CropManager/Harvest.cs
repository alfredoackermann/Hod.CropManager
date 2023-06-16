using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("Harvests")]
    public class Harvest : Entity<Guid>
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Yeld { get; set; }
        public string Quality { get; set; }
        public Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }

        public Harvest()
        {
        }

        public Harvest(
            Guid id,
            Crop crop,
            DateTime startDate,
            DateTime endDate,
            double yeld,
            string quality,
            Equipment equipment
        ) : base(id)
        {
            Crop = crop;
            StartDate = startDate;
            EndDate = endDate;
            Yeld = yeld;
            Quality = quality;
            Equipment = equipment;
        }
    }
}
