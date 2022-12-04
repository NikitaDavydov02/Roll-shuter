using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour {

    [SerializeField]
    private string itemName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        PlayerCharacter script = other.gameObject.GetComponent<PlayerCharacter>();
        if (script != null)
        {
            Managers.Inventory.AddItem(itemName);
            Destroy(this.gameObject);
        }
    }
}
