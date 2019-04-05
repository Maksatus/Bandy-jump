using System.Collections;
using UnityEngine;

public class Monstr_2 : MonoBehaviour {
    public float speed = 0.7f;
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private GameObject obj_2;
    [HideInInspector]
    public float dist;

    void Start()
    {

        if (Screen.width <= 480) dist = 2.4f;
        else if (Screen.width == 600) dist = 2.48f;
        else if (Screen.width > 600 && Screen.width < 800) dist = 2.15f;
        else if (Screen.width == 800) dist = 2.5f;
        else if (Screen.width >= 1000 && Screen.width < 1400) dist = 1.8f;
        else if (Screen.width > 1500) dist = 2.7f;

        StartCoroutine(instObj());
    }
    [HideInInspector]
    public bool a = false;

    void Update()
    {
        Move();
    }
   


    IEnumerator instObj()
    {
        bool bol = true;
        while (true)
        {
            if (bol)
            {
                Instantiate(obj, new Vector2(transform.position.x+(speed/2), transform.position.y), Quaternion.identity);
                bol = false;
            }
            else
            {
                Instantiate(obj_2, new Vector2(transform.position.x+(speed/2), transform.position.y), Quaternion.identity);
                bol = true;
            }

            yield return new WaitForSeconds(2);
        }
    }

    void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x >= dist && !a)
        {
            speed = -speed;
            a = true;
        }

        if (transform.position.x <= -dist && a)
        {
            speed = -speed;
            a = false;
        }

    }
}
