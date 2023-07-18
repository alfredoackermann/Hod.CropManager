using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public interface IFieldAppService :
    ICrudAppService< 
                FieldDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        FieldCreateUpdateDto,
        FieldCreateUpdateDto>
{

}