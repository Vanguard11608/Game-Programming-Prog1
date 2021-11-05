using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    void OnCollisionEnter(Collision coll){
        if (coll.gameObject.tag == "Player"){ 
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
