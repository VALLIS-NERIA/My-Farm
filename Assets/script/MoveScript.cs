using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate() {
        var delta = new Vector3(0, 0, 0);
        delta.x += Input.GetAxis("Horizontal");
        delta.y += Input.GetAxis("Vertical");
        this.transform.localPosition += delta * this.Speed * Time.fixedDeltaTime;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
