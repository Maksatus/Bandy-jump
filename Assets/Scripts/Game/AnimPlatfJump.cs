using UnityEngine;

public class AnimPlatfJump : MonoBehaviour {
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
        void OnCollisionEnter2D()
    {
        animator.Play("Jump");
    }
}
