using UnityEngine;
public class MoveSuperPlatform :MovePlatform {

    bool MouseDown = false;
    
    void OnMouseDown()
    {
        MouseDown = true;
    }
    void OnMouseUp()
    {
        MouseDown = false;
    }
    void Update()
    {
        Vector3 cursor = Input.mousePosition;
        cursor = Camera.main.ScreenToWorldPoint(cursor);
        cursor.z = 0;
        
            if (MouseDown)
            {
                transform.position = cursor;
            }
     
    }
}
