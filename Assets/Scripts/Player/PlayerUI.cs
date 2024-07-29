using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    private Camera mainCam;
    [Header("Interaction")]
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI promptText;
    public bool isDisplayed = false;

    [Header("Input")]
    [SerializeField] InputManager inputManager;

    [Header("Pause Menu")]
    [SerializeField] GameObject pauseGameObj;


    private void Start()
    {
        mainCam = Camera.main;

        uiPanel.SetActive(false);
    }

    private void Update()
    {
        pauseGameObj.SetActive(inputManager.gamePaused);
    }

    public void Setup(string promptText)
    {
        this.promptText.text = promptText;
        uiPanel.SetActive(true);
        isDisplayed = true;
    }

    public void Close()
    {
        isDisplayed = false;
        uiPanel.SetActive(false);
    }

    public void UIResumeGame()
    {
        inputManager.ResumeGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
