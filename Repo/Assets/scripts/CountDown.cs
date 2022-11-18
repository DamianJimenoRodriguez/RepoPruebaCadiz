using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountDown : MonoBehaviour
{
	public float countDownTime;

	public System.Action endCountDown;

	public System.Action<int, int> actionExample;

	public System.Func<int> myFunctionExample;

	public UnityEvent miEventoDeUnity;

	public void Method3(int entero, int entero2)
	{
	}

	public int Method4()
	{
		return 4;
	}

	private void Start()
	{
		myFunctionExample += Method4;
		actionExample += Method3;

		StartCoroutine(CountDownCorrutine());
	}

	public IEnumerator CountDownCorrutine()
	{
		yield return new WaitForSeconds(countDownTime);
		if (endCountDown != null)
		{
			endCountDown();
		}
	}
}