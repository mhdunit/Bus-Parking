using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OneSignalPushNotification : MonoBehaviour {
    public String OneSignalID;
void Start()
{
    // Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
    // OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);

    OneSignal.StartInit(OneSignalID)
      .HandleNotificationOpened(HandleNotificationOpened)
      .EndInit();

    OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;
}

// Gets called when the player opens the notification.
private static void HandleNotificationOpened(OSNotificationOpenedResult result)
{
}
}
