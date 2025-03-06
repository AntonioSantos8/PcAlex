using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField] AudioClip gameTheme;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
#if UNITY_EDITOR
        if (MusicController.instance != null)
        {
            MusicController.SetMusic(gameTheme);
            return;
        }
#endif
        MusicController.SetMusic(gameTheme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
