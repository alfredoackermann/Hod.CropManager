using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Crop.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropType.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Field.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Harvest.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropIssue.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Equipment.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.LandPreparation.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IssueType.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Fertilizer.ViewModels;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Pesticide.ViewModels;
using AutoMapper;

namespace Hod.CropManager.Web;

public class CropManagerWebAutoMapperProfile : Profile
{
    public CropManagerWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<CropDto, CreateEditCropViewModel>();
        CreateMap<CreateEditCropViewModel, CropCreateUpdateDto>();
        CreateMap<CropTypeDto, CreateEditCropTypeViewModel>();
        CreateMap<CreateEditCropTypeViewModel, CropTypeCreateUpdateDto>();
        CreateMap<FieldDto, CreateEditFieldViewModel>();
        CreateMap<CreateEditFieldViewModel, FieldCreateUpdateDto>();
        CreateMap<IrrigationSystemDto, CreateEditIrrigationSystemViewModel>();
        CreateMap<CreateEditIrrigationSystemViewModel, IrrigationSystemCreateUpdateDto>();
        CreateMap<HarvestDto, CreateEditHarvestViewModel>();
        CreateMap<CreateEditHarvestViewModel, HarvestCreateUpdateDto>();
        CreateMap<CropIssueDto, CreateEditCropIssueViewModel>();
        CreateMap<CreateEditCropIssueViewModel, CropIssueCreateUpdateDto>();
        CreateMap<EquipmentDto, CreateEditEquipmentViewModel>();
        CreateMap<CreateEditEquipmentViewModel, EquipmentCreateUpdateDto>();
        CreateMap<GrowthStageDto, CreateEditGrowthStageViewModel>();
        CreateMap<CreateEditGrowthStageViewModel, GrowthStageCreateUpdateDto>();
        CreateMap<CropRotationDto, CreateEditCropRotationViewModel>();
        CreateMap<CreateEditCropRotationViewModel, CropRotationCreateUpdateDto>();
        CreateMap<FertilizationScheduleDto, CreateEditFertilizationScheduleViewModel>();
        CreateMap<CreateEditFertilizationScheduleViewModel, FertilizationScheduleCreateUpdateDto>();
        CreateMap<IrrigationScheduleDto, CreateEditIrrigationScheduleViewModel>();
        CreateMap<CreateEditIrrigationScheduleViewModel, IrrigationScheduleCreateUpdateDto>();
        CreateMap<LandPreparationDto, CreateEditLandPreparationViewModel>();
        CreateMap<CreateEditLandPreparationViewModel, LandPreparationCreateUpdateDto>();
        CreateMap<PesticideScheduleDto, CreateEditPesticideScheduleViewModel>();
        CreateMap<CreateEditPesticideScheduleViewModel, PesticideScheduleCreateUpdateDto>();
        CreateMap<IssueTypeDto, CreateEditIssueTypeViewModel>();
        CreateMap<CreateEditIssueTypeViewModel, IssueTypeCreateUpdateDto>();
        CreateMap<FertilizerDto, CreateEditFertilizerViewModel>();
        CreateMap<CreateEditFertilizerViewModel, FertilizerCreateUpdateDto>();
        CreateMap<PesticideDto, CreateEditPesticideViewModel>();
        CreateMap<CreateEditPesticideViewModel, PesticideCreateUpdateDto>();
    }
}
