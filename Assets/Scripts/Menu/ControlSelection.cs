using UnityEngine;

public class ControlSelection : MonoBehaviour {

    public GameObject control;
    void Start()
    {
        if (PlayerPrefs.GetInt("condition")==1)
        {
            control.SetActive(false);
        }
        else
        {
            control.SetActive(true);
            PlayerPrefs.SetInt("condition", 1);
        }
    }
	public void TiltControl()
    {
        PlayerPrefs.SetString("Managements","Tilt");
        control.SetActive(false);
    }
    public void ButtonControl()
    {
        PlayerPrefs.SetString("Managements", "Button");
        control.SetActive(false);
    }
}
