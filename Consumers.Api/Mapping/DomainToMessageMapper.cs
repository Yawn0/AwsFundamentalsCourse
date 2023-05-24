using Consumers.Api.Contracts.Messages;
using Customers.Api.Domain;

namespace Consumers.Api.Mapping;

public static class DomainToMessageMapper
{
    public static CustomerCreated ToCustormerCreatedMessage(this Customer customerCreated)
    {
        return new CustomerCreated
        {
            Id = customerCreated.Id,
            Email = customerCreated.Email,
            GitHubUsername = customerCreated.GitHubUsername,
            FullName = customerCreated.FullName,
            DateOfBirth = customerCreated.DateOfBirth
        };
    }

    public static CustomerUpdated ToCustomerUpdatedMessage(this Customer customerUpdated)
    {
        return new CustomerUpdated
        {
            Id = customerUpdated.Id,
            Email = customerUpdated.Email,
            GitHubUsername = customerUpdated.GitHubUsername,
            FullName = customerUpdated.FullName,
            DateOfBirth = customerUpdated.DateOfBirth
        };
    }
}
