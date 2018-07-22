using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class ToggleScript : MonoBehaviour {

    Toggle toggle;
    [SerializeField] private Dropdown dropdown;

    // Use this for initialization
    void Start () {
        toggle = GetComponent<Toggle>();

        GameObject carGameObject = GameObject.Find(name: "Car1");
        toggle.isOn = carGameObject.GetComponent<CarAIControl>().m_Driving;
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void IsOn() {
        bool isOn = toggle.isOn;

        GameObject carGameObject = GameObject.Find(dropdown.captionText.text);
        
        carGameObject.GetComponent<CarAIControl>().m_Driving = isOn;
        
    }
    public void aiu() {
        //Debug.Log(dropdown.captionText.text);
        GameObject carGameObject = GameObject.Find(dropdown.captionText.text);
        toggle.isOn = carGameObject.GetComponent<CarAIControl>().m_Driving;
        
    }
}
