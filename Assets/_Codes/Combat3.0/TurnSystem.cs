using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class TurnSystem : MonoBehaviour
{
    [SerializeField]
    public bool Player1;
    public bool Player2;
    public bool Player3;
    public bool Player1D;
    public bool Player2D;
    public bool Player3D;

    public combatUiHolder combatUi;

    public static string whoTurn;

    private void Start()
    {
        Player1 = true;
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        switch(TeamSpawn.TeamMember1.name)
        {
            case "Medusa":
                whoTurn = "Medusa";
                break;
            case "Griffin":
                whoTurn = "Griffin";
                break;
            case "Harpie":
                whoTurn = "Harpie";
                break;
            case "Cyclops":
                whoTurn = "Cyclops";
                break;
            case "Prodo":
                whoTurn = "Prodo";
                break;
        }
        Debug.Log(whoTurn);
        
    }

    public void Update()
    {
        
    }


    public void PlayerDeath()
    {
        if(Player1 && !Player2 && !Player3)
        {
            switch (TeamSpawn.TeamMember1.name)
            {
                case "Medusa":
                    if (Medusa.Health <= 0)
                    {
                        Player1 = false;
                        TeamSpawn.TeamMember1.name = "";
                        Player1D = true;
                    }
                    else
                    {
                        Player1 = true;
                        whoTurn = "Medusa";
                    }
                    break;
                case "Griffin":
                    if (Griffin.Health <= 0)
                    {
                        Player1 = false;
                        TeamSpawn.TeamMember1.name = "";
                        Player1D = true;
                    }
                    else
                    {
                        Player1 = true;
                        whoTurn = "Griffin";
                    }
                    break;
                case "Cyclops":
                    if (Cyclops.Health <= 0)
                    {
                        Player1 = false;
                        TeamSpawn.TeamMember1.name = "";
                        Player1D = true;
                    }
                    else
                    {
                        Player1 = true;
                        whoTurn = "Cyclops";
                    }
                    break;
                case "Harpie":
                    if (Harpie.Health <= 0)
                    {
                        Player1 = false;
                        TeamSpawn.TeamMember1.name = "";
                        Player1D = true;
                    }
                    else
                    {
                        Player1 = true;
                        whoTurn = "Harpie";
                    }
                    break;
                case "Prodo":
                    if (Prodo.Health <= 0)
                    {
                        Player1 = false;
                        TeamSpawn.TeamMember1.name = "";
                        Player1D = true;
                    }
                    else
                    {
                        Player1 = true;
                        whoTurn = "Prodo";
                    }
                    break;
            }

        }
        else if(!Player1 && Player2 && !Player3)
        {
            switch (TeamSpawn.TeamMember2.name)
            {
                case "Griffin":
                    if (Griffin.Health <= 0)
                    {
                        Player2 = false;
                        TeamSpawn.TeamMember2.name = "";
                        Player2D = true;
                    }
                    else
                    {
                        Player2 = true;
                        whoTurn = "Griffin";
                    }
                    break;
                case "Cyclops":
                    if (Cyclops.Health <= 0)
                    {
                        Player2 = false;
                        TeamSpawn.TeamMember2.name = "";
                        Player2D = true;
                    }
                    else
                    {
                        Player2 = true;
                        whoTurn = "Cyclops";
                    }
                    break;
                case "Harpie":
                    if (Harpie.Health <= 0)
                    {
                        Player2 = false;
                        TeamSpawn.TeamMember2.name = "";
                        Player2D = true;
                    }
                    else
                    {
                        Player2 = true;
                        whoTurn = "Harpie";
                    }
                    break;
                case "Prodo":
                    if (Prodo.Health <= 0)
                    {
                        Player2 = false;
                        TeamSpawn.TeamMember2.name = "";
                        Player2D = true;
                    }
                    else
                    {
                        Player2 = true;
                        whoTurn = "Prodo";
                    }
                    break;
                case "Faneia":
                    if (Faneia.Health <= 0)
                    {
                        Player2 = false;
                        TeamSpawn.TeamMember2.name = "";
                        Player2D = true;
                    }
                    else
                    {
                        Player2 = true;
                        whoTurn = "Faneia";
                    }
                    break;
            }
        }
        else if(!Player1 && Player2 && Player3)
        {
            switch (TeamSpawn.TeamMember3.name)
            {
                case "Cyclops":
                    if (Cyclops.Health <= 0)
                    {
                        Player3 = false;
                        TeamSpawn.TeamMember3.name = "";
                        Player3D = true;
                    }
                    else
                    {
                        Player3 = true;
                        whoTurn = "Cyclops";
                    }
                    break;
                case "Harpie":
                    if (Harpie.Health <= 0)
                    {
                        Player3 = false;
                        TeamSpawn.TeamMember3.name = "";
                        Player3D = true;
                    }
                    else
                    {
                        Player3 = true;
                        whoTurn = "Harpie";
                    }
                    break;
                case "Prodo":
                    if (Prodo.Health <= 0)
                    {
                        Player3 = false;
                        TeamSpawn.TeamMember3.name = "";
                        Player3D = true;
                    }
                    else
                    {
                        Player3 = true;
                        whoTurn = "Prodo";
                    }
                    break;
                case "Faneia":
                    if (Faneia.Health <= 0)
                    {
                        Player3 = false;
                        TeamSpawn.TeamMember3.name = "";
                        Player3D = true;
                    }
                    else
                    {
                        Player3 = true;
                        whoTurn = "Faneia";
                    }
                    break;
                case "Avatar":
                    if (Avatar.Health <= 0)
                    {
                        Player3 = false;
                        TeamSpawn.TeamMember3.name = "";
                        Player3D = true;
                    }
                    else
                    {
                        Player3 = true;
                        whoTurn = "Avatar";
                    }
                    break;

            }
        }
    }
}
