namespace CqrsSample.Application.Common;

public sealed class Result<T> : Result
{
    public T? Value { get; }

    private Result(bool success, T? value, string? error) : base(success, error)
    {
        Value = value;
    }

    public static Result<T> Success(T value) => new(true, value, null);
    public static Result<T> Failure(string error) => new(false, default, error);
}