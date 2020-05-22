using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationService : MonoBehaviour
{

    void Start()
    {
        // Uncomment this method to enable OneSignal Debugging log output 
        // OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);

        // Replace 'YOUR_ONESIGNAL_APP_ID' with your OneSignal App ID.
        /*  OneSignal.StartInit("304f088e-ae41-449c-8de9-e6fe459b40b1")
            .HandleNotificationOpened(HandleNotificationOpened)
            .Settings(new Dictionary<string, bool>() {
            { OneSignal.kOSSettingsAutoPrompt, false },
            { OneSignal.kOSSettingsInAppLaunchURL, false } })
            .EndInit();

          OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;

          // The promptForPushNotifications function code will show the iOS push notification prompt. We recommend removing the following code and instead using an In-App Message to prompt for notification permission.
          OneSignal.PromptForPushNotificationsWithUserResponse(OneSignal_promptForPushNotificationsReponse);


      }
          private void OneSignal_promptForPushNotificationsReponse(bool accepted)
          {
              Debug.Log("OneSignal_promptForPushNotificationsReponse: " + accepted);
          }
          // Gets called when the player opens the notification.
          private static void HandleNotificationOpened(OSNotificationOpenedResult result)
              {
              }
      }
      */
    }
}