
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{

    public float damage;
    protected void Teste()
    {
        throw new System.NotImplementedException();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IDamageable player))
        {
            player.TakeDamage(damage);
        }
    }
}
