using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject SettingUI;
    [SerializeField] private GameObject GameOverUI;
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
        Time.timeScale = 1f;
    }
    public void ShowPauseUI()
    {
        HideAllUI(true);
        Time.timeScale = 0.0f;
        
        pauseUI.gameObject.SetActive(true);
    }
    public void ShowSettingsUI()
    {
        HideAllUI(true);
        SettingUI.gameObject.SetActive(true);
    }
    public void ShowGameOver()
    {
        HideAllUI();
        GameOverUI.gameObject.SetActive(true);
    }
    public void HideAllUI()
    {
        mainMenuUI.gameObject.SetActive(false);
        gameplayUI.gameObject.SetActive(false);
        pauseUI.gameObject.SetActive(false);
        SettingUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
    }
    public void HideAllUI(bool HideGamePlay)
    {
        mainMenuUI.gameObject.SetActive(false);
        
        pauseUI.gameObject.SetActive(false);
        SettingUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
    }
}
