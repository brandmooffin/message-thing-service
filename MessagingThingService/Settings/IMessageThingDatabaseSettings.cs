namespace MessagingThingService.Settings
{
    public interface IMessageThingDatabaseSettings
    {
        string MessagesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
