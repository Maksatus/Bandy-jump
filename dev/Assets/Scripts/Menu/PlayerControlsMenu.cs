using UnityEngine;

public class PlayerControlsMenu : MonoBehaviour {
    private Animator animator;
    Rigidbody2D rb;
    float jumpForce = 6;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.velocity.y <= 0)
        {
            if (rb != null) 
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }

        }
        if (collision.gameObject.tag == "Platform")
        {
            animator.Play("Player");
            if (PlayerPrefs.GetString("Music") == "yes")
            {
                GameObject.Find("JumpAudio").GetComponent<AudioSource>().Play();
            }
        }

    }

 
}
