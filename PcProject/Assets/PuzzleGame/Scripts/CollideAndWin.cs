
using UnityEngine;


public class CollideAndWin : MonoBehaviour
{
    public AudioClip winAudio;
    AudioSource winAudioSource;
    // Update is called once per frame
    private void Start()
    {
        winAudioSource = GetComponent<AudioSource>();
    }
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
            winAudioSource.PlayOneShot(winAudio);
            WinTheGame.winTheGame = true;
            WinTheGame.podeTOfa = true;
        }
        if (collision.CompareTag("Coin"))
        {
            winAudioSource.PlayOneShot(winAudio);
            WinTheGame.winTheGame = true;
            WinTheGame.podeTOfa = true;

        }
    }
    
}
public static class WinTheGame
{
    public static bool winTheGame;
    public static bool podeTOfa;
}
