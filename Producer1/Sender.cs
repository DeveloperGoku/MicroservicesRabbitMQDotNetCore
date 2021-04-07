using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer1
{
    public class Sender
    {
       public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" }; // created the factory
            using (var connection = factory.CreateConnection()) // open the connection
            using (var channel = connection.CreateModel())       // created the model
            {
                channel.QueueDeclare("BasicTest", false, false, false, null); // declared the queue
                string message = "getting staerted with .netcore RabbitMQ";
                var body = Encoding.UTF8.GetBytes(message);   // encoded the message
                channel.BasicPublish("", "BasicTest", null, body);
                Console.WriteLine("sent message {0}", message);

            }
            Console.WriteLine("press enter to [Exit] the sender App");
            Console.ReadLine();


        }
    }
}
