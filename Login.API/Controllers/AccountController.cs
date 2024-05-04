using Login.Application.Models.Account;
using Login.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Login.API.Controllers;

[ApiController]
[Route("api/v1/account")]
public class AccountController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
   
    [HttpGet("")]
    public string Register()
    {
        return "essa api é de Login";
    }

    [HttpPost("clientes/register")]
    public IActionResult RegisterCliente(RegisterAccountModel model)
    {

        if(ModelState.IsValid){

        }
        return Ok("essa api é de Login");
    }

    [HttpPost("funcionarios/register")]
    public IActionResult RegisterFuncionario(RegisterAccountModel model)
    {

        if(ModelState.IsValid){

        }
        return Ok("essa api é de Login");
    }

    [HttpPost("empresas/register")]
    public IActionResult RegisterEmpresa(RegisterAccountModel model)
    {

        if(ModelState.IsValid){
            
        }
        return Ok("essa api é de Login");
    }
}
