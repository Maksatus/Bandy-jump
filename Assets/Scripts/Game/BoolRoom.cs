using UnityEngine;

public class BoolRoom : MonoBehaviour
{

    public Transform point;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            RoomManager.nextRoom = true;
            RoomManager.nextRoomPoint = point;
            Destroy(gameObject);
        }
    }
}