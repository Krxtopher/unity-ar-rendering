using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TapToPlace : MonoBehaviour
{   
	public ARSessionOrigin arSpace;

	public GameObject targetObject;


	private List<ARRaycastHit> hitResults = new List<ARRaycastHit>();


	void Update()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			hitResults.Clear();
			arSpace.Raycast(Input.GetTouch(0).position, hitResults);
			if (hitResults.Count > 0)
			{
				ARRaycastHit firstHitResult = hitResults[0];
				PositionTargetObject(firstHitResult.pose.position);
			}


		}
	}


	private void PositionTargetObject(Vector3 position)
	{
		targetObject.transform.position = position;
	}
}
