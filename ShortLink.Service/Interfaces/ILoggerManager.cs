using ShortLink.Core.Models;

namespace ShortLink.Service.Interfaces;

public interface ILoggerManager
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogDebug(string message);
    void LogError(string message);
}

public interface ILinkRepository
{
    Task<IEnumerable<LinkEntity>> GetAllLinks(bool trackChanges);
    Task<LinkEntity> GetByShortLink(string shortLink);
    bool ExistUrl(string url);
    Task<LinkEntity> Exist(int Id);
    Task CreateLink(LinkEntity link);
}