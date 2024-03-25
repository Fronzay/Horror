using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] GameObject panelAvtors;
    [SerializeField] GameObject setting;


    public void ClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void ClickAvtors()
    {
        panelAvtors.SetActive(true);
    }
    public void ClickAvtorsExit()
    {
        panelAvtors.SetActive(false);
    }

    public void ClickSetting()
    {
        setting.SetActive(true);
    }

    public void ClickSettingExit()
    {
        setting.SetActive(false);
    }

    public void ExitInGame()
    {
        Application.Quit();
    }
}
