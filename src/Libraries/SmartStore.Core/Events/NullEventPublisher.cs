
namespace SmartStore.Core.Events
{
    public class NullEventPublisher : IEventPublisher
    {
        private readonly static IEventPublisher s_instance = new NullEventPublisher();

        public static IEventPublisher Instance => s_instance;

        public void Publish<T>(T eventMessage) where T : class
        {
            // Noop
        }
    }
}
