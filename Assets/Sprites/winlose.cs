using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlose : MonoBehaviour {

    public GameObject wintext1;

    public GameObject losetext1;

    public GameObject losetext2;

    public GameObject wintext2;

    public GameObject player1;

    public GameObject player2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player1 == null)
        {
            losetext1.SetActive(true);
            wintext1.SetActive(true);
        }
        if (player2 == null)
        {
            losetext2.SetActive(true);
            wintext2.SetActive(true);
        }
    }
}
