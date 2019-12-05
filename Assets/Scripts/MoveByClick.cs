using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByClick : MonoBehaviour
{
	public float moveSpeed, mult, flingSpeed;
	float horiz = 0f, vert = 0f, x, y;
	Quaternion camUp, contUp, camEnd, contEnd;
	public Transform container;

    void LateUpdate () {
		if (Input.GetMouseButton(0)) {
			horiz = Input.GetAxis("Mouse X");
			vert = Input.GetAxis("Mouse Y");

			container.Rotate(new Vector3(0f, horiz*(-1), 0f)*Time.deltaTime*moveSpeed);
			transform.Rotate(new Vector3(vert, 0f, 0f)*Time.deltaTime*moveSpeed);
		}
	}
}
