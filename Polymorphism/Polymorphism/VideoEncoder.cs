using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationCHannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationCHannel>();
        }

        public void Encode(Video video)
        {
            //Video Encoding logic
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        } 

        public void RegisterNotificationChannel(INotificationCHannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
