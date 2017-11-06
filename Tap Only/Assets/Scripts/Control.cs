using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public Vector2 Force;
    public GameObject CameraObject;
    new Camera camera;

	// Use this for initialization
	void Start () {
        if (CameraObject)
            camera = CameraObject.GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
	}

    private void OnMouseDown()
    {
        
    }
}
