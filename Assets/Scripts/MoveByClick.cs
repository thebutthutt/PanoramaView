using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByClick : MonoBehaviour
{
	public float moveSpeed;
	float horiz, vert;
	public Transform container;

    void LateUpdate () {
		if (Input.GetMouseButton(0)) {
			horiz = Input.GetAxis("Mouse X");
			vert = Input.GetAxis("Mouse Y");

			container.Rotate(new Vector3(0, horiz*(-1), 0f)*Time.deltaTime*moveSpeed);
			transform.Rotate(new Vector3(vert, 0, 0)*Time.deltaTime*moveSpeed);
		}
	}
}
