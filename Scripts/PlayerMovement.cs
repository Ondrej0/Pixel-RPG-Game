using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; //Player speed 

    private Rigidbody2D rb;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical).normalized * speed;

        rb.velocity = movement;

        animator.SetFloat("Speed", Mathf.Abs(Mathf.Abs(horizontal) + Mathf.Abs(vertical)));
    }
}
