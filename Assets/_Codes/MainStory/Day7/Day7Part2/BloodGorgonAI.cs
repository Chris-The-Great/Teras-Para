using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BloodGorgonAI : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public int Defenive;
    public int Strength;
    public bool hasAttacked;
    // Start is called before the first frame update

    void Awake()
    {
        Health = 50;
        MaxHealth = 50;
        Defenive = 5;
        Strength = 5;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attacked()
    {
        int random = Random.Range(1, 4);
        Debug.Log(random);
        while (hasAttacked == false)
        {
            switch (random)
            {
               
                case 1:
                    if (Prodo.Health > 0)
                    {
                        Prodo.Health -= (Strength - Prodo.Defense);
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 4);
                        Debug.Log(random);
                    }
                    break;
                case 2:
                    if (Faneia.Health > 0)
                    {
                        Faneia.Health -= (Strength - Faneia.Defense);
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 4);
                        Debug.Log(random);
                    }
                    break;
                case 3:
                    if (Avatar.Health > 0)
                    {
                        Avatar.Health -= (Strength - Avatar.Defense);
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 4);
                        Debug.Log(random);
                    }
                    break;
            }
        }
    }
}
