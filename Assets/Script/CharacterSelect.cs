using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    private int index;
    [SerializeField] GameObject[] character;
    [SerializeField] TextMeshProUGUI characterName;

    [SerializeField] GameObject[] characterPrefabs;

    public static GameObject selectedCharacter;

    void Start()
    {
        index = 0;
        SelectCharacter();
    }

    public void OnPrevSelect()
    {
        if (index > 0)
        {
            index--;
        }


        SelectCharacter();
            
    }

    public void OnNextSelect()
    {
        if (index < character.Length - 1)
        {
            index++;
        }
        SelectCharacter();
    }

    public void OnPlayBtnClick()
    {
        SceneManager.LoadScene("StageScene");
    }

    private void SelectCharacter()
    {
        for(int i = 0; i< character.Length; i++)
        {
            if (i == index)
            {
                character[i].GetComponent<SpriteRenderer>().color = Color.white;
                character[i].GetComponent<Animator>().enabled = true;
                selectedCharacter = characterPrefabs[i];
                characterName.text = characterPrefabs[i].name;
            }
            else
            {
                character[i].GetComponent<SpriteRenderer>().color = Color.black;
                character[i].GetComponent<Animator>().enabled = false;
            }
        }
    }
}
