using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private static readonly int isWalking = Animator.StringToHash("IsWalking");
    private static readonly int isJumping = Animator.StringToHash("IsJumping");
    public Animator animator;

    // Start is called before the first frame update

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    public void Walking()
    { 
        animator.SetBool(isWalking, true);
    }
    public void notWalking()
    {
        animator.SetBool(isWalking, false);
    }
    public void Jumping()
    {
        animator.SetBool(isJumping, true);
    }
    public void NotJumping()
    {
        animator.SetBool(isJumping, false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
