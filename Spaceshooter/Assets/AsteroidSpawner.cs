using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject AsteroidPrefab;
    public float Speed = 3.0f;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SpawnAsteroid"))
        {
            GameObject myAsteroid = GameObject.Instantiate(AsteroidPrefab, transform.position, transform.rotation);


            Rigidbody2D r2d = myAsteroid.GetComponent<Rigidbody2D>();
            Vector3 randPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-3, 3f), 10f);
            r2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            r2d.velocity.Normalize();
            r2d.velocity = r2d.velocity * Speed;
           
        }
    }
}
