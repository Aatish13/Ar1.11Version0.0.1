using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpDesk : MonoBehaviour
{
    // Start is called before the first frame update
   public void SendEmail()
    {
        string email = "admin@studiooneeleven.co";
        string subject = MyEscapeURL("Ar1.11 Application ");
        string body = MyEscapeURL("");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }


    public void CallUs (){
        Application.OpenURL("tel://9408685866");
    }
    public GameObject ComingSoonPanel;

    public void CommingSoon() {
        ComingSoonPanel.SetActive(true);
        StartCoroutine(waitfor1sec());
    }
    IEnumerator waitfor1sec()
    {
        ComingSoonPanel.SetActive(true);
        yield return new WaitForSeconds(1);
        ComingSoonPanel.SetActive(false);
    }
}
