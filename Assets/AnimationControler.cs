using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationControler : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Update()
    {
        float multiplier = Input.GetKey(KeyCode.LeftShift) ? 2 : 1;

        _animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")) * multiplier);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Jump");
        }
    }

}
