using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideAndWin : MonoBehaviour
{
    bool winTheGame;

    // Update is called once per frame
    void Update()
    {
        if(winTheGame)
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
            winTheGame = true;
        }
    }
    
}
