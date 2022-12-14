using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
	public float movementSpeed = 20;
	public float rotationSpeed = 60;

	// Update is called once per frame
	private void Update()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
		transform.position += transform.forward * movementSpeed * Time.deltaTime * vertical;
	}
}