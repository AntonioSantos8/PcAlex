using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsAndWin : MonoBehaviour
{
    public AudioClip winAudio;
    AudioSource winAudioSource;
    int timeToLoose = 40;
    public TMP_Text textTimeToLoose;
    
    
    // Start is called before the first frame update
    
    void Start()
    {
        winAudioSource = GetComponent<AudioSource>();
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
        if (PointsFase3.pontos >= 10 && WinTheGame.podeTOfa)
        {
            
            WinTheGame.winTheGame = true;
            Time.timeScale = 0;

            winAudioSource.PlayOneShot(winAudio);
            WinTheGame.podeTOfa = false;    
        }

    }
    IEnumerator Loose()
    {
        while(timeToLoose <= 40)
        {
            yield return new WaitForSeconds(1);
            timeToLoose--;
            textTimeToLoose.text = "Time to loose: " + timeToLoose.ToString();
            if(timeToLoose == 0)
            {
                SceneManager.LoadScene("Puzzle3");
                PointsFase3.pontos = 0;
            }
        }

       
    }
}
