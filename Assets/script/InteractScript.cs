using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour {
    public GameObject Player;

    public float TileLength;

    // Use this for initialization
    void Start() { }

    void FixedUpdate() {
        if (Input.GetMouseButtonDown(0)) {
            var mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 player = this.Player.transform.position;
            var x = mouse.x - player.x;
            var y = mouse.y - player.y;

            Vector3 target = new Vector3(0, 0, 0);
            if (Mathf.Abs(x) > Mathf.Abs(y)) {
                //horizontal
                if (x > 0) {
                    //right
                    target = player + new Vector3(this.TileLength, 0);
                }
                else {
                    //left
                    target = player - new Vector3(this.TileLength, 0);
                }
            }
            else {
                //vertical
                if (y > 0) {
                    //up
                    target = player + new Vector3(0, this.TileLength);
                }
                else {
                    //down
                    target = player - new Vector3(0, this.TileLength);
                }
            }

            Instantiate(this.Player, target,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update() { }
}