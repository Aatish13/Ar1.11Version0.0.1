﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArControles : MonoBehaviour
{
    void Start() {
        //   ArSession.SetActive(false);
        if (PlayerPrefs.HasKey("ArMenuHelp"))
        {
            ArMenuHelp.SetActive(false);
        }
        else {
            ArMenuHelp.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ArTransformMenuHelp"))
        {
            ArTransformMenuHelp.SetActive(false);
        }
        else
        {
            ArTransformMenuHelp.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ArMoveXZHelp"))
        {
            ArMoveXZHelp.SetActive(false);
        }
        else
        {
            ArMoveXZHelp.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ArRotateHelp"))
        {
            ArRotateHelp.SetActive(false);
        }
        else
        {
            ArRotateHelp.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ArRotateHelp"))
        {
            ArRotateHelp.SetActive(false);
        }
        else
        {
            ArRotateHelp.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ArScaleHelp"))
        {
            ArScaleHelp.SetActive(false);
        }
        else
        {
            ArScaleHelp.SetActive(true);
        }
        if (PlayerPrefs.HasKey("ArMoveYHelp"))
        {
            ArMoveYHelp.SetActive(false);
        }
        else
        {
            ArMoveYHelp.SetActive(true);
        }

    }

    public GameObject ExitMenu;
    public GameObject ArExitpanel;
    public GameObject ArSession;
    public GameObject ArModePanel;

    public GameObject ArMenuPanel;
    public GameObject ArMenuHelp;

    public GameObject ArTransformMenuPanel;
    public GameObject ArTransformMenuHelp;

    public GameObject ArMoveXZPanel;
    public GameObject ArMoveXZHelp;

    public GameObject ArRotatePanel;
    public GameObject ArRotateHelp;

    public GameObject ArScalePanel;
    public GameObject ArScaleHelp;

    public GameObject ArMoveYPanel;
    public GameObject ArMoveYHelp;


    public void ShareModel() {
#if UNITY_ANDROID
        showAndroidToast();
#else
		Debug.Log("No Toast setup for this platform.");
#endif
    }
    string tostText = "Sharing Mode Is Comming Soon!";
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
        toastParams[1] = tostText;
        toastParams[2] = toastClass.GetStatic<int>
                               ("LENGTH_LONG");

        //call static function of Toast class, makeText
        AndroidJavaObject toastObject =
                        toastClass.CallStatic<AndroidJavaObject>
                                      ("makeText", toastParams);

        //show toast
        toastObject.Call("show");

    }
    public void CloseAll() {
        ExitMenu.SetActive(false);
        ArMenuPanel.SetActive(false);
 ArModePanel.SetActive(false);

ArMenuPanel.SetActive(false);
 ArMenuHelp.SetActive(false);

 ArTransformMenuPanel.SetActive(false);
ArTransformMenuHelp.SetActive(false);

 ArMoveXZPanel.SetActive(false);
 ArMoveXZHelp.SetActive(false);
    ArRotatePanel.SetActive(false);
         ArRotateHelp.SetActive(false);

        ArScalePanel.SetActive(false);
        ArScaleHelp.SetActive(false);
    
        ArMoveYPanel.SetActive(false);
        ArMoveYHelp.SetActive(false);
}

    public void OpenExitMenu() {
        ExitMenu.SetActive(true);
    }
    public void CloseExitMenu() {
        ExitMenu.SetActive(false);
    }

    public void OpenMenu() {
        ArModePanel.SetActive(false);
        ArMenuPanel.SetActive(true);
    }
    public void CloseMenu()
    {
        ArMenuPanel.SetActive(false);
        ArModePanel.SetActive(true);
    }

    public void OpenhelpMenu() {
        ArMenuHelp.SetActive(true);
    }
    public void ClosehelpMenu()
    {
        ArMenuHelp.SetActive(false);
        PlayerPrefs.SetString("ArMenuHelp", "ArMenuHelp");
    }



    public void OpenTransformMenu() {
        ArMenuPanel.SetActive(false);
        ArTransformMenuPanel.SetActive(true);

    }

    public void CloseTransformMenu()
    {
        ArTransformMenuPanel.SetActive(false);
        ArMenuPanel.SetActive(true);

    }

    public void OpenTransformMenuHelp()
    {
   
        ArTransformMenuHelp.SetActive(true);

    }

    public void CloseTransformMenuHelp()
    {
        ArTransformMenuHelp.SetActive(false);
        PlayerPrefs.SetString("ArTransformMenuHelp", "ArTransformMenuHelp");
    }


    public void OpenMoveXZ() {
        ArTransformMenuPanel.SetActive(false);
        ArMoveXZPanel.SetActive(true);
    }
    public void CloseMoveXZ()
    {
        ArTransformMenuPanel.SetActive(true);
        ArMoveXZPanel.SetActive(false);
    }

    public void OpenMoveXZHelp()
    {
      
        ArMoveXZHelp.SetActive(true);
    }
    public void CloseMoveXZHelp()
    {
      
        ArMoveXZHelp.SetActive(false);
        PlayerPrefs.SetString("ArMoveXZHelp", "ArMoveXZHelp");
    }

    public void OpenMoveY()
    {
        ArTransformMenuPanel.SetActive(false);
        ArMoveYPanel.SetActive(true);
    }
    public void CloseMoveY()
    {
        ArTransformMenuPanel.SetActive(true);
        ArMoveYPanel.SetActive(false);
    }
    public void OpenMoveYHelp()
    {
      
        ArMoveYHelp.SetActive(true);
    }
    public void CloseMoveYHelp()
    {
       
        ArMoveYHelp.SetActive(false);
        PlayerPrefs.SetString("ArMoveYHelp", "ArMoveYHelp");
    }

    public void OpenScalePanel()
    {
        ArTransformMenuPanel.SetActive(false);
        ArScalePanel.SetActive(true);
    }
    public void CloseScalePanel()
    {
        ArTransformMenuPanel.SetActive(true);
        ArScalePanel.SetActive(false);
    }
    public void OpenScaleHelp()
    {

        ArScaleHelp.SetActive(true);
      
    }
    public void CloseScaleHelp()
    {
     
        ArScaleHelp.SetActive(false);
        PlayerPrefs.SetString("ArScaleHelp", "ArScaleHelp");
    }
    public void OpenRotatePanel()
    {
        ArTransformMenuPanel.SetActive(false);
        ArRotatePanel.SetActive(true);
    }
    public void CloseRotatePanel()
    {
        ArRotatePanel.SetActive(false);
        ArTransformMenuPanel.SetActive(true);
        
    }
    public void OpenRotateHelp()
    {
        ArRotateHelp.SetActive(true);
    }
    public void CloseRotateHelp()
    {

        ArRotateHelp.SetActive(false);
        PlayerPrefs.SetString("ArRotateHelp", "ArRotateHelp");
    }
}
