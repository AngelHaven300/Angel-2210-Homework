using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D r2d;
    public Vector2 LocalVelocity;
    public float Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
       ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        r2d.velocity = LocalVelocity; 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        LocalVelocity = Vector2.Reflect(LocalVelocity, collision.GetContact(0).normal);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit Trigger");
        transform.position = new Vector3(0.03f, -0.02f, 6.253493f);
        
        ResetBall();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0.03f, -0.02f, 6.253493f);
        r2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        r2d.velocity.Normalize();
        r2d.velocity = r2d.velocity * Speed;
        LocalVelocity = r2d.velocity;
    }
}
