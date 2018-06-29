using UnityEngine;
using System.Collections;

public class Enemy_Controller : MonoBehaviour {

    private GameObject player;
    private UnityEngine.AI.NavMeshAgent nav;

	// Use this for initialization
	void Start () {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
	}
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.transform.position);
	}
}
