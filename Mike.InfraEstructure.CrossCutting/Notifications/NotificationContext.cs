﻿using Flunt.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace Mike.InfraEstructure.CrossCutting.Notifications
{
    public class NotificationContext
    {
        public IReadOnlyCollection<Notification> Notifications;

        public void SetNotification(IReadOnlyCollection<Notification> notifications)
        {
            Notifications = notifications.ToList();
        }
    }
}

