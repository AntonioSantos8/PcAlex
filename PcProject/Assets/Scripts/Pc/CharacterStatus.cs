using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour
{
    float life;
    [SerializeField] float lifeMax;
    [SerializeField] float speed;

    public float LifeMax { get => lifeMax; }
    public float Speed { get => speed; }

    // Start is called before the first frame update
    void Awake()
    {
        life = lifeMax;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
