using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour {
    public GameObject explosion;
    public float time = 1.5f;
    public AudioClip boomm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(boomm, transform.position);
        GameObject.Instantiate(explosion, transform.position, transform.rotation);
        //GameObject.Destroy(explosion.gameObject);
        GameObject.Destroy(this.gameObject);
        if (collider.tag == "tank")
        {
            collider.SendMessage("heal");
        }
    }

}
