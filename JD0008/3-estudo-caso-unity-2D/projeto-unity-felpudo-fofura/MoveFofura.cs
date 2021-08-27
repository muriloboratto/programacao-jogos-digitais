using UnityEngine;
using System.Collections;

public class MoveFofura: MonoBehaviour
{
	public Vector3 moveSpeed;
	public float spawnTime = 2f;
	public float spawnDelay = 2f;

	// Use this for initialization
	void Start()
	{
		moveSpeed = Vector3.left * Time.deltaTime;
		InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
	}

	void ChangeSpeed()
	{
		moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += moveSpeed;
	}
}