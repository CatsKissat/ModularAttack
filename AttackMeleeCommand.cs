using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMeleeCommand : MonoBehaviour, IAttack
{
	[Tooltip("Location where an attack prefabs appears")] [SerializeField] private GameObject weaponHand;
	[SerializeField] private GameObject attackPrefab;
	[SerializeField] private int amountToPool = 5;
	private List<GameObject> pooledPrefabs;
	private GameObject attack;

	private void Start()
	{
		CreatePoolOfAttacks();
		attack = GetPooledAttack();
	}

	private void CreatePoolOfAttacks()
	{
		pooledPrefabs = new List<GameObject>();
		GameObject temp;
		for (int i = 0; i < amountToPool; i++)
		{
			temp = Instantiate(attackPrefab);
			temp.SetActive(false);
			pooledPrefabs.Add(temp);
		}
	}

	public void Attack()
	{
		if(attack != null)
		{
			// Set pooled attack to weaponHand's location
			attack.transform.position = weaponHand.transform.position;
			attack.transform.rotation = weaponHand.transform.rotation;

			attack.SetActive(true);
		}
	}

	public GameObject GetPooledAttack()
	{
		for (int i = 0; i < amountToPool; i++)
		{
			if (!pooledPrefabs[i].activeInHierarchy)
			{
				return pooledPrefabs[i];
			}
		}
		return null;
	}
}