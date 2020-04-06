using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
	float	UpperBound = 30.0f;
	float	LowerBound = -10.0f;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		// Destroys animals if they're OOB (essentially means the player failed to eliminate animal)
		if (transform.position.z < LowerBound || transform.position.z > UpperBound)
		{
			Debug.Log("Game Over!");
			Destroy(gameObject);
		}
	}
}
