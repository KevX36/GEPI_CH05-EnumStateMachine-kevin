using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        None,
        paused,
        Init,
        MainMenu,
        GamePlay,
    }
    private UIManager UI;
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


                break;





            case GameState.GamePlay:





                break;




            case GameState.paused:





                break;








        }
    }
}
