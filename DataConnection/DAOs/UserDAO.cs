using Application.DAOInterfaces;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using sep3client.user;
using Shared.Models;

namespace DataConnection.DAOs;

public class UserDAO : IUserDAO
{
    
    private readonly UserService.UserServiceClient _userService;
    
    public UserDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _userService = new UserService.UserServiceClient(channel);
    }

    public async Task<User> CreateAsync(User user)
    {
        UserGrpc createdUser = await _userService.CreateUserAsync(new CreatingUser()
        {
            Username = user.Username,
            Password = user.Password,
            Email = user.Email,
            Name = user.Name,
            Role = user.Role
        });
        
        return ConvertToUser(createdUser);
    }
    
    public async Task<List<User>> GetAllUsersAsync()
    {
        var users = await _userService.GetAllUsersAsync(new Empty());
        List<User> userList = new();
        for (int i = 0; i < users.User.Count; i++)
        {
            userList.Add(ConvertToUser(users.User[i]));
        }
        return userList;
    }
    
    private User ConvertToUser(UserGrpc user)
    {
        return new User()
        {
            Username = user.Username,
            Password = user.Password,
            Email = user.Email,
            Name = user.Name,
            Role = user.Role
        };
    }
}