using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Day0Part1EnemySystem : MonoBehaviour
{
    public static bool Enemy1Turn = true;
    public static bool Enemy2Turn;
    public static bool Enemy3Turn;

    public static string Mutant;

    public bool Enemy1D;
    public bool Enemy2D;
    public bool Enemy3D;

    public GameObject mutant1;
    public GameObject mutant2;
    public GameObject mutant3;

    public Day0CombatUIHolder combatUIHolder;

    private void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<Day0CombatUIHolder>();
    }

    public void Damage()
    {

    }

    public void death()
    {
        if(GameObject.Find("Griffin1").GetComponent<Day0GriffinAI>().Health <= 0)
        {
            combatUIHolder.Griffin1.style.display = DisplayStyle.None;
            Enemy1D = true;
        }
        if (GameObject.Find("Griffin2").GetComponent<Day0GriffinAI>().Health <= 0)
        {
            combatUIHolder.Griffin2.style.display = DisplayStyle.None;
            Enemy2D = true;
        }
        if (GameObject.Find("Griffin3").GetComponent<Day0GriffinAI>().Health <= 0)
        {
            combatUIHolder.Griffin3.style.display = DisplayStyle.None;
            Enemy3D = true;
        }
    }

    public void FirstGriffinAttack()
    {
        Enemy1Turn = false;
        Enemy2Turn = true;
    }
    public void SecondGriffinAttack()
    {
        Enemy2Turn = false;
        Enemy3Turn = true;
    }
    public void ThirdGriffinAttack()
    {
        Enemy3Turn = false;
    }

    public IEnumerator EnemyAttacking()
    {
        Enemy1Turn = true;
        if (Enemy1Turn && !Enemy1D)
        {
            mutant1.GetComponent<Day0GriffinAI>().Attack();
            FirstGriffinAttack();
            yield return null;
        }
        else
        {
            if (!Enemy2D)
            {
                Enemy2Turn = true;
            }
            else if (!Enemy3D)
            {
                Enemy3Turn = true;
            }
            else
            {
                WhoTurn();
            }
        }

        if (Enemy2Turn && !Enemy2D)
        {
            mutant2.GetComponent<Day0GriffinAI>().Attack();
            SecondGriffinAttack();
            yield return null;
        }
        else
        {
            if (!Enemy3D)
            {
                Enemy3Turn = true;
            }
            else
            {
                WhoTurn();
            }
        }

        if (Enemy3Turn && !Enemy3D)
        {
            mutant3.GetComponent<Day0GriffinAI>().Attack();
            ThirdGriffinAttack();
            WhoTurn();
            yield return null;
        }

    }

    public void WhoTurn()
    {
        if (Prodo.Health > 0)
        {
            this.GetComponent<Day0Part1TurnSystem>().DisplayProdoInfo();
            this.GetComponent<Day0Part1TurnSystem>().Player1 = true;
        }
        else if (Faneia.Health > 0)
        {
            this.GetComponent<Day0Part1TurnSystem>().DisplayFaneiaInfo();
            this.GetComponent<Day0Part1TurnSystem>().Player1 = true;
        }
        else if (Avatar.Health > 0)
        {
            this.GetComponent<Day0Part1TurnSystem>().DisplayAvatarInfo();
            this.GetComponent<Day0Part1TurnSystem>().Player1 = true;
        }
    }
}
