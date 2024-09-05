using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D r2d;
    public Vector2 LocalVelocity;

    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(-3f, 1f);
        LocalVelocity = r2d.velocity;
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
}
