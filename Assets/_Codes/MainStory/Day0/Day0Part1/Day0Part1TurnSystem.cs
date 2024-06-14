using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Day0Part1TurnSystem : MonoBehaviour
{
    public bool Player1;
    public bool Player2;
    public bool Player3;

    public Day0CombatUIHolder combatUIHolder;

    private void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<Day0CombatUIHolder>();
        Player1 = true;
        DisplayProdoInfo();
    }

    public void PlayerDeath()
    {
        if (Player1 && !Player2 && !Player3)
        {
            if (Prodo.Health <= 0)
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

    public void DisplayProdoInfo()
    {
        combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(combatUIHolder.prodoHealthIcon);
        combatUIHolder.displayHealth.text = Prodo.Health + " / " + Prodo.MaxHealth.ToString();
    }
    public void DisplayFaneiaInfo()
    {
        combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(combatUIHolder.FaneiaHealthIcon);
        combatUIHolder.displayHealth.text = Faneia.Health + " / " + Faneia.MaxHealth.ToString();
    }
    public void DisplayAvatarInfo()
    {
        combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(combatUIHolder.AvatarHealthIcon);
        combatUIHolder.displayHealth.text = Avatar.Health + " / " + Avatar.MaxHealth.ToString();
    }
}
