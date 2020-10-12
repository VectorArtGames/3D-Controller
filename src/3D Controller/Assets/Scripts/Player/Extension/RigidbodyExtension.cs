using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player.Extension
{
	public static class RigidbodyExtension
	{
		public static void Translate(this Rigidbody rb, Vector3 position)
		{
			rb.MovePosition(rb.position + position);
		}
	}
}
