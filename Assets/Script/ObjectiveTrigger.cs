using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        PointClickMovement script = other.gameObject.GetComponent<PointClickMovement>();
        if (script != null)
        {
            Managers.Mission.ReachObjective();
        }
    }
}
