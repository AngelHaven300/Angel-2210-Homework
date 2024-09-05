using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour
{

    public float speed = 2.0f;
    public Rigidbody2D r2d;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("PLayer 2 Control");
        Vector2 vel = new Vector2(0.0f, direction);
        vel = vel * speed;

        r2d.velocity = vel;

        //transform.Translate(new Vector3(0.0f, direction, 0.0f));
    }
}
