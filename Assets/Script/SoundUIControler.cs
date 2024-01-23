using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUIControler : MonoBehaviour
{

    public Button button1;
    public Button button2;

    private bool isButtonPressed = false;
    private bool isButton2Pressed = false;

    void Start()
    {
        button1.onClick.AddListener(ToggleButton1State);
        button2.onClick.AddListener(ToggleButton2State);
    }

    void ToggleButton1State()
    {
        Image button1Image = button1.GetComponent<Image>();

        if (isButtonPressed)
        {
            button1Image.color = Color.white;
        }
        else
        {
            Color fadedColor = button1Image.color;
            fadedColor.a = 0.5f;
            button1Image.color = fadedColor;
        }
        isButtonPressed = !isButtonPressed;
    }

    void ToggleButton2State()
    {
        Image button2Image = button2.GetComponent<Image>();

        if (isButton2Pressed)
        {
            button2Image.color = Color.white;
        }
        else
        {
            Color faded2Color = button2Image.color;
            faded2Color.a = 0.5f;
            button2Image.color = faded2Color;
        }
        isButton2Pressed = !isButton2Pressed;
    }

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }
}
