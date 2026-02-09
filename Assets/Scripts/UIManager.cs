using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject pauseUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ShowMainMenu()
    {
        HideAllUI();
        mainMenuUI.gameObject.SetActive(true);
    }
    public void ShowGameplayUI()
    {
        HideAllUI();
        gameplayUI.gameObject.SetActive(true);
    }
    public void ShowPauseUI()
    {
        HideAllUI();
        pauseUI.gameObject.SetActive(true);
    }
    public void HideAllUI()
    {
        mainMenuUI.gameObject.SetActive(false);
        gameplayUI.gameObject.SetActive(false);
        pauseUI.gameObject.SetActive(false);
    }
}
