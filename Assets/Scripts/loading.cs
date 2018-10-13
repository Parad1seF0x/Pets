using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour {

    public GameObject thisgo;
    public GameObject foledr;
    public GameObject Room1;
    public GameObject cam;
    public GameObject gc;

    // Use this for initialization
    void Start () {
        thisgo = this.gameObject;
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        Room1 = GameObject.FindGameObjectWithTag("Room1");
        gc = GameObject.FindGameObjectWithTag("GameController");
    }
	
	// Update is called once per frame
	void Update () {
        if (thisgo.transform.position.x < 0) {
            thisgo.transform.position += new Vector3(Time.deltaTime, 0, 0);
            thisgo.transform.localScale += new Vector3(Time.deltaTime * 2, 0, 0);
        }
        else
        {
            cam.transform.position = new Vector3(Room1.transform.position.x, Room1.transform.position.y - 0.5f, -10f);

            gc.SetActive(true);
            foledr.SetActive(false);

        }
    }
}
