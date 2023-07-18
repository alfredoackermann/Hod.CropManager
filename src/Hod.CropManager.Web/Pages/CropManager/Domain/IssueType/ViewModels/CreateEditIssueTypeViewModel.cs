using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IssueType.ViewModels;

public class CreateEditIssueTypeViewModel
{
    [Display(Name = "IssueTypeName")]
    public string Name { get; set; }

    [Display(Name = "IssueTypeDescription")]
    public string Description { get; set; }

    [Display(Name = "IssueTypeSeverity")]
    public string Severity { get; set; }
}
