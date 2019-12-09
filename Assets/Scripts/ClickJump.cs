using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickJump : MonoBehaviour
{
	public Transform end, cameraContainer;
	public int endLocation;
	public GameObject control;

	void OnMouseUp() {
		Jump();
	}

	public void Jump () {
		cameraContainer.position = end.position;
		control.GetComponent<GameContro>().updateLocation(endLocation);
	}
}
