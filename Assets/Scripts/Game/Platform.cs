using UnityEngine;

public class Platform : MonoBehaviour
{

    public float platformLife = -1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            platformLife--;
        }

    }
}