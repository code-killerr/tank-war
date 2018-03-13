using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed = 5;
    public float round = 30;
    public int number = 1;

    private Rigidbody tank;

    public AudioClip stopAudio;
    public AudioClip drivingAudio;

    private AudioSource audio;

    // Use this for initialization
    void Start () {
        tank = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical for"+number);
        tank.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("Horizontal for"+number);
        tank.angularVelocity = transform.up * h * round;

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            if(audio.isPlaying==false)
            audio.Play();
        }
        else if(Mathf.Abs(h)!=0||Mathf.Abs(v)!=0)
        {
            audio.clip = stopAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }
        
	}
}
