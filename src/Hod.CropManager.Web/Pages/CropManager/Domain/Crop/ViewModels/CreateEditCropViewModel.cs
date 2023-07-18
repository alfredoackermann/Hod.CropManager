using Hod.CropManager.Web.Pages.CropManager.Domain.CropIssue.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.Harvest.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule.ViewModels;
using System;
using System.Collections.Generic;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Crop.ViewModels;

public class CreateEditCropViewModel
{
    public Guid CropTypeId { get; set; }

    public Guid FieldId { get; set; }

    public double Size { get; set; }

    public string PlantingMethod { get; set; }

    public ICollection<CreateEditGrowthStageViewModel> GrowthStages { get; set; }

    public ICollection<CreateEditIrrigationScheduleViewModel> IrrigationSchedules { get; set; }

    public ICollection<CreateEditFertilizationScheduleViewModel> FertilizationSchedules { get; set; }

    public ICollection<CreateEditPesticideScheduleViewModel> PesticideSchedules { get; set; }

    public ICollection<CreateEditHarvestViewModel> Harvests { get; set; }

    public ICollection<CreateEditCropIssueViewModel> CropIssues { get; set; }

    public DateTime PlantingDate { get; set; }

    public DateTime HarvestDate { get; set; }

    public DateTime CreationTime { get; set; }
}
