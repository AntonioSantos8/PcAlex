using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    public static int pontos;
    [SerializeField] TMP_Text pontosTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontosTxt.text = "Pontos: " + pontos.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            AumentarPontuacao();
            Destroy(gameObject);
        }
    }
    void AumentarPontuacao()
    {
        pontos++;
    }
}
