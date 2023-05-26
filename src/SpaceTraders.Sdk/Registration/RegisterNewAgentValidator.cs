using FluentValidation;

namespace SpaceTraders.Sdk.Registration;

public class RegisterNewAgentValidator : AbstractValidator<RegisterNewAgent>
{
    private const int MinimumSymbolLength = 3;
    private const int MaximumSymbolLength = 14;
    public RegisterNewAgentValidator()
    {
        RuleFor(rna => rna.Symbol)
            .NotNull()
            .WithMessage("A symbol must be included during registration");
        RuleFor(rna => rna.Symbol)
            .Must(symbol => symbol is { Length: >= MinimumSymbolLength})
            .When(rna => !string.IsNullOrWhiteSpace(rna.Symbol))
            .WithMessage($"The minimum symbol length is {MinimumSymbolLength} characters");
        RuleFor(rna => rna.Symbol)
            .Must(symbol => symbol is { Length: <= MaximumSymbolLength})
            .When(rna => !string.IsNullOrWhiteSpace(rna.Symbol))
            .WithMessage($"The minimum symbol length is {MaximumSymbolLength} characters");
    }
}