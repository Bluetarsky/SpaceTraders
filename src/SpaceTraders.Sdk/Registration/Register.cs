namespace SpaceTraders.Sdk.Registration;

public class Register
{
    private readonly IHttpCommunicator _httpCommunicator;
    
    public Register(IHttpCommunicator httpCommunicator)
    {
        _httpCommunicator = httpCommunicator;
    }

    public async Task RegisterNewAgentAsync(FactionType factionType, string symbol, string? email)
    {
        var registerNewAgent = new RegisterNewAgent()
        {
            Email = email,
            FactionType = factionType,
            Symbol = symbol
        };
        
        
    }
}