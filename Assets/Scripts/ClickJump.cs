using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickJump : MonoBehaviour
{
	public Transform end, cameraContainer;

	void OnMouseUp() {
		Jump();
	}

	public void Jump () {
		cameraContainer.position = end.position;
	}
}
