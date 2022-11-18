using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineTest : MonoBehaviour
{
	public enum States
	{
		chasing,
		idle,
		attacking
	}

	public States currentStates = States.idle;

	private void Update()
	{
		StateMachine();
	}

	public void StateMachine()
	{
		switch (currentStates)
		{
			case States.chasing:
				Chasing();
				break;

			case States.idle:
				Idle();
				break;

			case States.attacking:
				Attaking();
				break;

			default:
				break;
		}
	}

	public void Chasing()
	{
	}

	public void Idle()
	{
	}

	public void Attaking()
	{
	}
}