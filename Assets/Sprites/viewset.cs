using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewset : MonoBehaviour {
    public GameObject camera1;
    public GameObject camera2;
    public GameObject mcamera;
    public KeyCode viewKey = KeyCode.V;
    private int flag=0;
    public GameObject ui1;
    public GameObject ui2;
    public GameObject player1;
    public GameObject player2;
    public GameObject button;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(viewKey)&&flag==0)
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            mcamera.SetActive(true);
            ui1.SetActive(false);
            ui2.SetActive(true);
            flag = 1;
        }
        else if (Input.GetKeyDown(viewKey) && flag == 1)
        {
            camera1.SetActive(true);
            camera2.SetActive(true);
            mcamera.SetActive(false);
            ui1.SetActive(true);
            ui2.SetActive(false);
            flag = 0;
        }
        if (player1 == null || player2 == null)
        {
            button.SetActive(true);
        }
    }
}
