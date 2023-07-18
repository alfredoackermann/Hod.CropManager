using CropManager.Domain;
using CropManager.Domain.Dtos;
using AutoMapper;

namespace Hod.CropManager;

public class CropManagerApplicationAutoMapperProfile : Profile
{
    public CropManagerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Crop, CropDto>();
        CreateMap<CropCreateUpdateDto, Crop>(MemberList.Source);
        CreateMap<CropType, CropTypeDto>();
        CreateMap<CropTypeCreateUpdateDto, CropType>(MemberList.Source);
        CreateMap<Field, FieldDto>();
        CreateMap<FieldCreateUpdateDto, Field>(MemberList.Source);
        CreateMap<IrrigationSystem, IrrigationSystemDto>();
        CreateMap<IrrigationSystemCreateUpdateDto, IrrigationSystem>(MemberList.Source);
        CreateMap<Harvest, HarvestDto>();
        CreateMap<HarvestCreateUpdateDto, Harvest>(MemberList.Source);
        CreateMap<CropIssue, CropIssueDto>();
        CreateMap<CropIssueCreateUpdateDto, CropIssue>(MemberList.Source);
        CreateMap<Equipment, EquipmentDto>();
        CreateMap<EquipmentCreateUpdateDto, Equipment>(MemberList.Source);
        CreateMap<GrowthStage, GrowthStageDto>();
        CreateMap<GrowthStageCreateUpdateDto, GrowthStage>(MemberList.Source);
        CreateMap<CropRotation, CropRotationDto>();
        CreateMap<CropRotationCreateUpdateDto, CropRotation>(MemberList.Source);
        CreateMap<FertilizationSchedule, FertilizationScheduleDto>();
        CreateMap<FertilizationScheduleCreateUpdateDto, FertilizationSchedule>(MemberList.Source);
        CreateMap<IrrigationSchedule, IrrigationScheduleDto>();
        CreateMap<IrrigationScheduleCreateUpdateDto, IrrigationSchedule>(MemberList.Source);
        CreateMap<LandPreparation, LandPreparationDto>();
        CreateMap<LandPreparationCreateUpdateDto, LandPreparation>(MemberList.Source);
        CreateMap<PesticideSchedule, PesticideScheduleDto>();
        CreateMap<PesticideScheduleCreateUpdateDto, PesticideSchedule>(MemberList.Source);
        CreateMap<IssueType, IssueTypeDto>();
        CreateMap<IssueTypeCreateUpdateDto, IssueType>(MemberList.Source);
        CreateMap<Fertilizer, FertilizerDto>();
        CreateMap<FertilizerCreateUpdateDto, Fertilizer>(MemberList.Source);
        CreateMap<Pesticide, PesticideDto>();
        CreateMap<PesticideCreateUpdateDto, Pesticide>(MemberList.Source);
    }
}
