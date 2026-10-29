namespace TheMemoAnaGame.Infrastructure.Services.Abstract;

public interface ILocalizer<T>
{
    string this[string key] { get; }
}
