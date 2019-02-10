using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static bool nextRoom;
    public static Transform nextRoomPoint;
    public int curRoom;
    public GameObject[] prefabs;

    void Update()
    {
        if (nextRoom)
        {
            Instantiate(prefabs[Random.Range(1, curRoom)], nextRoomPoint.position, Quaternion.identity);
            nextRoom = false;
            nextRoomPoint = null;
        }
    }
}

