/* 
* Author: Jiho Yoo
* Date: March 25, 2016
*Description: The player kills enemies and gets scores by hit the barrels
*/ 
using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	//PRIVATE INSTANCE VARIABLES
	private Transform _player; // Reference to the player's position.
	private PlayerController _playerHealth; // Reference to the player's health.
	private NavMeshAgent _nav;// Reference to the nav mesh agent.
	//	public float speed;
	
	void Awake ()
	{
		// Set up the references.
		_player = GameObject.FindGameObjectWithTag ("Player").transform;
		_playerHealth = _player.GetComponent <PlayerController> ();
		_nav = GetComponent <NavMeshAgent> (); 
	}
	
	void Update ()
	{
		

			_nav.SetDestination (_player.position); //moves toward the player

	} 
}