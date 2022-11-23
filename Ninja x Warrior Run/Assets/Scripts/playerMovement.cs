using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float playerjumpForce = 12f;

    private Rigidbody2D playerBody;


    private bool IsGrounded = true;
    private string groundTag = "Ground";
    
    

    [SerializeField]
    private Animator Anim;


    private void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        playerJump();
    }
    void playerJump()
    {
        if (Input.GetButton("Jump") && IsGrounded)

        {
            
            IsGrounded = false;
            playerBody.AddForce(new Vector2(0f, playerjumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(groundTag))
        {
            IsGrounded = true;
        }
    }
}