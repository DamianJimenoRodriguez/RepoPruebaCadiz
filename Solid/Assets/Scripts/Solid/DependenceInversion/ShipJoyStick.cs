using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipJoyStick : MonoBehaviour, IShipInput
{
	public FixedJoystick joyStick;
	public float Horizontal { get; private set; }

	public float Vertical { get; private set; }

	private void Update()
	{
		Horizontal = joyStick.Horizontal;
		Vertical = joyStick.Vertical;
	}
}