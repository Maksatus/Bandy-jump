using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public static float  score=0;
    private Transform target;
    public Text txt;

	void Start () {

        target = GameObject.Find("Player").transform;
        score = 0;
    }

	void Update () {

        EnterScore();
    }

    void EnterScore()
    {
        if (target.position.y > score)
        {
            score = (int)target.position.y;
            txt.text = score.ToString();
        }
    }

}
