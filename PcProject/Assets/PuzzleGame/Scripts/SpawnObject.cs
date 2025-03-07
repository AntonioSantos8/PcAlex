
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;
    bool canSpawnBall;
    float topScreen = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        canSpawnBall = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (IsMouseAtTop() && canSpawnBall)
        {
            ObjectSpawnMouse(ball);
        }
    }
    void ObjectSpawn(GameObject objectToSpawn, Transform placeToSpawn)
    {
        Instantiate(objectToSpawn, placeToSpawn);
    }
    void ObjectSpawnMouse(GameObject objectToSpawn)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectToSpawn, mousePos, transform.rotation);
            canSpawnBall = false;
        }
    }
    bool IsMouseAtTop()
    {
        return Input.mousePosition.y >= Screen.height - topScreen;
    }

}
