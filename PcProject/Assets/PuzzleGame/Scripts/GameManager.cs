
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class GameManager : MonoBehaviour
{
    public GameObject uiToApear;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void WinGame(string sceneName)
    {
        
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
        WinTheGame.winTheGame = false;
        
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
