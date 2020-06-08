using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashboardUI : MonoBehaviour
{





    public GameObject Manual;
    public List<GameObject> ManualPages=new List<GameObject>();
    int ManualIndex = 0;

    public GameObject HelpDesk;

    public GameObject JoinRoom;
    public GameObject JoinRoomP1;
    public GameObject JoinRoomP2;


    public GameObject FurniturePanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }




    public void onShowToastClicked()
    {
#if UNITY_ANDROID
       showAndroidToast();
#else
		Debug.Log("No Toast setup for this platform.");
#endif
    }

    string toastText = "Furniture Library Coming Soon.....";

    private void showAndroidToast()
    {
        //create a Toast class object
        AndroidJavaClass toastClass =
                    new AndroidJavaClass("android.widget.Toast");

        //create an array and add params to be passed
        object[] toastParams = new object[3];
        AndroidJavaClass unityActivity =
          new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        toastParams[0] =
                     unityActivity.GetStatic<AndroidJavaObject>
                               ("currentActivity");
        toastParams[1] = toastText;
        toastParams[2] = toastClass.GetStatic<int>
                               ("LENGTH_LONG");

        //call static function of Toast class, makeText
        AndroidJavaObject toastObject =
                        toastClass.CallStatic<AndroidJavaObject>
                                      ("makeText", toastParams);

        //show toast
        toastObject.Call("show");

    }

    public void OpenMenuDesk() {
        ManualIndex = 0;
        foreach (GameObject g in ManualPages) {
            g.SetActive(false);
          
        }
        Manual.SetActive(true);
        ManualPages[0].SetActive(true);
    }
    public void CloseMenuDesk() {
        Manual.SetActive(false);
        foreach (GameObject g in ManualPages)
        {
            g.SetActive(false);

        }
    }

 
    public void NextManual() {
            if (ManualIndex <= ManualPages.Count - 1) {

            ManualPages[ManualIndex].SetActive(false);

            ManualIndex++;
            ManualPages[ManualIndex].SetActive(true);
        }
    }
    public void previousManual()
    {
         if (ManualIndex >0)
            {

            ManualPages[ManualIndex].SetActive(false);

            ManualIndex--;
            ManualPages[ManualIndex].SetActive(true);
        }
    }

    public void OpenHelpDesk() {
        HelpDesk.SetActive(true);

    }
    public void CloseHelpDesk() {
        HelpDesk.SetActive(false);
    }

    public void OpenJoinRoom() {
        JoinRoomP2.SetActive(false);
        JoinRoomP1.SetActive(true);
        JoinRoom.SetActive(true);
    }

    public void CloseJoinRoom() {
        JoinRoom.SetActive(false);
    }

    public void OpenJoinRoomP2() {
        JoinRoomP1.SetActive(false);
        JoinRoomP2.SetActive(true);
    }
    public void CloseJoinRoomP2()
    {
        JoinRoomP2.SetActive(false);
        JoinRoomP1.SetActive(true);
    }

    public GameObject FurniturePanel1, FurniturePanel2;

    public void OpenFurniturePanel() {
        FurniturePanel1.SetActive(true);
        FurniturePanel2.SetActive(false);
        FurniturePanel.SetActive(true);

    }

    public void CloseFurniturePanel()
    {

        FurniturePanel1.SetActive(true);
        FurniturePanel2.SetActive(false);
        FurniturePanel.SetActive(false);

    }

    public void NextFurniturePanel() {
        FurniturePanel1.SetActive(false);
        FurniturePanel2.SetActive(true);
    }

    public void PreviousFurniturePanel()
    {
        FurniturePanel2.SetActive(false);
        FurniturePanel1.SetActive(true);
    }
}
