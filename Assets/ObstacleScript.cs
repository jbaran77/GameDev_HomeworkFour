using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleScript : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {

    switch (other.gameObject.tag) {
        case "Friendly":
            Debug.Log("Rocket down");
            break;
        case "Finish":
            Debug.Log("Game is finished");
            break;
        default:
            // Debug.Log("No collision");
            ReloadLevel();
            break;

    }
    if (other.gameObject.tag == "Rocket"){
        Debug.Log("Rocket down");
    }
   }

    private void ReloadLevel() {
        Scene sceneManager = SceneManager.GetActiveScene();
        int currentIndex = sceneManager.buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
   
}
