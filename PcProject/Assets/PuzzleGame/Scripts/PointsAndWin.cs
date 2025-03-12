using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsAndWin : MonoBehaviour
{
    int timeToLoose = 20;
    public TMP_Text textTimeToLoose;
    CollideAndWin collideAndWin;
    // Start is called before the first frame update
    
    void Start()
    {
        textTimeToLoose.text = "Time to loose: " + timeToLoose.ToString();
        StartCoroutine(Loose());
    }

    // Update is called once per frame
    void Update()
    {
        
        Win();
    }
    void Win()
    {
        if (PointsFase3.pontos >= 10)
        {
            collideAndWin = FindObjectOfType<CollideAndWin>();
            collideAndWin.winTheGame = true;
        }
    }
    IEnumerator Loose()
    {
        while(timeToLoose <= 20)
        {
            yield return new WaitForSeconds(1);
            timeToLoose--;
            textTimeToLoose.text = "Time to loose: " + timeToLoose.ToString();
            if(timeToLoose == 0)
            {
                SceneManager.LoadScene("Puzzle3");
            }
        }

       
    }
}
