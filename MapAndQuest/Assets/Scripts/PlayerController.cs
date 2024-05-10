using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private bool walkCheck;

    PlayerAnimatorController playerAnim;
    SpriteRenderer sprites;

    void Awake()
    {
        moveSpeed = 10f;
    }

    private void Start()
    {
        sprites = GetComponentInChildren<SpriteRenderer>();
        playerAnim = GetComponentInChildren<PlayerAnimatorController>();
    }
    void FixedUpdate()
    {
        Move();
        
        
    }
    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            playerAnim.Jumping();
        }
        else
        {
            playerAnim.NotJumping();
        }
    }


    void Move()
    {
        Vector3 movePosition = Vector3.zero;

        walkCheck = false;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            movePosition += Vector3.left;
            sprites.flipX = true;
            walkCheck = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            movePosition += Vector3.right;
            sprites.flipX = false;
            walkCheck = true;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            movePosition += Vector3.down;
            walkCheck = true;

        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            movePosition += Vector3.up;
            walkCheck = true;
        }

        if (walkCheck)
            playerAnim.Walking();
        else
            playerAnim.notWalking();

        transform.position += movePosition * moveSpeed * Time.deltaTime;
    }
    


}
