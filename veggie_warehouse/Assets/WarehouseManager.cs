using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using NUnit.Framework;
using UnityEngine;

public class WarehouseManager : MonoBehaviour {
	// I'm attaching this to the camera cuz idk where to rlly put this
	
	// basically just holds shit like actions, pay, satisfaction, etc all in a 
	// consolidated public place so we can edit it however we want @dt is this bad practice?

	public List<string> Actions;
	public int Day;
	public List<string> SupportedProducts;
	public float Satisfaction;				// tbd if we want scale or less analog measure (rn out of 100)
	
	// Use this for initialization
	void Start ()
	{
		Day = 0;
		
		// initializing actions
		// tbh not sure this is necessary
		Actions = new List<string> {"addItem"};

		SupportedProducts = new List<string>
		{
			"Broccoli",
			"Corn",
			"Eggplant",
		};

		Satisfaction = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void NextDay()
	{
		Day += 1;
		
	}

	void GenerateNewOrders()
	{
		
	}
}
