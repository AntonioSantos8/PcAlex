using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateExplosion : MonoBehaviour
{
    [SerializeField]GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(explosion, mousePos, transform.rotation);
        }
    }
}
