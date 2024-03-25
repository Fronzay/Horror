using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonController : MonoBehaviour
{

    [SerializeField] PauseController controller;
    [SerializeField] GameObject setting;

    public void ClickNextButton()
    {
        Time.timeScale = 1;
        controller.pausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExitInMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void ClickSetting()
    {
        setting.SetActive(true);
    }

    public void ExitSetting() 
    {
        setting.SetActive(false);
    }
}
