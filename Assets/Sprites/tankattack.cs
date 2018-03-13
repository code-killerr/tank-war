using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankattack : MonoBehaviour {
    public GameObject fire;
    //private GameObject fire;

    public GameObject Shell;

    public float shellspeed = 20;

    public KeyCode fireKey = KeyCode.Space;

    public AudioClip attackaudio;
	// Use this for initialization
	void Start () {
        //fire = GameObject.Find("Fire");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            //GameObject.Instantiate(Shell, fire.transform.position, fire.transform.rotation);
            AudioSource.PlayClipAtPoint(attackaudio, transform.position);
            GameObject go = GameObject.Instantiate(Shell, fire.transform.position, fire.transform.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
        }
	}
}
