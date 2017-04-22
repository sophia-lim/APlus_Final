using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public bool triggered;
    public GameObject triggerPlane;
    //public Material daySkybox;
    //public Material nightSkybox;
    //public Material skybox;

    public GameObject sun;

    public float duration = 2.0f;
    //public Renderer rend;

	// Use this for initialization
	void Start () {

        triggered = false;
        Debug.Log(triggered);
        sun.GetComponent<AutoIntensity>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (triggered) {
            sun.GetComponent<AutoIntensity>().enabled = true;
        }
	}

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject == triggerPlane) {
            Debug.Log("On collider hit.");
            triggered = true;

        }
    }
    
}
