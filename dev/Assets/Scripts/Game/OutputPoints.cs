using UnityEngine;
using UnityEngine.UI;

public class OutputPoints : MonoBehaviour {
   
    int recrods;
    public Text count;
    public Text bestCount;


    void Update () {
        count.text = "Your score: " + Score.score;
        recrods = PlayerPrefs.GetInt("Records");

        if (recrods < (int)Score.score)
        {
            recrods = (int)Score.score; 
            PlayerPrefs.SetInt("Records", recrods);
        }
        
        if (recrods > 0)
        {
            bestCount.text = "Your best score: " + recrods;
        }
        else
            bestCount.text = "Your best score: " + 0;


    }
	
	
}
