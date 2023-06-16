using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace CropManager.Domain
{
    [Table("IssueTypes")]
    public class IssueType : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }

        public IssueType()
        {
        }

        public IssueType(
            Guid id,
            string name,
            string description,
            string severity
        ) : base(id)
        {
            Name = name;
            Description = description;
            Severity = severity;
        }
    }
}
