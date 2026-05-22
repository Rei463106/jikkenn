using UnityEngine;
using UnityEngine.UI;


public class TimeChanger : MonoBehaviour
{
    [Header("タイマーテキスト")]
    [SerializeField] private Text _timerText;
    [Header("テスト")]
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _transform;
    public static float _currentTime = 30;

    // _currentShipHp -= damage;より、この二つもstaticにすれば行けそう…。
    //GameOverもどこからでも呼び出せるようにstaticにしておく…。
    private void Update()
    {
        _currentTime -= Time.deltaTime;
        _timerText.text = _currentTime.ToString();

        Invoke("DestroyObject", 3);

        _camera.gameObject.transform.position = _transform.position;
    }

    private void DestroyObject()
    {
        _gameObject.SetActive(false);
    }
}
