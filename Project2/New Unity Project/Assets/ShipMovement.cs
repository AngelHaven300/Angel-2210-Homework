using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;
    public float RotationSpeed;
    private Rigidbody2D MyRigidbody2D;
    public GameObject LaserPrefab;
    public GameObject AlienPrefab;
    public AudioSource LaserSound;

    public AudioClip ExplosionSound;
    // Start is called before the first frame update
    void Start()
    {
        MyRigidbody2D = GetComponent<Rigidbody2D>();
        LaserSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float Rotation = Input.GetAxis("Horizontal");
        float FullRotation = Rotation * RotationSpeed;
    }
}
