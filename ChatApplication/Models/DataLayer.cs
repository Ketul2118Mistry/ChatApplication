using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using RabbitMQ.Util;
using System.Web.Mvc;
using ChatApplication.Models;
using System.Web.UI.WebControls;

namespace ChatApplication.Models
{
    public class DataLayer
    {
        internal Chat_tb login(string email, string password)
        {
            throw new NotImplementedException();
        }

        internal List<Chat_tb> getusers(int id)
        {
            throw new NotImplementedException();
        }
    }
}