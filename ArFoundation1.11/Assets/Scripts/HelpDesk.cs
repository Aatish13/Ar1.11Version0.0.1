using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpDesk : MonoBehaviour
{
    public GameObject TopMenu;
    public GameObject GuidePanel;
    public GameObject AddProjectPanel;

    void Start()
    {
        if (PlayerPrefs.HasKey("GuidePanel"))
        {
            GuidePanel.SetActive(false);
        }
        else {
            GuidePanel.SetActive(true);
        }
    }

    public void OpenGuidePanel() {

        TopMenu.SetActive(false);
        GuidePanel.SetActive(true);
    }
    public void CloseGuidePanel() {
        GuidePanel.SetActive(false);
        if (!PlayerPrefs.HasKey("GuidePanel")) {
            PlayerPrefs.SetString("GuidePanel", "GuidePanel");
        }
    }

    public void OpenAddProject() {
        TopMenu.SetActive(false);
        AddProjectPanel.SetActive(true);
    }
    public void CloseAddProject()
    {
        AddProjectPanel.SetActive(false);
    }
    public void AddProjectMail() {
        string email = "admin@studiooneeleven.co";
        string subject = MyEscapeURL("Add New Project");
        string body = MyEscapeURL("");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }

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
