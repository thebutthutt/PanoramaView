using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContro : MonoBehaviour
{
	public static int cameraLocation = 1;
	public int maxLocations;
	public Transform map;
	public Transform cameraContainer;
	
	public void updateLocation(int input) {
		cameraLocation = input;
		Debug.Log(cameraLocation);
	}
	
	public void incrementLocation() {
		cameraLocation++;
	}
	
	public void decrementLocation() {
		cameraLocation--;
	}
	
	public int getLocation() {
		return cameraLocation;
	}
	
	public void moveCameraTo(int newLocation) {
		cameraContainer.position = map.GetChild(newLocation - 1).position;
		updateLocation(newLocation);
	}
	
	public void moveCameraNext() {
		if (cameraLocation < maxLocations) {
			cameraContainer.position = map.GetChild(cameraLocation).position; //the camera location is the index of the next location
			incrementLocation();
		}
	}
	
	public void moveCameraPrev() {
		if (cameraLocation > 1) {
			cameraContainer.position = map.GetChild(cameraLocation-2).position; 
			decrementLocation();
		}
	}
}
