using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Counter : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<UnityEngine.UI.Text>().text = GameObject.FindWithTag("Player").GetComponent<Player_Controller>().coins.ToString();
	}
}
