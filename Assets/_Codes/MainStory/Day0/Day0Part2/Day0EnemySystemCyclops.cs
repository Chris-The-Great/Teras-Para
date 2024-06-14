using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Day0EnemySystemCyclops : MonoBehaviour
{
    public GameObject CyclopsBoss;

    public static bool CyclopsBossTurn = true;


    public bool Enemy1D;

    public void Awake()
    {
        
    }

    public void CyclopsBossDamage()
    {
    }


    public void BossAttack()
    {
        CyclopsBoss.GetComponent<CyclopsBossAI>().Attacked();
        CyclopsBoss.GetComponent<CyclopsBossAI>().hasAttacked = false;
    }
   

    public IEnumerator EnemyAttacking()
    {
        if(CyclopsBossTurn == true)
        {
            BossAttack();
            yield return null;
            WhoTurn();
        }
    }

    public void WhoTurn()
    {
        if (Griffin.Health > 0)
        {
            this.GetComponent<Day0TurnSystemCyclops>().Player1 = true;
            this.GetComponent<Day0TurnSystemCyclops>().DisplayGriffinInfo();
        }
        else if (Faneia.Health > 0)
        {
            this.GetComponent<Day0TurnSystemCyclops>().Player2 = true;
            this.GetComponent<Day0TurnSystemCyclops>().DisplayFaneiaInfo();
        }
        else if (Avatar.Health > 0)
        {
            this.GetComponent<Day0TurnSystemCyclops>().Player3 = true;
            this.GetComponent<Day0TurnSystemCyclops>().DisplayAvatarInfo();
        }
    }
}
