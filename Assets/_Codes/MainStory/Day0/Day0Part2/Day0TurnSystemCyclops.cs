using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Day0TurnSystemCyclops : MonoBehaviour
{
    public bool Player1;
    public bool Player2;
    public bool Player3;

    public CyclopsUIHolder cyclopsUIHolder;

    private void Start()
    {
        cyclopsUIHolder = GameObject.Find("UIDocumentBoss").GetComponent<CyclopsUIHolder>();
        Player1 = true;
        DisplayGriffinInfo();
    }

    public void PlayerDeath()
    {
        if (Player1 && !Player2 && !Player3)
        {
            if (Griffin.Health <= 0)
            {
                Player1 = false;
            }
            else Player1 = true;
        }
        if (!Player1 && Player2 && !Player3)
        {
            if (Faneia.Health <= 0)
            {
                Player2 = false;
            }
            else Player2 = true;
        }
        if (!Player1 && !Player2 && Player3)
        {
            if (Prodo.Health <= 0)
            {
                Player3 = false;
            }
            else Player3 = true;
        }
    }

    public void DisplayGriffinInfo()
    {
        cyclopsUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(cyclopsUIHolder.GriffinHealthIcon);
        cyclopsUIHolder.displayHealth.text = Griffin.Health + " / " + Griffin.MaxHealth.ToString();
    }
    public void DisplayFaneiaInfo()
    {
        cyclopsUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(cyclopsUIHolder.FaneiaHealthIcon);
        cyclopsUIHolder.displayHealth.text = Faneia.Health + " / " + Faneia.MaxHealth.ToString();
    }
    public void DisplayAvatarInfo()
    {
        cyclopsUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(cyclopsUIHolder.AvatarHealthIcon);
        cyclopsUIHolder.displayHealth.text = Avatar.Health + " / " + Avatar.MaxHealth.ToString();
    }
}
