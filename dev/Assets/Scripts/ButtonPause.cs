using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPause : MonoBehaviour {

    public float time;
    public bool isPaused=false;
    public GameObject pause;
    public GameObject kill;
    public GameObject ButtonPaus;

    void Update()
    {
        Time.timeScale = time;

        if(Input.GetKeyDown(KeyCode.Escape)&& isPaused == false && kill.activeSelf == false )
        {
            isPaused = true; 
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused == true && kill.activeSelf == false)
        {
            isPaused = false;
        }

        if (isPaused == true)
        {
            time = 0;
            pause.SetActive(true);
        }
        else if (isPaused == false && DestroyPlayer.statusDeath == false)
        {
            time = 1;
            pause.SetActive(false);
        }

        if (DestroyPlayer.statusDeath==true)
        {
            time = 0;
            kill.SetActive(true);
            ButtonPaus.SetActive(false);
            DestroyPlayer.statusDeath = false;
            if (PlayerPrefs.GetString("Music") == "yes")
            {
                GameObject.Find("LoseAudio").GetComponent<AudioSource>().Play();
            }
        }
 
    }

    public void ResumeButton(bool state)
    { 
            isPaused = state;
    }
   
    public void PauseResume(bool state)
    {
            isPaused = state;
    }

    public void Menu()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("Menu");
        Pas();
    }

   public void Again()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
        {
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("Game");
        Pas();
    }

 public void Pas()
    {
        time = 1;
        kill.SetActive(false);
        ButtonPaus.SetActive(true);
    }
}
