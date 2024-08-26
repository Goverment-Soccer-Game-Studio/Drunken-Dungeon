using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] PlayerData playerData;
    private Camera mainCam;
    [Header("Interaction")]
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI promptText;
    public bool isDisplayed = false;

    [Header("Input")]
    [SerializeField] InputManager inputManager;

    [Header("Pause Menu")]
    [SerializeField] GameObject pauseGameObj;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] Slider vsensSlider;
    [SerializeField] Slider hsensSlider;
    [SerializeField] TMP_Text vsensTxt;
    [SerializeField] TMP_Text hsensTxt;

    [Header("Player UI")]
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text healthTxt;


    private void Start()
    {
        mainCam = Camera.main;

        uiPanel.SetActive(false);
    }

    private void Update()
    {
        pauseGameObj.SetActive(inputManager.gamePaused);
        healthBar.fillAmount = playerData.health / playerData.maxHealth;
        healthTxt.text = playerData.health.ToString();

        //Sentivity Settings
        inputManager.mouseCamera.sensX = hsensSlider.value;
        inputManager.mouseCamera.sensY = vsensSlider.value / 100;
        hsensTxt.text = (Mathf.Round(hsensSlider.value) / 100).ToString();
        vsensTxt.text = vsensSlider.value.ToString();
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
        CloseSettingsMenu();
    }

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
