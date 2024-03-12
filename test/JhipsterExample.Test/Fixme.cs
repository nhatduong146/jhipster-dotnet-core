using JhipsterExample.Infrastructure.Data;
using JhipsterExample.Domain.Entities;
using JhipsterExample.Test.Setup;

namespace JhipsterExample.Test;

public static class Fixme
{
    public static User ReloadUser<TEntryPoint>(AppWebApplicationFactory<TEntryPoint> factory, User user)
        where TEntryPoint : class, IStartup, new()
    {
        var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
        applicationDatabaseContext.Entry(user).Reload();
        return user;
    }
}
