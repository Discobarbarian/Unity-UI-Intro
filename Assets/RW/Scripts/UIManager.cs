using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator StartButton;
    public Animator SettingsButton;
    public Animator Dialog;
    public Animator ContentPanel;
    public Animator GearImage;
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        StartButton.SetBool("isHidden", true);
        SettingsButton.SetBool("isHidden", true);
        Dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        StartButton.SetBool("isHidden", false);
        SettingsButton.SetBool("isHidden", false);
        Dialog.SetBool("isHidden", true);
    }

    public void ToggleMenu()
    {
        bool isHidden = ContentPanel.GetBool("isHidden");
        ContentPanel.SetBool("isHidden", !isHidden);
        GearImage.SetBool("isHidden", !isHidden);
    }
}
