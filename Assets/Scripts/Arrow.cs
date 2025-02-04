using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
    public float speed = 1;
    Vector3 direction = Vector3.zero;
    void Start()
    {

    }
    
    void Update()
    {
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }

    public void Disappear()
    {
        Destroy(gameObject);
    } 

    public void SetDirection(Vector3 dir)
    {
        direction = dir.normalized;
    }

}
