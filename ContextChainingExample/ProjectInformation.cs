namespace ContextChainingExample;

internal record ProjectInformation
{
    public required Guid Id { get; init; }
    public required string State { get; init; }
    public required bool HasApproval { get; init; }
}