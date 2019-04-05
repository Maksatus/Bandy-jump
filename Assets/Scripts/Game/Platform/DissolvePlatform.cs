using UnityEngine;

public class DissolvePlatform : Platform{

    Color _color;
    public float curAlpha = 1.0f;
    Renderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        curAlpha = _renderer.material.color.a;
        _color = _renderer.material.color;
        this.platformLife = 1;//Жизнь растворяющейся платформы равна 1. То есть при первом же касании она начнёт умирать.
    }

    void Update()
    {
        if (this.platformLife == 0)
        {
            curAlpha -= ((Time.deltaTime) * 1.8f);
            _color.a = curAlpha;
            _renderer.material.color = _color;
            if (curAlpha <= 0.001f)
            {
                Destroy(gameObject);
            }
        }

    }


}

