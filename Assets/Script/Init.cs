using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public static Character player;

    void Start()
    {
        GameObject selectedCharacter = CharacterSelect.selectedCharacter;
        GameObject playerObject =  Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        playerObject.name = "Player";

        switch (selectedCharacter.name)
        {
            case "Pink Man":
                player = new PinkMan(playerObject);
                break;
            case "Mask Dude":
                player = new MaskDude(playerObject);
                break;
            case "NinJa Frog":
                player = new NinjaFrog(playerObject);
                break;
            case "Virtual Guy":
                player = new VirtualGuy(playerObject);
                break;
        }
    }


}
