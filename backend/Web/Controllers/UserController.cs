using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class UserController : BaseCRUDController<UserController, int, RegisterDto, UserUpdateDto, UserProfileDto>
    {
       
    }
}