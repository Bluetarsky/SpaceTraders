using System.Diagnostics;
using System.Net.Http.Json;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SpaceTraders.Sdk;

public class HttpCommunicator : IHttpCommunicator
{
    private readonly ILogger<HttpCommunicator> _logger;
    private readonly ServiceProvider _serviceProvider;
    private readonly HttpClient _httpClient;

    public HttpCommunicator(
        ILogger<HttpCommunicator> logger,
        ServiceProvider serviceProvider,
        HttpClient httpClient)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
        _httpClient = httpClient;
    }

    public async Task PostAsync()
    {
        
    }

    private async Task<Result<TResponse>> SendAsync<TRequest, TResponse>(
        HttpMethod httpMethod, 
        string path, 
        TRequest request, 
        CancellationToken cancellationToken = default) 
            where TRequest : class 
            where TResponse : class
    {
        if (_serviceProvider.GetRequiredService<TRequest>() is not IValidator<TRequest> validator) throw new NotImplementedException();
        var result = await validator.ValidateAsync(new ValidationContext<TRequest>(request), cancellationToken).ConfigureAwait(false);
        if (!result.IsValid)
        {
            
        }

        using var httpRequestMessage = new HttpRequestMessage(httpMethod, path)
        {
            Content = JsonContent.Create(request)
        };
        using var response = await _httpClient.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            
        }

        throw new NotImplementedException();
    }
}