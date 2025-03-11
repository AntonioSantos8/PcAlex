using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public float jumpStrength;
    [SerializeField] GameObject jumpTag; 
    Vector2 move;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckGrounded();

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        Debug.Log(Time.timeScale);
    }

    void Move()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move.x * moveSpeed, rb.velocity.y); 
    }

    void Jump()
    {
        
        rb.AddForce(new Vector2(0, jumpStrength), ForceMode2D.Impulse);
    }

    void CheckGrounded()
    {
        
        isGrounded = Physics2D.OverlapCircle(jumpTag.transform.position, 0.1f, LayerMask.GetMask("Floor"));
    }
}
