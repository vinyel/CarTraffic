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

        //Debug.Log(inputValue);

        //InitInputField();
    }

    public void aiu() {
        //Debug.Log(dropdown.captionText.text);
        GameObject carGameObject = GameObject.Find(dropdown.captionText.text);

        if (this.transform.name == "InputFieldD") {
            inputField.text = carGameObject.GetComponent<CarAIControl>().allowDist.ToString();
        }
    }
}
