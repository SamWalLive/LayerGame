using UnityEngine;
using System.Collections;

public class RampDisabler : MonoBehaviour {

	private GameObject[] ramps;
	private Renderer rend;

	void Start () {
		ramps = GameObject.FindGameObjectsWithTag ("ToDisable");
		foreach (GameObject ramp in ramps) {
			rend = ramp.GetComponent<Renderer> ();
			rend.enabled = false;
		}
			
	}
}
