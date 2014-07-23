namespace VideoStore.ContentManagement
{
    using NServiceBus;

	public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
        public void Customize(ConfigurationBuilder builder)
        {
            builder.Conventions(UnobtrusiveMessageConventions.Init);
        }
    }
}
