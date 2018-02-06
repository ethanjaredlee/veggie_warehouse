using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplyDock : MonoBehaviour
{

	private Component _storage;
	
	// Use this for initialization
	void Start () {
		// how to do this
		_storage = GameObject.Find("Storage").GetComponent<storage>();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
/*		_storage.AddStorage();*/
	}
}
