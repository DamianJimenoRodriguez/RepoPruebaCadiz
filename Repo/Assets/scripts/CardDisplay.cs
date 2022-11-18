using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
	public Card myCard;

	public Text cardNameText, cardCostText, cardAttackText, cardDefenceText, cardDescriptiontext;

	public Image cardArtWork;





	private void Start()
	{
		cardNameText.text = myCard.cardName;
		cardCostText.text = myCard.CardCost.ToString();
		cardAttackText.text = myCard.cardAttack.ToString();
		cardDefenceText.text = myCard.cardDefense.ToString();
		cardDescriptiontext.text = myCard.cardDescription;
		cardArtWork.sprite = myCard.cardArt;
	}
}