using Microsoft.EntityFrameworkCore;
using ShortLink.Core.Models;
using ShortLink.Repo.Data;
using ShortLink.Repo.GenericRepository.Service;
using ShortLink.Service.Interfaces;

namespace ShortLink.Service.Services;

public class TeacherRepository : RepositoryBase<LinkEntity>, ILinkRepository
{
    public TeacherRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task CreateLink(LinkEntity link)
    => await CreateAsync(link);


    public bool ExistUrl(string url)
    => FindByConditionAsync(c => c.Url.Equals(url),false).Result.Any() ;

    public async Task<LinkEntity> Exist(int Id)
    => await FindByConditionAsync(c => c.Id.Equals(Id),false).Result.SingleOrDefaultAsync();

    public async Task<IEnumerable<LinkEntity>> GetAllLinks(bool trackChanges)
    => await FindAllAsync(trackChanges).Result.OrderBy(c => c.Url).ToListAsync();

    public async Task<LinkEntity> GetByShortLink(string shortLink)
        => await FindByConditionAsync(c => c.ShortLink.Equals(shortLink),false).Result.SingleOrDefaultAsync();


}
