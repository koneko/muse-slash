using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNotes : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 thing;

    void Start()
    {
        thing = new Vector2(-1f, 0.0f);
    }

    void FixedUpdate()
    {
        //rb.AddForce(thing * speed);
        rb.MovePosition(rb.position + thing * speed * Time.fixedDeltaTime);
    }
}
