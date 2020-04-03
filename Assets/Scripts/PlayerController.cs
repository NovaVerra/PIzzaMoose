using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[SerializeField]
	float	MovementSpeed = 20.0f;

	[SerializeField]
	float	BoundaryLimit = 20.0f;

	// Start is called before the first frame update
	void	Start()
	{
		
	}

	// Update is called once per frame
	void	Update()
	{
		ProcessInput();
	}

	void	ProcessInput()
	{
		float	HorizontalInput = Input.GetAxis("Horizontal");
		float	X_Offset = HorizontalInput * MovementSpeed * Time.deltaTime;
		float	X_UpdatedPos = transform.localPosition.x + X_Offset;
		X_UpdatedPos = Mathf.Clamp(X_UpdatedPos, -BoundaryLimit, BoundaryLimit);
		transform.localPosition = new Vector3(X_UpdatedPos, transform.localPosition.y, transform.localPosition.z);
	}
}
