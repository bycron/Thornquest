using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bramble : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
    private Rigidbody2D rb;
    private Animator animate;
    private Vector2 moveAmount;

    private void Start() 
    {
        animate = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() 
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * playerSpeed;

        if (moveInput != Vector2.zero) {
            animate.SetBool("isMoving", true);
        }
        else {
            animate.SetBool("isMoving", false);
        }
    }
    private void FixedUpdate() 
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);
    }

}
