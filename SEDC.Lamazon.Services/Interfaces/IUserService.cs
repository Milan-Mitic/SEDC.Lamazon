using SEDC.Lamazon.Services.ViewModels.User;
using SEDC.Lamazon.Web.Views.Role;

namespace SEDC.Lamazon.Services.Interfaces;

public interface IUserService
{
    List<UserViewModel> GetAllUsers();
    UserViewModel GetUserById(int id);
    void DeleteUserById(int id);

    UserViewModel LoginUser(LoginUserViewModel loginUserViewModel);
    void RegisterUser(RegisterUserViewModel registerUserViewModel);

    List<RoleViewModel> GetAllUserRoles();
    RoleViewModel GetUserRoleById(int id);
}