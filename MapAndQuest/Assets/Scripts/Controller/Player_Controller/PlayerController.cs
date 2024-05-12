using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private bool walkCheck;

    CameraController cam;
    PlayerAnimatorController playerAnim;
    SpriteRenderer sprites;
    public Text player_name;

    void Awake()
    {
        moveSpeed = 10f;
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void Start()
    {
        sprites = GetComponentInChildren<SpriteRenderer>();
        playerAnim = GetComponentInChildren<PlayerAnimatorController>();
        

        
    }
    void FixedUpdate()
    {
        Move(); // get move
        NameUpdate();

    }
    private void Update()
    {
        Jump(); //get jump
    }

    void NameUpdate()
    {
        if (GameManager.Instance.playerName != "" || GameManager.Instance.playerName != null)
        {
            player_name.text = GameManager.Instance.playerName;
        }
        else
        {
            player_name.text = "Debugging";
        }
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
        cam.CameraMove(); // camera move for every fixedUpdate frame
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
