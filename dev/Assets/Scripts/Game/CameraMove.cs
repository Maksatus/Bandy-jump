using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform target;
   void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
