
using UnityEngine;


public class CollideAndWin : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(WinTheGame.winTheGame)
        {
            GameManager gm = FindObjectOfType<GameManager>();
            gm.uiToApear.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Win"))
        {
            WinTheGame.winTheGame = true;
        }
        if (collision.CompareTag("Coin"))
        {
            WinTheGame.winTheGame = true;
        }
    }
    
}
public static class WinTheGame
{
    public static bool winTheGame;
}
