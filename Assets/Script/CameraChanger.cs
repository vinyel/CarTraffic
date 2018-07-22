using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

public class CameraChanger : MonoBehaviour {
    [SerializeField]private GameObject mainCamera;
    [SerializeField]private GameObject otherCamera;

    [SerializeField] private Dropdown dropdown;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("b")) {
            mainCamera.SetActive(!mainCamera.activeSelf);
            otherCamera.SetActive(!otherCamera.activeSelf);
            InputKeyB();
        }
	}
    public void InputKeyB () {
        GameObject tc = GameObject.Find("TraceCamera").gameObject;
        GameObject cameraGameObject = tc.transform.Find("Camera").gameObject;
        
        cameraGameObject.GetComponent<SmoothFollow>().target = GameObject.Find(dropdown.captionText.text).transform;
    } 
}
