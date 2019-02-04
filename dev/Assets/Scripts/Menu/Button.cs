using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {

    void Start()
    {
        if (PlayerPrefs.GetInt("Status")!=1)
        {
            PlayerPrefs.SetString("Music", "yes");
            PlayerPrefs.SetInt("Status",1);
        }
    }

    public void OnClickStart()
    {
        
        if (PlayerPrefs.GetString("Music")=="yes"){
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("Game");
    }

    public void OnClickSetting()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("Setting");
    }
   
    public void Exit()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("Menu");
    }
    public void Song()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }
        
        if (PlayerPrefs.GetString("Music")!= "yes")
        {
            PlayerPrefs.SetString("Music", "yes");
        }
        else
        {
            PlayerPrefs.SetString("Music", "no");
        }
           
    }
}
