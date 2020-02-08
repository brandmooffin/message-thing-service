using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingThingService.Managers;
using MessagingThingService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessagingThingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagingController : ControllerBase
    {
        private readonly MessageDataManager messageDataManager;

        public MessagingController(MessageDataManager messageDataManager)
        {
            this.messageDataManager = messageDataManager;
        }

        [HttpGet(Name = "GetAll")]
        public List<Message> GetAll()
        {
            return messageDataManager.Get();
        }

        [HttpGet("{deviceId}", Name = "Get")]
        public Message Get(string deviceId)
        {
            return messageDataManager.GetByDeviceId(deviceId);
        }

        [HttpPost]
        public void Post(Message message)
        {
            messageDataManager.Create(message);
        }

        [HttpPut("{id:length(24)}")]
        public void Put(string id, Message message)
        {
            message.Id = id;
            messageDataManager.Update(id, message);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id:length(24)}")]
        public void Delete(string id)
        {
            messageDataManager.Remove(id);
        }
    }
}
