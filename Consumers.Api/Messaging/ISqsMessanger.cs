using Amazon.SQS.Model;

namespace Consumers.Api.Messaging;

public interface ISqsMessanger
{
    Task<SendMessageResponse> SendMessageAsync<T>(T message);
}
