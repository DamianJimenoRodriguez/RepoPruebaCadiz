using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovDamageMaker : MonoBehaviour
{
	public int DamageToMake;

	private void OnTriggerEnter(Collider other)
	{
		LiskovHealth health = other.gameObject.GetComponent<LiskovHealth>();

		health.TakeDamage(DamageToMake);

		//if (health is LiskovNPCHealth)
		//{
		//	health.TakeDamage(DamageToMake * 5);
		//}
		//else if (health is LiskovFlyingEnemyHealth)
		//{
		//	health.TakeDamage(0);
		//}
		//else
		//{
		//	health.TakeDamage(DamageToMake);
		//}
	}
}