using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, IDamageable
{
	public int health = 5;

	public void Interact()
	{
		throw new System.NotImplementedException();
	}

	public void TakeDamage(int damageAmount)
	{
		health -= damageAmount;
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}
}