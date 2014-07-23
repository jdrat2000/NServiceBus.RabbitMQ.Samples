namespace VideoStore.Sales
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, UsingTransport<RabbitMQ>
    {
        public void Customize(ConfigurationBuilder builder)
        {
            builder.Conventions(UnobtrusiveMessageConventions.Init);
        }

        public void Init(Configure config)
        {
            config.RijndaelEncryptionService();
        }
    }

}
