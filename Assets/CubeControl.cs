using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(1f * x * Time.deltaTime, 0, y * Time.deltaTime);
    }
}
