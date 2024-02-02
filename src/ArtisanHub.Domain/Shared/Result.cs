namespace ArtisanHub.Domain.Shared;

public class Result
{
    protected Result()
    {
        Success = true;
    }

    protected Result(List<Error> errors)
    {
        Errors = errors;
    }
    
    public bool Success { get; init; }
    public bool IsFailure => !Success;
    public List<Error> Errors { get; init; } = [];

    public static Result Ok() => new();
    
    public static Result Failure(List<Error> errors) => new(errors);
}