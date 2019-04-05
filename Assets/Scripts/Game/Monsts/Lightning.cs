using System.Collections;
using UnityEngine;

public class Lightning : DestroyPlayer
{
    Color _color;
    public float curAlpha = 1.0f;
    Renderer _renderer;
    bool bol = false;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        curAlpha = _renderer.material.color.a;
        _color = _renderer.material.color;
    }

      new void OnTriggerEnter2D(Collider2D col)
    {
        Prover(col);
        StartCoroutine(Des());
    }


    void Update()
    {
        if (bol)
        {
            curAlpha -= ((Time.deltaTime) * 1.8f);
            _color.a = curAlpha;
            _renderer.material.color = _color;
            if (curAlpha <= 0.001f)
            {
                Destroy(gameObject);
                bol = true;
            }
        }

    }
    IEnumerator Des()
    {
        yield return new WaitForSeconds(2.8f);
        bol = true;
    }
}
