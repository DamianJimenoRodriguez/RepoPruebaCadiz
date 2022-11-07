using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
	public GameObject startPanel, gamePanel, endPanel;
	public Text timeLeftText;
	public float playTime;
	private float timeLeft;

	private bool timeIsTicking = false;

	private int numberOfClicks = 0;
	public Text numberOfClicksText;

	private void Start()
	{
	}

	public void Click()
	{
		numberOfClicks++;
		numberOfClicksText.text = numberOfClicks.ToString();
	}

	public void Restart()
	{
		numberOfClicks = 0;
		numberOfClicksText.text = numberOfClicks.ToString();
	}

	public void StartCountDown()
	{
		timeLeft = playTime;
		timeIsTicking = true;
	}

	// Update is called once per frame
	private void Update()
	{
		if (timeIsTicking)
		{
			timeLeft -= Time.deltaTime;
			timeLeftText.text = timeLeft.ToString();
			if (timeLeft < 0)
			{
				timeIsTicking = false;
				GameOver();
			}
		}
	}

	private void GameOver()
	{
		gamePanel.SetActive(false);
		endPanel.SetActive(true);
	}
}