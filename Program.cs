using System;

namespace rabbitmq_consumer
{
  class Program
  {
    static void Main(string[] args)
    {
      var consumer = new RabbitConsumer();
      consumer.receive();
    }
  }
}
