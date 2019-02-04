using UnityEngine;

public class MoveYplatform : Platform {

    public float dist = 2;
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, dist * Mathf.Abs(Mathf.Sin(Time.timeSinceLevelLoad))+pos.y, transform.position.z);
      
    }
}
