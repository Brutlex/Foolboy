using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    public float jump;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public GameObject rayOrigin;
    public float rayCheckDistance;
    Rigidbody2D rb;
    public BoxCollider2D boxCollider;

    public Transform groundCheck;

    public Animator animator;

    private bool grounded = false;
    public bool crouch;
    public GameObject powerup;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        powerup.SetActive(true);
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
            animator.SetFloat("speed", Mathf.Abs(x));

        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {

            RaycastHit2D hit = Physics2D.Raycast(rayOrigin.transform.position, Vector2.down, rayCheckDistance);
            if (hit.collider != null)
            {
                animator.SetBool("isJumping", true);
                rb.velocity = Vector2.up * jump;
            }
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            animator.SetBool("isJumping", false);
        }
        else if(rb.velocity.y>0 && !Input.GetButton("Jump")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        rb.velocity = new Vector3(x * speed, rb.velocity.y, 0);

        //crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(GetComponent<CharacterController>() != null)
            {
                boxCollider = this.GetComponent<BoxCollider2D>();
            }
           
            animator.SetBool("isCrouching", true);
            crouch = true;
            boxCollider.size = new Vector2(2.41f,2.8f);
            boxCollider.offset = new Vector2(-0.13f, 0f);
        } else if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("isCrouching", false);
            crouch = false;
            boxCollider.size = new Vector2(2.41f, 4.89f);
            boxCollider.offset = new Vector2(-0.13f, 0f);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            this.transform.parent = collision.transform;
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            print("dead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            this.transform.parent = null;
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.tag == "Powerup")
        {
            jump = jump * 1.5f;
            powerup.SetActive(false);
        }
    }
}
