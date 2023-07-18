using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class EquipmentAppService : CrudAppService<Equipment, EquipmentDto, Guid, PagedAndSortedResultRequestDto, EquipmentCreateUpdateDto, EquipmentCreateUpdateDto>,
    IEquipmentAppService
{

    public EquipmentAppService(IRepository<Equipment, Guid> repository) : base(repository)
    {
    }

}
