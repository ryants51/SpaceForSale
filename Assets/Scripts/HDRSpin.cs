﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDRSpin : MonoBehaviour
{
	[SerializeField]
	private float PlanetSpeed;
	
	// Update is called once per frame
	void Update ()
	{
		RenderSettings.skybox.SetFloat("_Rotation", Time.time * -(PlanetSpeed));
	}
}