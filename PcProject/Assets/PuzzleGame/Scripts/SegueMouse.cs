using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueMouse : MonoBehaviour
{
    public GameObject magnect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; 
        transform.position = mousePos;

        if (Input.GetMouseButtonDown(0))
        {
            magnect.SetActive(true);
        }
        if(Input.GetMouseButtonUp(0))
        {
            magnect.SetActive(false);
        }
    }
}
