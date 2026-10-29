using System.Reflection;
using TheMemoAnaGame.Infrastructure.Services.Abstract;
using Microsoft.Extensions.Localization;

namespace TheMemoAnaGame.Infrastructure.Services.Concrete;

public class Localizer<T>(IStringLocalizerFactory factory) : ILocalizer<T> 
{
    private readonly IStringLocalizer _localizer =
        factory.Create("Strings", typeof(T).Assembly.FullName!);

    public string this[string key] => _localizer[key];
}
