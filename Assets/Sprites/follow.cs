using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
    public Transform player1;
    public Transform player2;

    private Vector3 offset;
    private Camera camera;

    public GameObject wintext;
	// Use this for initialization
	void Start () {
        offset = transform.position - (player1.position + player2.position) / 2;
        camera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance;
        float size;
        if (player1 == null)
        {
            transform.position = player2.position + offset;
            size = 2.8f;
            wintext.SetActive(true);
        }
        else if (player2 == null)
        {
            transform.position = player1.position + offset;
            size = 2.8f;
            wintext.SetActive(true);
        }
        else
        {
            transform.position = (player1.position + player2.position) / 2 + offset;
            distance = Vector3.Distance(player1.position, player2.position);
            size = distance * 0.54f;
        }
        camera.orthographicSize = size;
    }
}
