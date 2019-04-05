using UnityEngine;

public class MovePlatform : MonoBehaviour {

    public float speed = 2;

    [HideInInspector]
    public float dist;

    void Start()
    {

        if (Screen.width <= 480) dist = 2.4f;
        else if (Screen.width == 600) dist = 2.48f;
        else if (Screen.width > 600 && Screen.width < 800) dist = 2.15f;
        else if (Screen.width == 800) dist = 2.5f;
        else if (Screen.width >= 1000) dist = 1.8f;
        else if (Screen.width > 1500) dist = 2.7f;
        
    }
    [HideInInspector]
    public bool a=false;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        
        if (transform.position.x >= dist && !a)
        {
            speed = -speed;
            a = true;
        }
            
        if (transform.position.x <= -dist && a )
        {
            speed = -speed;
            a = false;
        }
            
    }
}

