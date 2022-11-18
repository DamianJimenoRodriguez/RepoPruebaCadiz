using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
	public delegate void DoSomething();

	public DoSomething something;

	public System.Action DoAction;

	public CountDown countDown;

	public GameObject objectToTurnOff;

	public Light lightToTurnOn;

	public MeshRenderer meshToChangeColor;
	public Color colorToChange;

	public void TurnObjetoff()
	{
		objectToTurnOff.SetActive(false);
	}

	public void ChangeColor()
	{
		meshToChangeColor.material.color = colorToChange;
	}

	public void TurnOnLight()
	{
		lightToTurnOn.enabled = true;
	}

	private void Start()
	{
		DoAction += TurnObjetoff;
		DoAction();
		countDown.endCountDown += TurnOnLight;
		countDown.endCountDown += ChangeColor;
		countDown.endCountDown += TurnObjetoff;
	}
}