namespace ArtisanHub.Domain.Shared;

public class Result
{
    protected Result()
    {
        Success = true;
    }

    protected Result(Error error)
    {
        Error = error;
    }
    
    public bool Success { get; init; }
    public bool IsFailure => !Success;
    public Error Error { get; init; } 

    public static Result Ok() => new();
    
    public static Result Failure(Error error) => new(error);
}