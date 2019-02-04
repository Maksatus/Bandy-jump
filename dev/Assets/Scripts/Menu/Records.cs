using UnityEngine;
using UnityEngine.UI;

public class Records : MonoBehaviour {


    int recrods;
    public Text txt;

 

    void Update ()
    {
        recrods = PlayerPrefs.GetInt("Records");

        if (recrods > 0)
        {
            txt.text = recrods.ToString(); ;
        }
        else
            txt.text = 0.ToString();
    }
}
