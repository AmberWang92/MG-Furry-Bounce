using UnityEngine;
using System.Collections;
using Unity.Notifications.iOS;
using System;

public class NotificationController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
#if UNITY_IOS
        StartCoroutine(RequestAuthorization());
#endif
        var timeTrigger = new iOSNotificationTimeIntervalTrigger()
        {
            TimeInterval = new TimeSpan(0, 0, 5),
            Repeats = false
        };

        var notification = new iOSNotification()
        {
            // You can specify a custom identifier which can be used to manage the notification later.
            // If you don't provide one, a unique string will be generated automatically.
            Identifier = "_notification_01",
            Title = "Furry Bounce",
            Body = "Scheduled at: " + DateTime.Now.ToShortDateString() + " triggered in 5 seconds",
            Subtitle = "Furry wants to bounce!",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = timeTrigger,
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }

    IEnumerator RequestAuthorization()
    {
        var authorizationOption = AuthorizationOption.Alert | AuthorizationOption.Badge;
        using (var req = new AuthorizationRequest(authorizationOption, true))
        {
            while (!req.IsFinished)
            {
                yield return null;
            }
            ;

            string res = "\n RequestAuthorization:";
            res += "\n finished: " + req.IsFinished;
            res += "\n granted :  " + req.Granted;
            res += "\n error:  " + req.Error;
            res += "\n deviceToken:  " + req.DeviceToken;
            Debug.Log(res);
        }
    }

}
