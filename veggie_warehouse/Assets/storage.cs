using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class storage : MonoBehaviour
{
	// initializing public variables
	public Dictionary<string, int> 	StoredItems;		// dictionary of all items stored
	
	
	// Use this for initialization
	void Start ()
	{
		StoredItems = new Dictionary<string, int>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddStorage(string productName, int value)
	{
		if (!StoredItems.ContainsKey(productName))
		{
			StoredItems[productName] = value;
			Debug.Log("just added new item: " + productName + " to storage");
		}
		else
		{
			StoredItems[productName] += value;
			Debug.Log("updated existing item: " + productName);
		}

		Debug.Log(StoredItems);
	}
	
	void OnMouseDown(){
		AddStorage("corn", 5);
	}
}
