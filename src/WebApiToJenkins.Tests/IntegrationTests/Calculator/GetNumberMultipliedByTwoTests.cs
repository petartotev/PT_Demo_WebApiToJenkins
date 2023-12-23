using FluentAssertions;
using Newtonsoft.Json;
using System.Net;
using WebApiToJenkins.Api.Models;

namespace WebApiToJenkins.Tests.IntegrationTests.Calculator;

public class GetNumberMultipliedByTwoTests : BaseTests
{
    [Test]
    public async Task WithFive_ReturnsTen()
    {
        // Arrange & Act
        var response = await Client.GetAsync(GetUrl() + "/5");
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ObjectCalculatedResponse>(content);

        // Assert
        IsSuccess(response);
        result.Result.Should().Be(11);
    }

    [Test]
    public async Task WithSeven_ReturnsFourteen()
    {
        // Arrange & Act
        var response = await Client.GetAsync(GetUrl() + "/7");
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ObjectCalculatedResponse>(content);

        // Assert
        IsSuccess(response);
        result.Result.Should().Be(14);
    }

    [Test]
    public async Task WithZero_ReturnsBadRequest()
    {
        // Arrange & Act
        var response = await Client.GetAsync(GetUrl() + "/0");

        // Assert
        IsFail(response);
    }

    [Test]
    public async Task WithNoValue_ReturnsNotFound()
    {
        // Arrange & Act
        var response = await Client.GetAsync(GetUrl());

        // Assert
        IsFail(response, HttpStatusCode.NotFound);
    }

    // ==================== Helper Methods ====================
    private static Uri GetUrl()
    {
        return new Uri("http://localhost:5168/api/calculator/multiplybytwo");
    }

    private void IsSuccess(
        HttpResponseMessage response,
        HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
    {
        response.IsSuccessStatusCode.Should().Be(true);
        response.StatusCode.Should().Be(expectedStatusCode);
    }

    private void IsFail(
    HttpResponseMessage response,
    HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest)
    {
        response.IsSuccessStatusCode.Should().Be(false);
        response.StatusCode.Should().Be(expectedStatusCode);
    }
}
