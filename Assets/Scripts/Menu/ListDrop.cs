using UnityEngine;
using UnityEngine.UI;
public class ListDrop : MonoBehaviour {

    public Dropdown dropdown;

    void Start()
    {
       if( PlayerPrefs.GetString("Managements") == "Tilt")
        {
            dropdown.value = 0;
        }
       else
            dropdown.value = 1;
    }
    public void ChoseDrop()
    {
        if (dropdown.value == 0)
        {  
            PlayerPrefs.SetString("Managements", "Tilt");
        }
        if (dropdown.value == 1)
        {
            PlayerPrefs.SetString("Managements", "Button");
        }
    }
}
