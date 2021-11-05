//Restarts the Entire Level 
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour{

void OnCollisionEnter(Collision coll){

//if colliding with game object with the tag player
if (coll.gameObject.tag == "Player"){ 

//load current active scene
SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
	}
   }
}
