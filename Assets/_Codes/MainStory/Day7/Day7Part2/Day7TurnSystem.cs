using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Day7TurnSystem : MonoBehaviour
{
    public bool Player1;
    public bool Player2;
    public bool Player3;

    public BloodGorgonUIHolder bloodGorgonUIHolder;

    private void Start()
    {
        bloodGorgonUIHolder = GameObject.Find("UIDocument").GetComponent<BloodGorgonUIHolder>();
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
        bloodGorgonUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(bloodGorgonUIHolder.ProdoHealthIcon);
        bloodGorgonUIHolder.displayHealth.text = Prodo.Health + " / " + Prodo.MaxHealth.ToString();
    }
    public void DisplayFaneiaInfo()
    {
        bloodGorgonUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(bloodGorgonUIHolder.FaneiaHealthIcon);
        bloodGorgonUIHolder.displayHealth.text = Faneia.Health + " / " + Faneia.MaxHealth.ToString();
    }
    public void DisplayAvatarInfo()
    {
        bloodGorgonUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(bloodGorgonUIHolder.AvatarHealthIcon);
        bloodGorgonUIHolder.displayHealth.text = Avatar.Health + " / " + Avatar.MaxHealth.ToString();
    }
}
