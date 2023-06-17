using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("CropIssues")]
    public class CropIssue : Entity<Guid>
    {
        public Crop Crop { get; set; }
        public Guid CropId { get; set; }
        public IssueType IssueType { get; set; }
        public Guid IssueTypeId { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }

        public CropIssue()
        {
        }

        public CropIssue(
            Guid id,
            Crop crop,
            IssueType type,
            string notes,
            DateTime date
        ) : base(id)
        {
            Crop = crop;
            IssueType = type;
            Notes = notes;
            Date = date;
        }
    }
}
