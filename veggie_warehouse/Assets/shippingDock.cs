using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shippingDock : MonoBehaviour
{

	private GameObject _storage;
	
	// Use this for initialization
	void Start () {
		
		_storage = GameObject.Find("Storage");		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown()
	{
		_storage.GetComponent<storage>().RemoveStorage("corn", 5);
	}
}
