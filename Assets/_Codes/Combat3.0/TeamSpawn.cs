using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
public class TeamSpawn : MonoBehaviour
{
    public combatUiHolder combatUIHolder;
    public spriteHolder spriteHolder;

    public static GameObject TeamMember1;
    public static GameObject TeamMember2;
    public static GameObject TeamMember3;
    private void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        spriteHolder = GameObject.Find("UIDocument").GetComponent<spriteHolder>();
        TeamMember1 = GameObject.Find("TeamMember1");
        TeamMember2 = GameObject.Find("TeamMember2");
        TeamMember3 = GameObject.Find("TeamMember3");

        Member1();
        Member2();
        Member3();
        DisplayTM1Info();
    }
    public void Update()
    {
        
    }
    void Member1()
    {
        if (Medusa.Status == "Mission")
        {
            combatUIHolder.heroMember1.style.backgroundImage = new StyleBackground(spriteHolder.medusa);
            combatUIHolder.heroMember1.name = "Medusa";
            TeamMember1.name = "Medusa";
        }
        else if( Griffin.Status == "Mission")
        {
            combatUIHolder.heroMember1.style.backgroundImage = new StyleBackground(spriteHolder.griffin);
            combatUIHolder.heroMember1.name = "Griffin";
            TeamMember1.name = "Griffin";
        }
        else if (Harpie.Status == "Mission")
        {
            combatUIHolder.heroMember1.style.backgroundImage = new StyleBackground(spriteHolder.harpie);
            combatUIHolder.heroMember1.name = "Harpie";
            TeamMember1.name = "Harpie";
        }
        else if (Cyclops.Status == "Mission")
        {
            combatUIHolder.heroMember1.style.backgroundImage = new StyleBackground(spriteHolder.cyclops);
            combatUIHolder.heroMember1.name = "Cyclops";
            TeamMember1.name = "Cyclops";
        }
        else if (Prodo.Status == "Mission")
        {
            combatUIHolder.heroMember1.style.backgroundImage = new StyleBackground(spriteHolder.prodo);
            combatUIHolder.heroMember1.name = "Prodo";
            TeamMember1.name = "Prodo";
        }

    }

    void Member2()
    {
        if (Griffin.Status == "Mission" && combatUIHolder.heroMember1.name != "Griffin")
        {
            combatUIHolder.heroMember2.style.backgroundImage = new StyleBackground(spriteHolder.griffin);
            combatUIHolder.heroMember2.name = "Griffin";
            TeamMember2.name = "Griffin";

        }
        else if (Harpie.Status == "Mission" && combatUIHolder.heroMember1.name != "Harpie")
        {
            combatUIHolder.heroMember2.style.backgroundImage = new StyleBackground(spriteHolder.harpie);
            combatUIHolder.heroMember2.name = "Harpie";
            TeamMember2.name = "Harpie";

        }
        else if (Cyclops.Status == "Mission" && combatUIHolder.heroMember1.name != "Cyclops")
        {
            combatUIHolder.heroMember2.style.backgroundImage = new StyleBackground(spriteHolder.cyclops);
            combatUIHolder.heroMember2.name = "Cyclops";
            TeamMember2.name = "Cyclops";

        }
        else if (Prodo.Status == "Mission" && combatUIHolder.heroMember1.name != "Prodo")
        {
            combatUIHolder.heroMember2.style.backgroundImage = new StyleBackground(spriteHolder.prodo);
            combatUIHolder.heroMember2.name = "Prodo";
            TeamMember2.name = "Prodo";

        }
        else if (Faneia.Status == "Mission" && combatUIHolder.heroMember1.name != "Faneia")
        {
            combatUIHolder.heroMember2.style.backgroundImage = new StyleBackground(spriteHolder.faneia);
            combatUIHolder.heroMember2.name = "Faneia";
            TeamMember2.name = "Faneia";

        }

    }

    void Member3()
    {
        
        if (Harpie.Status == "Mission" && combatUIHolder.heroMember1.name != "Harpie" && combatUIHolder.heroMember2.name != "Harpie")
        {
            combatUIHolder.heroMember3.style.backgroundImage = new StyleBackground(spriteHolder.harpie);
            combatUIHolder.heroMember3.name = "Harpie";
            TeamMember3.name = "Harpie";
        }
        else if (Cyclops.Status == "Mission" && combatUIHolder.heroMember1.name != "Cyclops" && combatUIHolder.heroMember2.name != "Cyclops")
        {
            combatUIHolder.heroMember3.style.backgroundImage = new StyleBackground(spriteHolder.cyclops);
            combatUIHolder.heroMember3.name = "Cyclops";
            TeamMember3.name = "Cyclops";
        }
        else if (Prodo.Status == "Mission" && combatUIHolder.heroMember1.name != "Prodo" && combatUIHolder.heroMember2.name != "Prodo")
        {
            combatUIHolder.heroMember3.style.backgroundImage = new StyleBackground(spriteHolder.prodo);
            combatUIHolder.heroMember3.name = "Prodo";
            TeamMember3.name = "Prodo";
        }
        else if (Faneia.Status == "Mission" && combatUIHolder.heroMember1.name != "Faneia" && combatUIHolder.heroMember2.name != "Faneia")
        {
            combatUIHolder.heroMember3.style.backgroundImage = new StyleBackground(spriteHolder.faneia);
            combatUIHolder.heroMember3.name = "Faneia";
            TeamMember3.name = "Faneia";
        }
        else if (Avatar.Status == "Mission" && combatUIHolder.heroMember1.name != "Avatar" && combatUIHolder.heroMember2.name != "Avatar")
        {
            combatUIHolder.heroMember3.style.backgroundImage = new StyleBackground(spriteHolder.avatar);
            combatUIHolder.heroMember3.name = "Avatar";
            TeamMember3.name = "Avatar";
        }


    }

    public void DisplayTM1Info()
    {
        switch(combatUIHolder.heroMember1.name)
        {
            case "Medusa":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.medusaHealthBar);
                combatUIHolder.displayHealth.text = Medusa.Health + " / " + Medusa.MaxHealth;
                TurnSystem.whoTurn = "Medusa";
                break;
            case "Griffin":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.griffinHealthBar);
                combatUIHolder.displayHealth.text = Griffin.Health + " / " + Griffin.MaxHealth;
                TurnSystem.whoTurn = "Griffin";
                break;
            case "Harpie":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.harpieHealthBar);
                combatUIHolder.displayHealth.text = Harpie.Health + " / " + Harpie.MaxHealth;
                TurnSystem.whoTurn = "Harpie";
                break;
            case "Cyclops":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsHealthBar);
                combatUIHolder.displayHealth.text = Cyclops.Health + " / " + Cyclops.MaxHealth;
                TurnSystem.whoTurn = "Cyclops";
                break;
            case "Prodo":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.prodoHealthBar);
                combatUIHolder.displayHealth.text = Prodo.Health + " / " + Prodo.MaxHealth;
                TurnSystem.whoTurn = "Prodo";
                break;
        }
    }
    public void DisplayTM2Info()
    {
        switch (combatUIHolder.heroMember2.name)
        {
            case "Griffin":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.griffinHealthBar);
                combatUIHolder.displayHealth.text = Griffin.Health + " / " + Griffin.MaxHealth;
                TurnSystem.whoTurn = "Griffin";
                break;
            case "Harpie":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.harpieHealthBar);
                combatUIHolder.displayHealth.text = Harpie.Health + " / " + Harpie.MaxHealth;
                TurnSystem.whoTurn = "Harpie";
                break;
            case "Cyclops":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsHealthBar);
                combatUIHolder.displayHealth.text = Cyclops.Health + " / " + Cyclops.MaxHealth;
                TurnSystem.whoTurn = "Cyclops";
                break;
            case "Prodo":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.prodoHealthBar);
                combatUIHolder.displayHealth.text = Prodo.Health + " / " + Prodo.MaxHealth;
                TurnSystem.whoTurn = "Prodo";
                break;
            case "Faneia":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.faneiaHealthBar);
                combatUIHolder.displayHealth.text = Faneia.Health + " / " + Faneia.MaxHealth;
                TurnSystem.whoTurn = "Faneia";
                break;
        }
    }
    public void DisplayTM3Info()
    {
        switch (combatUIHolder.heroMember3.name)
        {
            case "Harpie":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.harpieHealthBar);
                combatUIHolder.displayHealth.text = Harpie.Health + " / " + Harpie.MaxHealth;
                TurnSystem.whoTurn = "Harpie";
                break;
            case "Cyclops":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsHealthBar);
                combatUIHolder.displayHealth.text = Cyclops.Health + " / " + Cyclops.MaxHealth;
                TurnSystem.whoTurn = "Cyclops";
                break;
            case "Prodo":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.prodoHealthBar);
                combatUIHolder.displayHealth.text = Prodo.Health + " / " + Prodo.MaxHealth;
                TurnSystem.whoTurn = "Prodo";
                break;
            case "Faneia":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.faneiaHealthBar);
                combatUIHolder.displayHealth.text = Faneia.Health + " / " + Faneia.MaxHealth;
                TurnSystem.whoTurn = "Faneia";
                break;
            case "Avatar":
                combatUIHolder.healthBarDisplay.style.backgroundImage = new StyleBackground(spriteHolder.avatarHealthBar);
                combatUIHolder.displayHealth.text = Avatar.Health + " / " + Avatar.MaxHealth;
                TurnSystem.whoTurn = "Avatar";
                break;

        }
    }
    

}
