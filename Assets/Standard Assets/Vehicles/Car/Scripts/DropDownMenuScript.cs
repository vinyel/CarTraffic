using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenuScript : MonoBehaviour {

    [SerializeField] private Dropdown dropdown;

    private List<GameObject> carObjectList = new List<GameObject>(); 
    // Use this for initialization
    void Start () {
        GameObject carGameObject = GameObject.Find("CarObject");
        foreach (Transform transform in carGameObject.transform) {
            dropdown.options.Add(new Dropdown.OptionData { text = transform.name });
            carObjectList.Add(transform.gameObject);
            
        }
        //dropdown.options.Add(new Dropdown.OptionData { text = "Item #1" });
        //dropdown.options.Add(new Dropdown.OptionData { text = "Item #2" });
        //dropdown.options.Add(new Dropdown.OptionData { text = "Item #3" });

        dropdown.RefreshShownValue();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
