
using UnityEngine;


public class CollideAndWin : MonoBehaviour
{
    public static bool winTheGame;

    // Update is called once per frame
    void Update()
    {
        if(winTheGame)
        {
            GameManager gm = FindObjectOfType<GameManager>();
            gm.uiToApear.SetActive(true);
            Time.timeScale = 0;
        }
        if(Time.timeScale == 0)
        {
            winTheGame = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Win"))
        {
            winTheGame = true;
        }
        if (collision.CompareTag("Coin"))
        {
            winTheGame = true;
        }
    }
    
}
