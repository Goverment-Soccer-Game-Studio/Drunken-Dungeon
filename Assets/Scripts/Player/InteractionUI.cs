using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionUI : MonoBehaviour
{
    private Camera mainCam;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI promptText;

    public bool isDisplayed = false;

    private void Start()
    {
        mainCam = Camera.main;

        uiPanel.SetActive(false);
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
}
