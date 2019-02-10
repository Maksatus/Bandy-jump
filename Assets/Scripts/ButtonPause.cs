using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPause : MonoBehaviour {

    public float time;
    public bool isPaused=false;
    public GameObject pause;
    public GameObject kill;
    public GameObject ButtonPaus;
    public GameObject move;

    void Start()
    {
        if (PlayerPrefs.GetString("Managements") == "Button")
        {
            move.SetActive(true);
        }
        else
        {
            move.SetActive(false);
        }
    }


    void Update()
    {
        Time.timeScale = time;

        if (Input.GetKeyDown(KeyCode.Escape)&& isPaused == false && kill.activeSelf == false )
        {
            isPaused = true;
            if (PlayerPrefs.GetString("Managements") == "Button")
                move.SetActive(false);
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused == true && kill.activeSelf == false)
        {
            isPaused = false;
            if (PlayerPrefs.GetString("Managements") == "Button")
                move.SetActive(true);
        }

        if (isPaused == true)
        {
            time = 0;
            pause.SetActive(true);
        }
        else if (isPaused == false )
        {
            time = 1;
            pause.SetActive(false);  
        }

        if (DestroyPlayer.statusDeath==true)
        {
            move.SetActive(false);
            time = 0;
            kill.SetActive(true);
            ButtonPaus.SetActive(false);
            
        }
    }

    public void ResumeButton(bool state)
    { 
            isPaused = state;
        if (PlayerPrefs.GetString("Managements") == "Button")
            move.SetActive(false);
    }
   
    public void PauseResume(bool state)
    {
            isPaused = state;
        if (PlayerPrefs.GetString("Managements") == "Button")
            move.SetActive(true);
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
        DestroyPlayer.statusDeath = false;
        time = 1;
        kill.SetActive(false);
        ButtonPaus.SetActive(true);
        
    }
}
