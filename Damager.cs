using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
	[Tooltip("How long prefabs stays active until it disables itself")] [SerializeField] private float timeToInactivate = 0.1f;
	// NOTE:
	// This not actually include code to damage enemies.
	// This is just for testing purpouse of a modular attacking.

	private void OnEnable()
	{
		// Start Coroutine to inactivate object
		// Great for bullets if you want them to inactivate after certain time
		StartCoroutine(DisableAfterTime());
	}

	IEnumerator DisableAfterTime()
	{
		yield return new WaitForSeconds(timeToInactivate);
		gameObject.SetActive(false);
	}
}
