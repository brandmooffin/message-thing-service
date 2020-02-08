namespace MessagingThingService.Settings
{
    public class MessageThingDatabaseSettings : IMessageThingDatabaseSettings
    {
        public string MessagesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
