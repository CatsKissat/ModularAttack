using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttackBase : MonoBehaviour
{
	private IAttack attack;
	private PlayerInputActions inputActions;

	private void Awake()
	{
		inputActions = new PlayerInputActions();
		inputActions.Gameplay.Attack.performed += OnAttack;

		if (GetComponent<IAttack>() != null)
		{
			attack = GetComponent<IAttack>();
		}
		else
		{
			Debug.LogWarning(gameObject.name + " is missing Attack interface");
		}
	}

	private void OnEnable()
	{
		inputActions.Gameplay.Attack.Enable();
	}

	private void OnAttack(InputAction.CallbackContext ctx)
	{
		if (attack != null)
		{
			attack.Attack();
		}
		else
		{
			Debug.LogWarning(gameObject.name + " is trying to attack but has no Attack interface");
		}
	}

	private void OnDisable()
	{
		inputActions.Gameplay.Attack.Disable();
	}
}
