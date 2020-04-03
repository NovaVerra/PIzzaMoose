using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[SerializeField]
	float	MoveSpeed = 20.0f;

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
		transform.Translate(Vector3.right * HorizontalInput * MoveSpeed * Time.deltaTime);
	}
}
