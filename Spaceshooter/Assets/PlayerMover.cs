using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    private Rigidbody2D MyRigidbody2D;
    public GameObject BulletPrefab;
    public GameObject AsteroidPrefab;
    public AudioSource BulletSound;

    public AudioClip ExplosionSound;

    public List<bullet> Bullets = new List<bullet>();
    // Start is called before the first frame update
    void Start()
    {
        MyRigidbody2D = GetComponent<Rigidbody2D>();
        BulletSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float Rotation = Input.GetAxis("Horizontal");
        float FullRotation = Rotation * RotationSpeed;
        MyRigidbody2D.MoveRotation(MyRigidbody2D.rotation + (FullRotation * Time.deltaTime));

        if(Input.GetAxis("Vertical") > 0f)
        {
            Debug.Log("Vector is : " + (transform.forward * (Speed * Input.GetAxis("Vertical"))));
            MyRigidbody2D.AddForce(transform.up * (Speed * Input.GetAxis("Vertical")));
        }

        if(Input.GetButtonDown("Fire1"))
        {
            GameObject myBullet = GameObject.Instantiate(BulletPrefab, transform.position, transform.rotation);
            Bullets.Add(myBullet.GetComponent<bullet>());
            BulletSound.Play();
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            //Destroy(Bullets[0]);
           // Destroy(Bullets[1]);
           foreach(bullet singleBullet in Bullets)
            {
                if (singleBullet != null)
                {
                    Destroy(singleBullet.gameObject);
                }
            }
            Bullets.Clear();
            BulletSound.PlayOneShot(ExplosionSound);
        }

        
        
    }

}
