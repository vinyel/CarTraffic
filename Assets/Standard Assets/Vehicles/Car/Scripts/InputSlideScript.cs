using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class InputSlideScript : MonoBehaviour {
    private Slider slider;
    private float speed;
    [SerializeField] private Dropdown dropdown;
    GameObject carGameObject;
    private string selectedCarName;

    // Use this for initialization
    void Start () {
        carGameObject = GameObject.Find(name: "Car1");
        slider = GetComponent<Slider>();
        slider.value = carGameObject.GetComponent<CarController>().m_Topspeed;
        speed = slider.value;
    }
	
	// Update is called once per frame
	void Update () {
        selectedCarName = dropdown.captionText.text;
        ChangeSpeed();
    }
    public void ChangeSpeed () {
        
        carGameObject = GameObject.Find(selectedCarName);
        carGameObject.GetComponent<CarController>().m_Topspeed = slider.value;
    }
}
