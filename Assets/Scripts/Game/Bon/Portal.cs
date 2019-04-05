using UnityEngine;

public class Portal : MonoBehaviour {
    [SerializeField]
    private Transform portal;
    private int forse=100;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" )
        {
            var player = col.GetComponent<Player>();
            player.SetPosition(portal.position);
            player.SetForce(Vector3.up * forse);
        }
    }   
}
