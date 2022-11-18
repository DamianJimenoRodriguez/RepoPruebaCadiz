using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, IDamageable
{
	public void Interact()
	{
		throw new System.NotImplementedException();
	}

	public void TakeDamage(int damageAmount)
	{
		Destroy(gameObject);
	}
}