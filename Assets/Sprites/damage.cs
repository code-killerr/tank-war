using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour {
    public int hp = 100;

    public GameObject play;

    public AudioClip tankdamageaudio;

    public Slider hpSlider;

    private int totalhp;
	// Use this for initialization
	void Start () {
        totalhp = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void heal()
    {
        //if (hp <= 0) return;
        hp -= Random.Range(10, 20);
        hpSlider.value = (float)hp / totalhp;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankdamageaudio, transform.position);
            GameObject.Instantiate(play, transform.position, transform.rotation);
            GameObject.Destroy(this.gameObject);
            return;
        }

    }
}
