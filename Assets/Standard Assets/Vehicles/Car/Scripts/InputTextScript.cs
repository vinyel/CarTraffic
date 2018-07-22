using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class InputTextScript : MonoBehaviour {

    InputField inputField;
    [SerializeField] private Dropdown dropdown;

    // Use this for initialization
    void Start () {

        inputField = GetComponent<InputField>();
        
        //Debug.Log(dropdown.captionText.text);
        GameObject carGameObject = GameObject.Find(name: "Car1");

        if (this.transform.name == "InputFieldD") {
            inputField.text = carGameObject.GetComponent<CarAIControl>().allowDist.ToString();
        }
        else if (this.transform.name == "InputFieldS") {
            inputField.text = carGameObject.GetComponent<CarController>().m_Topspeed.ToString();
        }

    }
	
	// Update is called once per frame
	void Update () {

    }

    public void InputLogger() {

        string inputValue = inputField.text;
        
        GameObject carGameObject = GameObject.Find(dropdown.captionText.text);
        if (this.transform.name == "InputFieldD") {
            carGameObject.GetComponent<CarAIControl>().allowDist = float.Parse(inputValue);
        }
        else if (this.transform.name == "InputFieldS") {
            carGameObject.GetComponent<CarController>().m_Topspeed = float.Parse(inputValue);
        }

        //Debug.Log(inputValue);

        //InitInputField();
    }

    public void aiu() {
        //Debug.Log(dropdown.captionText.text);
        GameObject carGameObject = GameObject.Find(dropdown.captionText.text);

        if (this.transform.name == "InputFieldD") {
            inputField.text = carGameObject.GetComponent<CarAIControl>().allowDist.ToString();
        }
        else if (this.transform.name == "InputFieldS") {
            inputField.text = carGameObject.GetComponent<CarController>().m_Topspeed.ToString();
        }
    }
}
