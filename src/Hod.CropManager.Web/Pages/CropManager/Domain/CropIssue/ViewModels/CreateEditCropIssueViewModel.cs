using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropIssue.ViewModels;

public class CreateEditCropIssueViewModel
{
    [Display(Name = "CropIssueCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "CropIssueIssueTypeId")]
    public Guid IssueTypeId { get; set; }

    [Display(Name = "CropIssueNotes")]
    public string Notes { get; set; }

    [Display(Name = "CropIssueDate")]
    public DateTime Date { get; set; }
}
