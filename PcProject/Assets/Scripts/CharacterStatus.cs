using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour
{
    [SerializeField] float lifeMax;
    [SerializeField] float speed;
    float life;

    public float LifeMax { get => lifeMax;}
    public float Speed { get => speed;}

    // Start is called before the first frame update
    void Awake()
    {
        life = lifeMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected abstract void Teste();//Obriga o filho a implementar
    protected virtual void Teste2()//Permite que o filho sobrescreva
    {
        //Possui corpo executável
    }
}
