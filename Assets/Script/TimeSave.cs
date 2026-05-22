using UnityEngine;

public class TimeSave : MonoBehaviour
{
    private void Update()
    {
        TimeChanger._currentTime -= Time.deltaTime;
    }
}
