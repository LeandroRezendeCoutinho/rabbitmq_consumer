using System;

namespace rabbitmq_consumer
{
  public class Request
  {
    public Guid RequestId { get; set; }
    public Header Header { get; set; }
    public string Body { get; set; }
  }
}