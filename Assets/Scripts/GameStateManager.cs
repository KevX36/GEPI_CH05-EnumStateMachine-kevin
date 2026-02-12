using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        None,
        paused,
        Init,
        MainMenu,
        GamePlay,
        GameOver,
        Settings,
    }
    [SerializeField] private UIManager UI;
    public GameState currentState { get; private set; }
    public GameState lastState { get; private set; }
    [Header("debug (read only)")]
    [SerializeField] private string currentActiveState;
    [SerializeField] private string lastActiveState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetState(GameState.Init);
    }

    // Update is called once per frame
    public void SetState(GameState newState)
    {
        if(currentState == newState)
        {
            return;
        }
        lastState = currentState;
        currentState = newState;
        currentActiveState = currentState.ToString();
        lastActiveState = lastState.ToString();
        OnStateChange(lastState, currentState);
    }
    private void OnStateChange(GameState previousState, GameState newState)
    {
        switch (newState)
        {
            case GameState.None:

                Debug.Log("this should not be possiable, if this is not the last state then something is very wrong");
                break;



            case GameState.Init:

                Debug.Log("GameState set to Init");


                SetState(GameState.MainMenu);



                break;


            case GameState.MainMenu:

                Debug.Log("inMainMenu");

                UI.ShowMainMenu();
                break;





            case GameState.GamePlay:


                UI.ShowGameplayUI();


                break;




            case GameState.paused:

                UI.ShowPauseUI();



                break;

            case GameState.GameOver:

                UI.ShowGameOver();




                break;

            case GameState.Settings:


                UI.ShowSettingsUI();




                break;




        }
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentState == GameState.MainMenu)
            {
                SetState(GameState.GamePlay);
                return;
            }

            else if (currentState == GameState.GamePlay)
            {
                SetState(GameState.paused);
                return;
            }

            else if (currentState == GameState.paused)
            {
                SetState(GameState.Init);
                return;
            }
        }
    }

    public void StartGame()
    {
        SetState(GameState.GamePlay);
    }
    public void OnPause()
    {
        if(currentState == GameState.GamePlay)
        {
            SetState(GameState.paused);
        }
        else
        {
            SetState(GameState.GamePlay);
        }
    }

    public void OnGameOver()
    {
        if( currentState != GameState.GamePlay)
        {
            return;
        }
        SetState(GameState.GameOver);
    }

    public void OpenSettings()
    {
        SetState(GameState.Settings);
    }
    public void ReturnToMenu()
    {
        SetState(GameState.MainMenu);
    }
    public void ReturnFromSettings()
    {
        SetState(lastState);
    }










}
