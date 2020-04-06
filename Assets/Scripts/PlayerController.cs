using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[Header("Movement")]
	[SerializeField] float	MovementSpeed = 20.0f;

	[SerializeField] float	X_Range = 20.0f;

	[Header("Projectile")]
	[SerializeField] GameObject	Projectile;

	[SerializeField] Transform	Parent;

	[SerializeField] float		DestroyDelay = 0.5f;

	// Start is called before the first frame update
	void	Start()
	{
		
	}

	// Update is called once per frame
	void	Update()
	{
		UserInputHandler();
	}

	void	UserInputHandler()
	{
		ProcessMovementInput();
		ProcessActionInput();
	}

	void	ProcessMovementInput()
	{
		// Read user input
		float	HorizontalInput = Input.GetAxis("Horizontal");

		// Calculate movement offset horizontally (this frame)
		float	X_Offset = HorizontalInput * MovementSpeed * Time.deltaTime;

		// Calculate updated position relative to the current position (this frame)
		float	X_UpdatedPos = transform.localPosition.x + X_Offset;

		// Limit X movement
		X_UpdatedPos = Mathf.Clamp(X_UpdatedPos, -X_Range, X_Range);
		
		// Update player position
		transform.localPosition = new Vector3(X_UpdatedPos, transform.localPosition.y, transform.localPosition.z);
	}

	void	ProcessActionInput()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
		}
	}

	void	Fire()
	{
		GameObject ProjectileInstance = Instantiate(Projectile, transform.position, Quaternion.identity);
		ProjectileInstance.transform.parent = Parent;
	}
}
