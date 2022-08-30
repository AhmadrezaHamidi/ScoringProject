using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShortLink.Core.Dtos;
using ShortLink.Core.Models;
using ShortLink.Service.Filters.ActionFilters;
using ShortLink.Service.Interfaces;

namespace ShortLink.Controllers;


[Route("api/userauthentication")]
[ApiController]
public class LinkController : BaseApiController
{
    public LinkController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper) : base(repository, logger, mapper)
    {
    }

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
    {

        var userResult = await _repository.UserAuthentication.RegisterUserAsync(userRegistration);
        return !userResult.Succeeded ? new BadRequestObjectResult(userResult) : StatusCode(201);
    }

    [HttpPost("login")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> Authenticate([FromBody] UserLoginDto user)
    {
        return !await _repository.UserAuthentication.ValidateUserAsync(user)
            ? Unauthorized()
            : Ok(new { Token = await _repository.UserAuthentication.CreateTokenAsync() });
    }



    [HttpPost("CreateShortLink/{input}")]
 //   [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> Create([FromRoute] string input)
    {
        var isExist = _repository.Link.ExistUrl(input);
        if (isExist is true)
            return StatusCode(500, "this link is exist ");
        else
        {

            var istance = new LinkEntity(input);
            await _repository.Link.CreateLink(istance);
            await _repository.SaveAsync();
            ///var res = _mapper.Map<LinkResultDto>(istance);
            return Ok(istance.Id);
        }
    }

    [HttpGet("{shortLink}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> Click([FromRoute] string input)
    {
        var link = _repository.Link.GetByShortLink(input);
        if (string.IsNullOrEmpty(link.Result.Url))
            return StatusCode(404, "not found");
        else
            return Redirect(link.Result.Url);
    }

}

