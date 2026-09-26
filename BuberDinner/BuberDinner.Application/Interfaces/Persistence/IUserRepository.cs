using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}