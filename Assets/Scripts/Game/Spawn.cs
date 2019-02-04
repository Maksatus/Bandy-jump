using UnityEngine;

public class Spawn : MonoBehaviour {
    public Transform[] platform;
    public bool ganerate;
    private float tp;

	void Awake () {

        if (Screen.width <= 480) tp = 2.4f;
        else if (Screen.width == 600) tp = 2.48f;
        else if (Screen.width > 600 && Screen.width < 800) tp = 2.15f;
        else if (Screen.width == 800) tp = 2.5f;
        else if (Screen.width >= 1000) tp = 1.8f;
        else if (Screen.width > 1500 ) tp = 2.7f;
        GenerateStart();
    }


    void GenerateStart () {
        if (ganerate)
        {
            for (int i =0;i<platform.Length;i++)
            {
                Vector2 p;

                p = new Vector2(Random.Range(-tp, tp), platform[i].position.y);
                platform[i].position = p;
            }
        }
		
	}
}
