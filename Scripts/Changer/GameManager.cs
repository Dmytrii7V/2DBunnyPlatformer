using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This class is used as a setting for the game
public class GameManager : MonoBehaviour {
    
    public static GameManager instance;

    public Character[] characters; /*array responsible for the number of heroes in the game.*/

    public Character currentCharacter; /*Current hero selected from the list*/

    private void Awake() {
                                                //A method of selecting a character from the list and deleting the rest of the characters you don't want.
        if (instance == null) { 
            instance = this;
        } else {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);       /*Charater in the game, clone Perfab   */
    }

    private void Start() {                                  
        if (characters.Length > 0) {
            currentCharacter = characters[0];
        }
    }

    public void SetCharacter(Character character) {
                                                                      //Remembering the past of the selected character by the game settings, put at the top of the list
                currentCharacter = character;
    }
}
