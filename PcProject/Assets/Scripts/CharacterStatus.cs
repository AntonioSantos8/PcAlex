using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    public float life;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float damage)
    {
        life -= damage;
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
  

}
