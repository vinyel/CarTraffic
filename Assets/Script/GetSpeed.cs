using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpeed : MonoBehaviour {
    private Rigidbody _rigidbody;
	// Use this for initialization
	void Start () {
        GameObject carObject = GameObject.Find("CarWaypointBased");
        _rigidbody = carObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            // 速度ベクトルを表示
            Debug.Log("速度ベクトル: " + _rigidbody.velocity);

            // 速度を表示
            Debug.Log("速度: " + _rigidbody.velocity.magnitude);
        }
    }
}
