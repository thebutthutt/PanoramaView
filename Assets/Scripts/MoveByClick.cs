using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByClick : MonoBehaviour
{
	public float moveSpeed, mult, flingSpeed;
	float horiz, vert;
	Quaternion camUp, contUp, camEnd, contEnd;
	public Transform container;

    void LateUpdate () {
		if (Input.GetMouseButton(0)) {
			horiz = Input.GetAxis("Mouse X");
			vert = Input.GetAxis("Mouse Y");

			container.Rotate(new Vector3(0, horiz*(-1), 0f)*Time.deltaTime*moveSpeed);
			transform.Rotate(new Vector3(vert, 0, 0)*Time.deltaTime*moveSpeed);
		} else if (Input.GetMouseButtonUp(0)) {
			horiz = Input.GetAxis("Mouse X");
			vert = Input.GetAxis("Mouse Y");
			camUp = transform.rotation;
			contUp = container.rotation;
			camEnd = camUp*Quaternion.Euler(0, horiz*(-1)*mult, 0f);
			contEnd = contUp*Quaternion.Euler(vert*mult, 0, 0);
		} else {
			transform.rotation = Quaternion.Lerp(transform.rotation, camEnd, Time.deltaTime*flingSpeed);
			container.rotation = Quaternion.Lerp(transform.rotation, contEnd, Time.deltaTime*flingSpeed);
		}
	}
}
