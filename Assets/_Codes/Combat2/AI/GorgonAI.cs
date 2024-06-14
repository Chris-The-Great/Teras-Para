using UnityEngine;

using UnityEngine.UIElements;

public class GorgonAI : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public int Defenive;
    public int Strength;
    public bool hasAttacked;

    public int MutantBlood;
    public int MutantBones;
    public int MutantSouls;

    public combatUiHolder combatUI;

    // Start is called before the first frame update

    void Awake()
    {
        Health = 10;
        MaxHealth = 10;
        Defenive = 4;
        Strength = 5;
    }
    void Start()
    {
        combatUI = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attacked()
    {
        int random = Random.Range(1, 8);
        Debug.Log(random);
        while (hasAttacked == false)
        {
            switch (random)
            {
                case 1:
                    if (combatUI.heroMember1.name  == "Medusa" || combatUI.heroMember1.name  == "Medusa" || combatUI.heroMember3.name  == "Medusa")
                    {

                        if (Strength - (Medusa.Defense) <= 0)
                        {
                            Medusa.Health -= 1;
                        }
                        else
                        {
                            Medusa.Health -= Strength - (Medusa.Defense);
                        }

                        if (Medusa.IsPoisoned) this.Health -= (Medusa.Defense - Mathf.RoundToInt(this.Defenive / 2));
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 2:
                    if (combatUI.heroMember1.name  == "Griffin" || combatUI.heroMember2.name  == "Griffin" || combatUI.heroMember3.name  == "Griffin")
                    {
                        if (Strength - (Griffin.Defense) <= 0)
                        {
                            Griffin.Health -= 1;
                        }
                        else
                        {
                            Griffin.Health -= Strength - (Griffin.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 3:
                    if (combatUI.heroMember1.name  == "Cyclops" || combatUI.heroMember2.name  == "Cyclops" || combatUI.heroMember3.name  == "Cyclops")
                    {
                        if (Strength - (Cyclops.Defense) <= 0)
                        {
                            Cyclops.Health -= 1;
                        }
                        else
                        {
                            Cyclops.Health -= Strength - (Cyclops.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 4:
                    if (combatUI.heroMember1.name  == "Harpie" || combatUI.heroMember2.name  == "Harpie" || combatUI.heroMember3.name  == "Harpie")
                    {
                        if (Strength - (Harpie.Defense) <= 0)
                        {
                            Harpie.Health -= 1;
                        }
                        else
                        {
                            Harpie.Health -= Strength - (Harpie.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 5:
                    if (combatUI.heroMember1.name  == "Prodo" || combatUI.heroMember2.name  == "Prodo" || combatUI.heroMember3.name  == "Prodo")
                    {
                        if (Strength - (Prodo.Defense) <= 0)
                        {
                            Prodo.Health -= 1;
                        }
                        else
                        {
                            Prodo.Health -= Strength - (Prodo.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 6:
                    if (combatUI.heroMember1.name  == "Faneia" || combatUI.heroMember2.name  == "Faneia" || combatUI.heroMember3.name  == "Faneia")
                    {
                        if (Strength - (Faneia.Defense) <= 0)
                        {
                            Faneia.Health -= 1;
                        }
                        else
                        {
                            Faneia.Health -= Strength - (Faneia.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
                case 7:
                    if (combatUI.heroMember1.name  == "Avatar" || combatUI.heroMember2.name  == "Avatar" || combatUI.heroMember3.name  == "Avatar")
                    {
                        if (Strength - (Avatar.Defense) <= 0)
                        {
                            Avatar.Health -= 1;
                        }
                        else
                        {
                            Avatar.Health -= Strength - (Avatar.Defense);
                        }
                        hasAttacked = true;
                    }
                    else
                    {
                        random = Random.Range(1, 7);
                        Debug.Log(random);
                    }
                    break;
            }
        }
    }
}