using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    [SerializeField] TMP_Text pontosTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontosTxt.text = "Pontos: " + PointsFase3.pontos.ToString();
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
        PointsFase3.pontos++;
    }
}
public static class PointsFase3
{
    public static int pontos;
}
