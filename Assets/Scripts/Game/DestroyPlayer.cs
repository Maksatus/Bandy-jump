using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	public static bool statusDeath = false;


   public void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            print("gameover");
            statusDeath = true;
            if (PlayerPrefs.GetString("Music") == "yes")
            {
                GameObject.Find("LoseMuz").GetComponent<AudioSource>().Play();
            }
        }
    }
}
