namespace ArtisanHub.Application.InputModels.Users;

public record CreateUserInputModel(
    string Username,
    string Email,
    string Password);