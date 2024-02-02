namespace ArtisanHub.Domain.Shared;

public class Result<TValue> : Result
{
    public TValue? Data { get; private set; }
    
    private Result(TValue data)
    {
        Data = data;
    }

    private Result(List<Error> errors)
        : base(errors)
    {
    }

    public static Result<TValue> Ok(TValue data) => new(data);

    public new static Result<TValue> Failure(List<Error> errors) => new(errors);
}