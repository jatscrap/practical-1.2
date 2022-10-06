using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * 5;
        float v = Input.GetAxis("Vertical") * 5;
        print(v);
        transform.rotation = Quaternion.Euler(v, 0, h);

    }
}
