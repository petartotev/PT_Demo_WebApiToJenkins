using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApiToJenkins.Tests;

public abstract class BaseTests
{
    public BaseTests()
    {
        Client = new WebApplicationFactory<Program>().CreateClient();
    }

    public HttpClient Client { get; set; }
}
