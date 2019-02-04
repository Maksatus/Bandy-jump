using UnityEngine;
using UnityEngine.UI;
public class BestCount : MonoBehaviour {

    public Text txt;
    int recrods;

	void Update () {
        recrods = PlayerPrefs.GetInt("Records");

        if (recrods > 0)
        {
            txt.text = recrods.ToString(); ;
        }
        else
            txt.text = 0.ToString() ;
    }
	

}
