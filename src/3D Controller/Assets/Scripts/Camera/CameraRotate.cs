using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
	public Transform Focused;

	public float FollowSpeed;

	public float RotateSpeed;
	private Camera cam;

	private void Awake()
	{
		TryGetComponent(out cam);
	}

    private void FixedUpdate()
    {
	    transform.position = Vector3.Lerp(transform.position, Focused.position, Time.deltaTime * FollowSpeed);
	    transform.Rotate(Vector3.up, Time.deltaTime * RotateSpeed);
    }
}
