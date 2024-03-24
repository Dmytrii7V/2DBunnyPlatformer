using UnityEngine;

public class PlayerSpawner : MonoBehaviour {
    
    private void Start() {
        //The location of the player in the scene, i.e.the level.
        //Where the GameManager setting will be used, in which we have the character selection saved.

       Instantiate(GameManager.instance.currentCharacter.prefab, transform.position, Quaternion.identity); 
    }

}
