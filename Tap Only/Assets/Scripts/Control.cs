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
            var pos = camera.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(new Vector2(pos.x, pos.y), Vector2.zero);
            if (Physics2D.Raycast(ray.origin, ray.direction))
            {
                GetComponent<Rigidbody2D>().AddForceAtPosition(Force, pos,ForceMode2D.Impulse);
            }
            var x = 0;
        }
	}

    private void OnMouseDown()
    {
        
    }
}
