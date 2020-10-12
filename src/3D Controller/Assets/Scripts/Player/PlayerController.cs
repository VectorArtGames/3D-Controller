using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Player.Extension;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;

	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask GroundCheckLayer;

	public float Speed;

	public bool IsGrounded { get; set; }

	private void Awake()
	{
		TryGetComponent(out rb);
	}

    // Update is called once per frame
    private void Update()
    {
	    if (Input.GetButton("Horizontal"))
			rb.Translate(new Vector3(Speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0));
	    else if (Input.GetButton("Vertical"))
		    rb.Translate(new Vector3(0, 0, Speed * Time.deltaTime * Input.GetAxis("Vertical")));
		else if (IsGrounded && Input.GetButtonUp("Jump"))
		    rb.velocity = new Vector3(0, 5, 0);
	}

    private void FixedUpdate()
    {
	    IsGrounded = Physics.CheckSphere(GroundCheck.transform.position, GroundCheckRadius, GroundCheckLayer);
    }

    private void OnDrawGizmosSelected()
    {
		Gizmos.DrawWireSphere(GroundCheck.transform.position, GroundCheckRadius);
    }
}
