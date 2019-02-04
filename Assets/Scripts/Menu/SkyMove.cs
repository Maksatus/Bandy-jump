using System.Collections;
using UnityEngine;

public class SkyMove : MonoBehaviour {

    public float speed = 0.9f;
    public int time;
    bool status;


    void Update()
    {
        
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (status==false)
        {
            status = true;
            StartCoroutine(GiveCloud());
        }
        
    }

    IEnumerator  GiveCloud()
    {
        yield return new WaitForSeconds(time);
        transform.position = new Vector2(transform.position.x*-1,transform.position.y);
        status = false;
    }
}
