using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class FieldAppService : CrudAppService<Field, FieldDto, Guid, PagedAndSortedResultRequestDto, FieldCreateUpdateDto, FieldCreateUpdateDto>,
    IFieldAppService
{

    public FieldAppService(IRepository<Field, Guid> repository) : base(repository)
    {
    }

}
