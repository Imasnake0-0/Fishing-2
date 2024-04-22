using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    public VectorValue pos;

    void Start()
    {
        transform.position = pos.initialPosition;
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
