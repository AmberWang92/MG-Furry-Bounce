using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NativeNotificationsController : MonoBehaviour
{
    // [SerializeField] private AndroidNotificationController androidNotificationsController;
    [SerializeField] private IosNotificationsController iosNotificationsController;

    public void Start()
    {
#if UNITY_ANDROID
                androidNotificationsController.RequestAuthorization();
                androidNotificationsController.RegisterNotificationChannel();
                androidNotificationsController.SendNotification("Hello world!",
         "This is notification send from my Unity app", 3);

#elif UNITY_IOS

        StartCoroutine(iosNotificationsController.RequestAuthorization());
        iosNotificationsController.SendNotification("Hello world!",
        "This is body of notification", "This is subtitle!", 3);

#endif

    }
}
