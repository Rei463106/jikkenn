using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampTest : MonoBehaviour
{
    [SerializeField] float minX = -5f;
    [SerializeField] float maxX = 5f;
    [SerializeField] float minY = -3f;
    [SerializeField] float maxY = 3f;

    void Update()
    {
        Vector3 pos = transform.position;

        // ‚±‚±‚ÅˆÚ“®ˆ—i—áj
        pos += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0)
               * Time.deltaTime * 5f;

        // ”ÍˆÍ§ŒÀ
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }

}
