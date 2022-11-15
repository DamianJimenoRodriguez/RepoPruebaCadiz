using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : Health
{
	private Animator myAnimator;
	private NavMeshAgent agent;
	private Collider myCollider;
	public float timeToDie = 4;

	private void Awake()
	{
		myCollider = GetComponent<Collider>();
		agent = GetComponent<NavMeshAgent>();
		myAnimator = GetComponentInChildren<Animator>();
	}

	public override void Die()
	{
		myCollider.enabled = false;
		myAnimator.SetTrigger("death");
		agent.isStopped = true;
		StartCoroutine(DeathCorrutine());
	}

	public IEnumerator DeathCorrutine()
	{
		yield return new WaitForSeconds(timeToDie);
		Destroy(gameObject);
	}
}