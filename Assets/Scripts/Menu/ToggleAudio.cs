using UnityEngine.UI;
using UnityEngine;

public class ToggleAudio : MonoBehaviour {
    [SerializeField]
    Toggle tog;
    
    void Awake () {
        if (PlayerPrefs.GetString("Music") == "no")
            tog.isOn = false;
    }

    public void Song()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }

        if (tog.isOn == true)
        {
            PlayerPrefs.SetString("Music", "yes");
        }
        else if (tog.isOn == false)
        {
            PlayerPrefs.SetString("Music", "no");
        }
    }
}
