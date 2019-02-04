using UnityEngine;

public class Player : MonoBehaviour
{
    private float tp;
    public float jumpForce = 7.5f;
    public float Globspeed = 15;
    Rigidbody2D rb;
    private Transform _transform;
    private Animator animator;

    int playerLayer, platformLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();

        platformLayer = LayerMask.NameToLayer("Platform");
        playerLayer = LayerMask.NameToLayer("Player");

        if (Screen.width <= 480) tp = 2.7f;
        else if (Screen.width == 600) tp = 2.9f;
        else if (Screen.width > 600 && Screen.width < 800) tp = 3;
        else if (Screen.width == 800) tp = 3.1f;
        else if (Screen.width >= 1000) tp = 2.7f;
    }
    
    void Update()
    {
        if(rb.velocity.y>0)
        {
            Physics2D.IgnoreLayerCollision(playerLayer,platformLayer,true);
        }
        else if (rb.velocity.y <= 0)
        {
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
        }

        if (Application.platform == RuntimePlatform.Android)
        {
            Move();
        }

        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * (Globspeed / 3), rb.velocity.y);
            if (rb.velocity.x > 0) _transform.eulerAngles = new Vector3(0, 0, 0);
            else if (rb.velocity.x < 0) _transform.eulerAngles = new Vector3(0, 180, 0);
        }
        //телепортация 
        if (transform.position.x < -tp)
        {
            transform.position = new Vector2(transform.position.x * -0.9f, transform.position.y);
        }

        if (transform.position.x >tp)
        {
            transform.position = new Vector2(transform.position.x * -0.9f, transform.position.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            animator.Play("Player");
            if (PlayerPrefs.GetString("Music") == "yes")
            {
                GameObject.Find("JumpAudio").GetComponent<AudioSource>().Play();
            }
        }

        if (rb.velocity.y <= 0)
        {
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }

        }

    }

    private float A = 0;
    private float speed = 20.0f;
    void Move()
    {
        
        Vector2 acceleration = Input.acceleration;        ;
      if (acceleration.sqrMagnitude > 1)
            acceleration.Normalize();
        A = Filter(acceleration.x, A, 0.9f);

        rb.velocity = new Vector2(A * speed, rb.velocity.y);

        if (rb.velocity.x > 0.2)
        {
            _transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (rb.velocity.x < -0.3)
        {
            _transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    float Filter(float b, float lastA, float t)
    {
        return Mathf.Lerp(lastA,b,t);
    }

}