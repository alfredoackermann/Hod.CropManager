using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class PesticideAppService : CrudAppService<Pesticide, PesticideDto, Guid, PagedAndSortedResultRequestDto, PesticideCreateUpdateDto, PesticideCreateUpdateDto>,
    IPesticideAppService
{

    public PesticideAppService(IRepository<Pesticide, Guid> repository) : base(repository)
    {
    }

}
