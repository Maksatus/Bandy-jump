using UnityEngine;

public class Destory : MonoBehaviour {
    //public static bool statusDeath=false;
 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!(col.gameObject.tag == "Player"))
        {
            Destroy(col.transform.gameObject); 
        }
       /* if (col.gameObject.tag == "Player")
        {
            print("gameover");
            statusDeath = true;
        }*/

    }

}
