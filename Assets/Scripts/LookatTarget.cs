using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatTarget : MonoBehaviour
{
    public Transform mTarget;

    private float mspeed = 10.0f;

    private const float EPSILON = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mTarget.position);
        if ((transform.position - mTarget.position).magnitude > EPSILON)
        {            
            transform.Translate(0.0f, 0.0f, mspeed * Time.deltaTime);
        }
    }
}
