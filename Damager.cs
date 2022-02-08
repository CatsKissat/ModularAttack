using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour, IDamager
{
	[Tooltip("How long prefabs stays active until it disables itself")] [SerializeField] private float timeToInactivate;
	[Tooltip("Float value")] public FloatReference damageAmount;

	public float damageValue
	{
		get => damageAmount;
	}

	private void OnEnable()
	{
		StartCoroutine(DisableAfterTime());
	}

	public void MakeDamage()
	{
		throw new System.NotImplementedException();
	}

	IEnumerator DisableAfterTime()
	{
		yield return new WaitForSeconds(timeToInactivate);
		gameObject.SetActive(false);
	}
}
