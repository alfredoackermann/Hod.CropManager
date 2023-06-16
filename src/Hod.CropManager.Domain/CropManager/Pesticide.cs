using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("Pesticides")]
    public class Pesticide : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string ActiveIngredient { get; set; }
        public string Formulation { get; set; }
        public string ApplicationMethod { get; set; }
        public string ApplicationRate { get; set; }
        public string PHI { get; set; }
        public string REI { get; set; }
        public string SignalWord { get; set; }
        public string PPE { get; set; }
        public string Notes { get; set; }
        public Pesticide()
        {
        }

        public Pesticide(
            Guid id,
            string name,
            string type,
            string manufacturer,
            string activeIngredient,
            string formulation,
            string applicationMethod,
            string applicationRate,
            string pHI,
            string rEI,
            string signalWord,
            string pPE,
            string notes
        ) : base(id)
        {
            Name = name;
            Type = type;
            Manufacturer = manufacturer;
            ActiveIngredient = activeIngredient;
            Formulation = formulation;
            ApplicationMethod = applicationMethod;
            ApplicationRate = applicationRate;
            PHI = pHI;
            REI = rEI;
            SignalWord = signalWord;
            PPE = pPE;
            Notes = notes;
        }
    }
}
