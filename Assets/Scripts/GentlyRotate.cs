using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GentlyRotate : MonoBehaviour
{
    public float rpm;
    void Update()
    {
        transform.Rotate(new Vector3(0f, 6.0f, 0f)*Time.deltaTime*rpm);
    }
}
