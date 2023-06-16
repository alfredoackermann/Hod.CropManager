﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Values;

namespace CropManager.Domain
{
    [Table("GrowthStages")]
    public class GrowthStage : ValueObject
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public string Stage { get; set; }
        public DateTime Date { get; set; }
        
        public GrowthStage()
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}