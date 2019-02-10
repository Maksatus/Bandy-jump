using UnityEngine;

public class MoveSinPlatform : MonoBehaviour
{
    float dt = 0;

    void Update()
    {
        dt += Time.deltaTime;
        transform.Translate (Mathf.Cos(dt) * Time.deltaTime, Mathf.Sin(dt)*Time.deltaTime , 0);
    }

}
