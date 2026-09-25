namespace BuberDinner.Application.Interfaces.Services;

public interface IDateTimeProvider
{
    public DateTime UtcNow { get; }
}