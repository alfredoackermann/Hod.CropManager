using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class CropIssueAppService : CrudAppService<CropIssue, CropIssueDto, Guid, PagedAndSortedResultRequestDto, CropIssueCreateUpdateDto, CropIssueCreateUpdateDto>,
    ICropIssueAppService
{

    public CropIssueAppService(IRepository<CropIssue, Guid> repository) : base(repository)
    {
    }

}
