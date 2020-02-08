using MessagingThingService.Models;
using MessagingThingService.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingThingService.Managers
{
    public class MessageDataManager
    {
        private readonly IMongoCollection<Message> messages;

        public MessageDataManager(IMessageThingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            messages = database.GetCollection<Message>(settings.MessagesCollectionName);
        }

        public List<Message> Get() =>
            messages.Find(book => true).ToList();

        public Message GetByDeviceId(string deviceId) =>
            messages.Find(message => message.ToDevice == deviceId).FirstOrDefault();

        public Message Get(string id) =>
            messages.Find(message => message.Id == id).FirstOrDefault();

        public Message Create(Message message)
        {
            var existingMessage = GetByDeviceId(message.ToDevice);
            if (existingMessage != null)
            {
                message.Id = existingMessage.Id;
                UpdateByDeviceId(message.ToDevice, message);
            }
            else
            {
                messages.InsertOne(message);
            }
            return message;
        }

        public void Update(string id, Message message) =>
            messages.ReplaceOne(book => book.Id == id, message);

        public void UpdateByDeviceId(string deviceId, Message message) =>
            messages.ReplaceOne(book => book.ToDevice == deviceId, message);

        public void Remove(Message message) =>
            messages.DeleteOne(msg => msg.Id == message.Id);

        public void Remove(string id) =>
            messages.DeleteOne(message => message.Id == id);
    }
}
