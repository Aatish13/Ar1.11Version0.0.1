using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using NatSuite.Sharing;

public class ScreenShoot : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject ExitPanel;
    public GameObject Watermark;

    public GameObject SSPanel;
    public RawImage SSImage;


    WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();

    Texture2D ssTexture;
    public IEnumerator TakeSnapshot()
    {
        yield return frameEnd;

        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, true);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.LoadRawTextureData(texture.GetRawTextureData());
        texture.Apply();
        ssTexture = texture;
        SSImage.texture = texture;

        SSPanel.SetActive(true);
        // gameObject.renderer.material.mainTexture = TakeSnapshot;
    }
    public void TakeSS() {
        MenuPanel.SetActive(false);
        ExitPanel.SetActive(false);
        StartCoroutine(TakeSnapshot());
        
    }


    public void ShareSS() {
        SSPanel.SetActive(true);
        var payload = new SharePayload();
        payload.AddImage(ssTexture);
        payload.Commit();
    }

    public void Close() {
        ssTexture = Texture2D.whiteTexture;
        SSPanel.SetActive(false);
        MenuPanel.SetActive(true);
        ExitPanel.SetActive(true);
    }
}
