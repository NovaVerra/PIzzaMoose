using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
	/** Game Configs */
	[Header("Game Objects")]
	[SerializeField] GameObject[]	AnimalPrefabs;
	[SerializeField] Transform		Parent;

	[Header("Spawn Transform/Range")]
	[SerializeField] float			X_SpawnRange = 20.0f;
	[SerializeField] float			Z_SpawnPos = 29.0f;

	[Header("Timing")]
	[SerializeField] float			StartDelay = 2.0f;
	[SerializeField] float			SpawnInterval = 1.5f;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnAnimal", StartDelay, SpawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void	SpawnAnimal()
	{
		int	AnimalIndex = Random.Range(0, AnimalPrefabs.Length);

		Vector3	SpawnPos = new Vector3(Random.Range(-X_SpawnRange, X_SpawnRange), 0, Z_SpawnPos);

		GameObject	AnimalInstance = Instantiate(AnimalPrefabs[AnimalIndex],
									SpawnPos,
									AnimalPrefabs[AnimalIndex].transform.rotation);

		AnimalInstance.transform.parent = Parent;
	}
}
