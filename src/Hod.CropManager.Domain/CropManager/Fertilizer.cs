using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("Fertilizers")]
    public class Fertilizer : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string NPK { get; set; }
        public string ApplicationMethod { get; set; }
        public string ApplicationRate { get; set; }
        public string Notes { get; set; }
        public Fertilizer()
        {
        }

        public Fertilizer(
            Guid id,
            string name,
            string type,
            string manufacturer,
            string nPK,
            string applicationMethod,
            string applicationRate,
            string notes
        ) : base(id)
        {
            Name = name;
            Type = type;
            Manufacturer = manufacturer;
            NPK = nPK;
            ApplicationMethod = applicationMethod;
            ApplicationRate = applicationRate;
            Notes = notes;
        }
    }
}
