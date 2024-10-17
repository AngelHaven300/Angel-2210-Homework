using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float Speed = 3.0f;
    public Rigidbody2D r2d;
    public Vector2 LocalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetButtonDown("SpawnAsteroid"))
        {
            
            r2d = GetComponent<Rigidbody2D>();
            Vector3 randPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-3, 3f), 10f);
            r2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            r2d.velocity.Normalize();
            r2d.velocity = r2d.velocity * Speed;
            LocalVelocity = r2d.velocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SpawnAsteroid"))
        {

            r2d = GetComponent<Rigidbody2D>();
            Vector3 randPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-3, 3f), 10f);
            r2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            r2d.velocity.Normalize();
            r2d.velocity = r2d.velocity * Speed;
            LocalVelocity = r2d.velocity;
        }
        r2d.velocity = LocalVelocity;
    }
}
