using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D body;
    public float ballSpeed;
    Status status;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
       
        BallForce();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            status = FindObjectOfType<Status>();
            Destroy(gameObject);
            status.life -= 100;
        }
    }
    void BallForce()
    {
        body.AddForce(Vector2.right * ballSpeed, ForceMode2D.Impulse);
    }
}
