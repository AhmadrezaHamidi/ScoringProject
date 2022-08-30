using ShortLink.Service.Interfaces;
public interface IRepositoryManager
{
    ILinkRepository Link { get; }
    IUserAuthenticationRepository UserAuthentication { get; }
    Task SaveAsync();
}
