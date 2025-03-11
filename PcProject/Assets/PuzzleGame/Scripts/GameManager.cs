
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject uiToApear;
    CollideAndWin collide;
    
    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<CollideAndWin>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WinGame(string sceneName)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
        collide.winTheGame = false;
        
    }
}
