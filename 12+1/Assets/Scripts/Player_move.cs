using System.Numerics;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    private float MovementSpeed = 2f;
    private Vector2 MovementDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        rb.linearVelocity = MovementDirection * MovementSpeed;
    }
}
