using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour
{
    public float speed = 1;
    Vector2 direction = new Vector2();
    void Start()
    {
       direction = new Vector2(0,-1); 
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
    }

    public void Disappear()
    {
        Destroy(gameObject);
    } 
}
