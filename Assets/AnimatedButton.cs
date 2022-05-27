using UnityEngine;
using UnityEngine.EventSystems;

public class AnimatedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Animator _animator;

    public void OnPointerDown(PointerEventData eventData)
    {
        _animator.SetTrigger("down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _animator.SetTrigger("up");
    }    
}
