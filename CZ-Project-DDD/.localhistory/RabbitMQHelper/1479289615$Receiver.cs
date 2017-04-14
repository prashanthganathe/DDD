using RabbitMQHelper.SimpleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQHelper
{
    public class Receiver : QueueServer
    {
        public Receiver(string host):base(host)
        {

        }

        public void ProcessMsg()
        {
            using (var queue = new RabbitWorkQueue(host, "my-test-queue"))
            {
                // keep consuming the queue with a 30 min timeout (in case the queue is empty for 30 minutes)
                foreach (var i in queue.Get(TimeSpan.FromMinutes(30)))
                {
                    try
                    {
                        // let's do some processing here ...
                        // ...

                        // in case of success, let's tell rabbitMq that this message was processed (acknowledge)!
                        i.Ack();
                    }
                    catch (Exception ex)
                    {
                        // in case of error, let's signal a negative acknowledgement
                        i.Nack();

                        // logging...
                    }
                }
            }
    }
    }
}
