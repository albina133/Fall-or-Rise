using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private Animator Anim;
    
    [SerializeField]private float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Anim = GetComponent<Animator>();
    }
    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        
        Anim.SetFloat("MoveX", rb.velocity.x);
        Anim.SetFloat("MoveY", rb.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            Anim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            Anim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
