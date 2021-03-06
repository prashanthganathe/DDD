﻿using RabbitMQHelper.SimpleHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQHelper
{

    public abstract class QueueServer
    {
        protected string host;
       
        public QueueServer(string host)
        {
            host = ConfigurationSettings.AppSettings["host"].ToString();// "amqp://login:password@my.rabbitmq.server.address:5672";
          
        }
    }
    public class Publisher: QueueServer
    {
       public Publisher(string host):base(host)
        {

        }
        public void PublishQueue(string objectMsg)
        {
            using (var queue = new RabbitWorkQueue(base.host, objectMsg))
            {
                for (var i = 0; i < 250; i++)
                {
                    queue.Publish(objectMsg);
                }
            }
    }
    }
}
