using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[SerializeField] float	ProjectileSpeed = 50.0f;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.forward * ProjectileSpeed * Time.deltaTime);
	}
}
