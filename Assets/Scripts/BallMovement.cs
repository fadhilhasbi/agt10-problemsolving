using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Problem 2
public class BallMovement : MonoBehaviour
{
    // Inisiasi komponen Rigidbody2D dengan nama variabel rb
    private Rigidbody2D rb;

    private void Awake()
    {
        //Mengambil komponen Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Membuat object bergerak menggunakan atribut AddForce di rigidbody2D
        rb.AddForce(new Vector2(3, 2));
    }
}
