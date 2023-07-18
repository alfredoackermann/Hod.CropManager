using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class IssueTypeAppService : CrudAppService<IssueType, IssueTypeDto, Guid, PagedAndSortedResultRequestDto, IssueTypeCreateUpdateDto, IssueTypeCreateUpdateDto>,
    IIssueTypeAppService
{

    public IssueTypeAppService(IRepository<IssueType, Guid> repository) : base(repository)
    {
    }

}
