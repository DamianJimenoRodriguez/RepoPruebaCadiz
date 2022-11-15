using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseBullet : OpenCloseProjectile
{
	public override void ShootProjectile(Vector3 shootDirecction)
	{
		rb.AddForce(shootDirecction * shootForce, ForceMode.Impulse);
	}
}