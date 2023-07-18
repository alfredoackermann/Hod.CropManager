using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class PesticideScheduleAppService : CrudAppService<PesticideSchedule, PesticideScheduleDto, Guid, PagedAndSortedResultRequestDto, PesticideScheduleCreateUpdateDto, PesticideScheduleCreateUpdateDto>,
    IPesticideScheduleAppService
{

    public PesticideScheduleAppService(IRepository<PesticideSchedule, Guid> repository) : base(repository)
    {
    }

}
