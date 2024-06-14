using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Day7EnemySystem : MonoBehaviour
{
    public GameObject bloodGorgon;
    public GameObject griffin1;
    public GameObject griffin2;

    public static bool bloodGorgonTurn = true;
    public bool griffin1Turn;
    public bool griffin2Turn;

    public bool bloodGorgonD;
    public bool Enemy1D;
    public bool Enemy2D;

    BloodGorgonUIHolder bloodGorgonUIHolder;

    public void Awake()
    {
        bloodGorgonUIHolder = GameObject.Find("UiDocument").GetComponent<BloodGorgonUIHolder>();
    }

    public void death()
    {
        if(bloodGorgon.GetComponent<BloodGorgonAI>().Health <= 0)
        {
            bloodGorgonD = true;
        }
        if(griffin1.GetComponent<Day7GriffinAI>().Health <= 0)
        {
            Enemy1D = true;
        }
        if(griffin2.GetComponent<Day7GriffinAI>().Health <=0)
        {
            Enemy2D = true;
        }
        
    }


    public void BossAttack()
    {
        bloodGorgon.GetComponent<BloodGorgonAI>().Attacked();
        bloodGorgon.GetComponent<BloodGorgonAI>().hasAttacked = false;
    }
   

    public IEnumerator EnemyAttacking()
    {
        if(bloodGorgonTurn == true && !bloodGorgonD)
        {
            BossAttack();
            KilledPlayers();
            yield return null;
            if(griffin1.GetComponent<Day7GriffinAI>().Health <=0)
            {
                griffin1Turn = true;
            }
            else if(griffin2.GetComponent<Day7GriffinAI>().Health <=0)
            {
                griffin2Turn = true;
            }
            else
            {
                
            }
        }
    }

    public void WhoTurn()
    {
        if (Prodo.Health > 0)
        {
            this.GetComponent<Day7TurnSystem>().Player1 = true;
            this.GetComponent<Day7TurnSystem>().DisplayProdoInfo();
        }
        else if (Faneia.Health > 0)
        {
            this.GetComponent<Day7TurnSystem>().Player2 = true;
            this.GetComponent<Day7TurnSystem>().DisplayFaneiaInfo();
        }
        else if (Avatar.Health > 0)
        {
            this.GetComponent<Day7TurnSystem>().Player3 = true;
            this.GetComponent<Day7TurnSystem>().DisplayAvatarInfo();
        }
    }

    public void KilledPlayers()
    {
        if(Prodo.Health <=0)
        {
            bloodGorgonUIHolder.Prodo.style.backgroundImage = null;
        }
        if(Faneia.Health <=0)
        {
            bloodGorgonUIHolder.Faneia.style.backgroundImage = null;
        }
        if(Avatar.Health <=0)
        {
            bloodGorgonUIHolder.Avatar.style.backgroundImage = null;
        }
    }
    
}

