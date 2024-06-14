using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day0GriffinAI : GriffinAI
{
    public Day0CombatUIHolder combatUIHolder;
    private void Awake()
    {
        this.Health = 25;   
    }
    private void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<Day0CombatUIHolder>();
    }

    public void Attack()
    {
        int random = Random.Range(1, 4);
        Debug.Log(random.ToString());
        switch(random)
        {
            case 1:
                if (Strength - (Prodo.Defense) <= 0)
                {
                    Prodo.Health -= 1;
                }
                else
                {
                    Prodo.Health -= Strength - (Prodo.Defense);
                }
                hasAttacked = true;
                break;
            case 2:
                if (Strength - (Faneia.Defense) <= 0)
                {
                    Faneia.Health -= 1;
                }
                else
                {
                    Faneia.Health -= Strength - (Faneia.Defense);
                }
                hasAttacked = true;
                break;
            case 3:
                if (Strength - (Avatar.Defense) <= 0)
                {
                    Avatar.Health -= 1;
                }
                else
                {
                    Avatar.Health -= Strength - (Avatar.Defense);
                }
                hasAttacked = true;
                break;
        }
    }
}
