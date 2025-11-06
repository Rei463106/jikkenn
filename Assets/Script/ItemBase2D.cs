using UnityEngine;

public abstract class ItemBase2D : MonoBehaviour
{
    CursorPractice2 _cursorPractice2;
    /// <summary>
    /// Animation‚Ì‹““®Žw’è
    /// </summary>
    [SerializeField] GameObject _animeGameObject;
    public Animator _animator;
    public string animationName;
    public virtual void Activate()
    {
        _animator.SetTrigger(animationName);
    }
    public void Awake()
    {
        _animeGameObject = GameObject.Find("AnimationSquare");
        _animator = _animeGameObject.GetComponent<Animator>();
    }
    private void Start()
    {
        _cursorPractice2 = FindAnyObjectByType<CursorPractice2>();

    }
    public void PushButton()
    {
        _cursorPractice2.GetItem(this);
    }
}
