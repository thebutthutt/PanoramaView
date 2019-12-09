using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeUI : MonoBehaviour
{
	public Transform target;
	
    void Update()
    {
        if (target != null) {
			transform.LookAt(target);
			transform.rotation = transform.rotation * Quaternion.Euler(90f, 0f, 0f);
		}
    }
}
