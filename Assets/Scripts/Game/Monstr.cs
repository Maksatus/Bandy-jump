using UnityEngine;

public class Monstr : DestroyPlayer {
    float dt = 0;

    new void OnTriggerEnter2D(Collider2D col)
    {
        Prover(col);
    }

    void Update()
    {
        dt += Time.deltaTime;
        transform.Translate (Mathf.Cos(dt) * Time.deltaTime, Mathf.Sin(dt)*Time.deltaTime , 0);
    }
}
