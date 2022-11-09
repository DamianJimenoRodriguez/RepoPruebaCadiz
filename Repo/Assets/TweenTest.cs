using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
	// Start is called before the first frame update
	public Transform objectToMove;

	private Transform targetDestination;

	public Transform InitialPosition, finalPosition;

	public float timeToMove = 4;

	public Ease easeType;

	public float timeToWaitAtTheEnd = 2;

	private Color targetColor;

	public Color startColor;
	public Color EndColor;

	public MeshRenderer rend;
	public float timeToChangeColor = 2;
	public float timeToWaitBeforeChangingColors = 1;

	private void Start()
	{
		targetColor = EndColor;
		targetDestination = finalPosition;
		StartCoroutine(MyFirstCorrutine());
		StartCoroutine(ChangeColorCorrutine());
	}

	public IEnumerator MyFirstCorrutine()
	{
		while (true)
		{
			objectToMove.DOMove(targetDestination.position, timeToMove).SetEase(easeType);
			yield return new WaitForSeconds(timeToMove);
			SwapPositions();
			yield return new WaitForSeconds(timeToWaitAtTheEnd);
		}
	}

	public void SwapPositions()
	{
		if (targetDestination == finalPosition)
		{
			targetDestination = InitialPosition;
		}
		else
		{
			targetDestination = finalPosition;
		}
	}

	public IEnumerator ChangeColorCorrutine()
	{
		while (true)
		{
			rend.material.DOColor(targetColor, timeToChangeColor);
			yield return new WaitForSeconds(timeToChangeColor);
			SwapColor();
			yield return new WaitForSeconds(timeToWaitBeforeChangingColors);
		}
	}

	public void SwapColor()
	{
		if (targetColor == EndColor)
		{
			targetColor = startColor;
		}
		else
		{
			targetColor = EndColor;
		}
	}
}