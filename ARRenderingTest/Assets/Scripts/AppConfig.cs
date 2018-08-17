using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppConfig : MonoBehaviour {

	public float resolutionScale = 0.5f;

	void Awake()
	{
		// Application.targetFrameRate = 60;
		// Screen.SetResolution(Mathf.RoundToInt(1920 * resolutionScale), Mathf.RoundToInt(1080 * resolutionScale), false);
	}
}
