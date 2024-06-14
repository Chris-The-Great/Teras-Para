using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;

public class Resluts : MonoBehaviour
{

    public static float MutantBlood;
    public static float MutantBones;
    public static float MutantSouls;

  

    public static AsyncOperation TP;

    public bool Displayed;

    combatUiHolder combatUI;

    bool displayHero1;
    bool displayHero2;
    bool displayHero3;

    private void Awake()
    {
        TP = SceneManager.LoadSceneAsync("TestTP");
        TP.allowSceneActivation = false;
        
    }

    public void Start()
    {
        combatUI = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        displayHero1 = true;
        combatUI.trainingIncrease.style.display = DisplayStyle.None;
        //DisplayMember1R();

        //combatUI.Next.RegisterCallback<ClickEvent>(DisplayMember1R);
    }
    
    public void DisplayMember1R()
    {
        if (displayHero1)
        {
            switch (combatUI.heroMember1.name)
            {
                case "Medusa":
                    combatUI.healthIncrease.text =
                        "Medusa Max Health Increase From " + Medusa.MaxHealth + " To " + (Medusa.MaxHealth + MissionHolder.NumberOfWaves);
                    Medusa.MaxHealth += MissionHolder.NumberOfWaves;
                    combatUI.strengthIncrease.text =
                         "Medusa Strength Increase From " + Medusa.Strengh + " To " + (Medusa.Strengh + MissionHolder.NumberOfWaves);
                    Medusa.Strengh += MissionHolder.NumberOfWaves;
                    combatUI.salvageIncrease.text =
                         "Medusa Slavage Increase From " + Medusa.Slavage + " To " + (Medusa.Slavage + MissionHolder.NumberOfWaves);
                    Medusa.Slavage += MissionHolder.NumberOfWaves;
                    combatUI.knowledgeIncrease.text =
                        "Medusa Knowledge Increase From " + Medusa.Knowledge + " To " + (Medusa.Knowledge + MissionHolder.NumberOfWaves);
                    Medusa.Knowledge += MissionHolder.NumberOfWaves;
                    combatUI.defenseIncrease.text =
                        "Medusa Defense Increase From " + Medusa.Defense + " To " + (Medusa.Defense + MissionHolder.NumberOfWaves);
                    Medusa.Defense += MissionHolder.NumberOfWaves;
                    break;
                case "Griffin":
                    combatUI.healthIncrease.text =
                        "Griffin Max Health Increase From " + Griffin.MaxHealth + " To " + (Griffin.MaxHealth + MissionHolder.NumberOfWaves);
                    Griffin.MaxHealth += MissionHolder.NumberOfWaves;
                    combatUI.strengthIncrease.text =
                         "Griffin Strength Increase From " + Griffin.Strengh + " To " + (Griffin.Strengh + MissionHolder.NumberOfWaves);
                    Griffin.Strengh += MissionHolder.NumberOfWaves;
                    combatUI.salvageIncrease.text =
                         "Griffin Slavage Increase From " + Griffin.Slavage + " To " + (Griffin.Slavage + MissionHolder.NumberOfWaves);
                    Griffin.Slavage += MissionHolder.NumberOfWaves;
                    combatUI.knowledgeIncrease.text =
                        "Griffin Knowledge Increase From " + Griffin.Knowledge + " To " + (Griffin.Knowledge + MissionHolder.NumberOfWaves);
                    Griffin.Knowledge += MissionHolder.NumberOfWaves;
                    combatUI.defenseIncrease.text =
                        "Griffin Defense Increase From " + Griffin.Defense + " To " + (Griffin.Defense + MissionHolder.NumberOfWaves);
                    Griffin.Defense += MissionHolder.NumberOfWaves;
                    break;
                case "Harpie":
                    combatUI.healthIncrease.text =
                        "Harpie Max Health Increase From " + Harpie.MaxHealth + " To " + (Harpie.MaxHealth + MissionHolder.NumberOfWaves);
                    Harpie.MaxHealth += MissionHolder.NumberOfWaves;
                    combatUI.strengthIncrease.text =
                         "Harpie Strength Increase From " + Harpie.Strengh + " To " + (Harpie.Strengh + MissionHolder.NumberOfWaves);
                    Harpie.Strengh += MissionHolder.NumberOfWaves;
                    combatUI.salvageIncrease.text =
                         "Harpie Slavage Increase From " + Harpie.Slavage + " To " + (Harpie.Slavage + MissionHolder.NumberOfWaves);
                    Harpie.Slavage += MissionHolder.NumberOfWaves;
                    combatUI.knowledgeIncrease.text =
                        "Harpie Knowledge Increase From " + Harpie.Knowledge + " To " + (Harpie.Knowledge + MissionHolder.NumberOfWaves);
                    Harpie.Knowledge += MissionHolder.NumberOfWaves;
                    combatUI.defenseIncrease.text =
                        "Harpie Defense Increase From " + Harpie.Defense + " To " + (Harpie.Defense + MissionHolder.NumberOfWaves);
                    Harpie.Defense += MissionHolder.NumberOfWaves;
                    break;
                case "Cyclops":
                    combatUI.healthIncrease.text =
                        "Cyclops Max Health Increase From " + Cyclops.MaxHealth + " To " + (Cyclops.MaxHealth + MissionHolder.NumberOfWaves);
                    Cyclops.MaxHealth += MissionHolder.NumberOfWaves;
                    combatUI.strengthIncrease.text =
                         "Cyclops Strength Increase From " + Cyclops.Strengh + " To " + (Cyclops.Strengh + MissionHolder.NumberOfWaves);
                    Cyclops.Strengh += MissionHolder.NumberOfWaves;
                    combatUI.salvageIncrease.text =
                         "Cyclops Slavage Increase From " + Cyclops.Slavage + " To " + (Cyclops.Slavage + MissionHolder.NumberOfWaves);
                    Cyclops.Slavage += MissionHolder.NumberOfWaves;
                    combatUI.knowledgeIncrease.text =
                        "Cyclops Knowledge Increase From " + Cyclops.Knowledge + " To " + (Cyclops.Knowledge + MissionHolder.NumberOfWaves);
                    Cyclops.Knowledge += MissionHolder.NumberOfWaves;
                    combatUI.defenseIncrease.text =
                        "Cyclops Defense Increase From " + Cyclops.Defense + " To " + (Cyclops.Defense + MissionHolder.NumberOfWaves);
                    Cyclops.Defense += MissionHolder.NumberOfWaves;
                    break;
                case "Prodo":
                    combatUI.healthIncrease.text =
                        "Prodo Max Health Increase From " + Prodo.MaxHealth + " To " + (Prodo.MaxHealth + MissionHolder.NumberOfWaves);
                    Prodo.MaxHealth += MissionHolder.NumberOfWaves;
                    combatUI.strengthIncrease.text =
                         "Prodo Strength Increase From " + Prodo.Strength + " To " + (Prodo.Strength + MissionHolder.NumberOfWaves);
                    Prodo.Strength += MissionHolder.NumberOfWaves;
                    combatUI.salvageIncrease.text =
                         "Prodo Slavage Increase From " + Prodo.Slavage + " To " + (Prodo.Slavage + MissionHolder.NumberOfWaves);
                    Prodo.Slavage += MissionHolder.NumberOfWaves;
                    combatUI.knowledgeIncrease.text =
                        "Prodo Knowledge Increase From " + Prodo.Knowledge + " To " + (Prodo.Knowledge + MissionHolder.NumberOfWaves);
                    Prodo.Knowledge += MissionHolder.NumberOfWaves;
                    combatUI.defenseIncrease.text =
                        "Prodo Defense Increase From " + Prodo.Defense + " To " + (Prodo.Defense + MissionHolder.NumberOfWaves);
                    Prodo.Defense += MissionHolder.NumberOfWaves;
                    break;
            }
            displayHero1 = false;
            displayHero2 = true;
        }
        combatUI.Next.RegisterCallback<ClickEvent>(DisplayMember2R);
    }
    public void DisplayMember2R(ClickEvent evt)
    {
        switch (combatUI.heroMember2.name)
        {
            case "Griffin":
                combatUI.healthIncrease.text =
                    "Griffin Max Health Increase From " + Griffin.MaxHealth + " To " + (Griffin.MaxHealth + MissionHolder.NumberOfWaves);
                Griffin.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Griffin Strength Increase From " + Griffin.Strengh + " To " + (Griffin.Strengh + MissionHolder.NumberOfWaves);
                Griffin.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Griffin Slavage Increase From " + Griffin.Slavage + " To " + (Griffin.Slavage + MissionHolder.NumberOfWaves);
                Griffin.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Griffin Knowledge Increase From " + Griffin.Knowledge + " To " + (Griffin.Knowledge + MissionHolder.NumberOfWaves);
                Griffin.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Griffin Defense Increase From " + Griffin.Defense + " To " + (Griffin.Defense + MissionHolder.NumberOfWaves);
                Griffin.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Harpie":
                combatUI.healthIncrease.text =
                    "Harpie Max Health Increase From " + Harpie.MaxHealth + " To " + (Harpie.MaxHealth + MissionHolder.NumberOfWaves);
                Harpie.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Harpie Strength Increase From " + Harpie.Strengh + " To " + (Harpie.Strengh + MissionHolder.NumberOfWaves);
                Harpie.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Harpie Slavage Increase From " + Harpie.Slavage + " To " + (Harpie.Slavage + MissionHolder.NumberOfWaves);
                Harpie.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Harpie Knowledge Increase From " + Harpie.Knowledge + " To " + (Harpie.Knowledge + MissionHolder.NumberOfWaves);
                Harpie.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Harpie Defense Increase From " + Harpie.Defense + " To " + (Harpie.Defense + MissionHolder.NumberOfWaves);
                Harpie.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Cyclops":
                combatUI.healthIncrease.text =
                    "Cyclops Max Health Increase From " + Cyclops.MaxHealth + " To " + (Cyclops.MaxHealth + MissionHolder.NumberOfWaves);
                Cyclops.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Cyclops Strength Increase From " + Cyclops.Strengh + " To " + (Cyclops.Strengh + MissionHolder.NumberOfWaves);
                Cyclops.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Cyclops Slavage Increase From " + Cyclops.Slavage + " To " + (Cyclops.Slavage + MissionHolder.NumberOfWaves);
                Cyclops.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Cyclops Knowledge Increase From " + Cyclops.Knowledge + " To " + (Cyclops.Knowledge + MissionHolder.NumberOfWaves);
                Cyclops.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Cyclops Defense Increase From " + Cyclops.Defense + " To " + (Cyclops.Defense + MissionHolder.NumberOfWaves);
                Cyclops.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Prodo":
                combatUI.healthIncrease.text =
                    "Prodo Max Health Increase From " + Prodo.MaxHealth + " To " + (Prodo.MaxHealth + MissionHolder.NumberOfWaves);
                Prodo.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Prodo Strength Increase From " + Prodo.Strength + " To " + (Prodo.Strength + MissionHolder.NumberOfWaves);
                Prodo.Strength += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Prodo Slavage Increase From " + Prodo.Slavage + " To " + (Prodo.Slavage + MissionHolder.NumberOfWaves);
                Prodo.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Prodo Knowledge Increase From " + Prodo.Knowledge + " To " + (Prodo.Knowledge + MissionHolder.NumberOfWaves);
                Prodo.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Prodo Defense Increase From " + Prodo.Defense + " To " + (Prodo.Defense + MissionHolder.NumberOfWaves);
                Prodo.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Faneia":
                combatUI.healthIncrease.text =
                    "Faneia Max Health Increase From " + Faneia.MaxHealth + " To " + (Faneia.MaxHealth + MissionHolder.NumberOfWaves);
                Faneia.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Faneia Strength Increase From " + Faneia.Strengh + " To " + (Faneia.Strengh + MissionHolder.NumberOfWaves);
                Faneia.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Faneia Slavage Increase From " + Faneia.Slavage + " To " + (Faneia.Slavage + MissionHolder.NumberOfWaves);
                Faneia.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Faneia Knowledge Increase From " + Faneia.Knowledge + " To " + (Faneia.Knowledge + MissionHolder.NumberOfWaves);
                Faneia.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Faneia Defense Increase From " + Faneia.Defense + " To " + (Faneia.Defense + MissionHolder.NumberOfWaves);
                Faneia.Defense += MissionHolder.NumberOfWaves;
                break;
        }
        displayHero2 = false;
        displayHero3 = true;
        combatUI.Next.RegisterCallback<ClickEvent>(DisplayMember3R);
    }
    void DisplayMember3R(ClickEvent evt)
    {
        switch (combatUI.heroMember3.name)
        {
            case "Harpie":
                combatUI.healthIncrease.text =
                    "Harpie Max Health Increase From " + Harpie.MaxHealth + " To " + (Harpie.MaxHealth + MissionHolder.NumberOfWaves);
                Harpie.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Harpie Strength Increase From " + Harpie.Strengh + " To " + (Harpie.Strengh + MissionHolder.NumberOfWaves);
                Harpie.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Harpie Slavage Increase From " + Harpie.Slavage + " To " + (Harpie.Slavage + MissionHolder.NumberOfWaves);
                Harpie.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Harpie Knowledge Increase From " + Harpie.Knowledge + " To " + (Harpie.Knowledge + MissionHolder.NumberOfWaves);
                Harpie.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Harpie Defense Increase From " + Harpie.Defense + " To " + (Harpie.Defense + MissionHolder.NumberOfWaves);
                Harpie.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Cyclops":
                combatUI.healthIncrease.text =
                    "Cyclops Max Health Increase From " + Cyclops.MaxHealth + " To " + (Cyclops.MaxHealth + MissionHolder.NumberOfWaves);
                Cyclops.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Cyclops Strength Increase From " + Cyclops.Strengh + " To " + (Cyclops.Strengh + MissionHolder.NumberOfWaves);
                Cyclops.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Cyclops Slavage Increase From " + Cyclops.Slavage + " To " + (Cyclops.Slavage + MissionHolder.NumberOfWaves);
                Cyclops.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Cyclops Knowledge Increase From " + Cyclops.Knowledge + " To " + (Cyclops.Knowledge + MissionHolder.NumberOfWaves);
                Cyclops.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Cyclops Defense Increase From " + Cyclops.Defense + " To " + (Cyclops.Defense + MissionHolder.NumberOfWaves);
                Cyclops.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Prodo":
                combatUI.healthIncrease.text =
                    "Prodo Max Health Increase From " + Prodo.MaxHealth + " To " + (Prodo.MaxHealth + MissionHolder.NumberOfWaves);
                Prodo.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Prodo Strength Increase From " + Prodo.Strength + " To " + (Prodo.Strength + MissionHolder.NumberOfWaves);
                Prodo.Strength += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Prodo Slavage Increase From " + Prodo.Slavage + " To " + (Prodo.Slavage + MissionHolder.NumberOfWaves);
                Prodo.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Prodo Knowledge Increase From " + Prodo.Knowledge + " To " + (Prodo.Knowledge + MissionHolder.NumberOfWaves);
                Prodo.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Prodo Defense Increase From " + Prodo.Defense + " To " + (Prodo.Defense + MissionHolder.NumberOfWaves);
                Prodo.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Faneia":
                combatUI.healthIncrease.text =
                    "Faneia Max Health Increase From " + Faneia.MaxHealth + " To " + (Faneia.MaxHealth + MissionHolder.NumberOfWaves);
                Faneia.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Faneia Strength Increase From " + Faneia.Strengh + " To " + (Faneia.Strengh + MissionHolder.NumberOfWaves);
                Faneia.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Faneia Slavage Increase From " + Faneia.Slavage + " To " + (Faneia.Slavage + MissionHolder.NumberOfWaves);
                Faneia.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Faneia Knowledge Increase From " + Faneia.Knowledge + " To " + (Faneia.Knowledge + MissionHolder.NumberOfWaves);
                Faneia.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Faneia Defense Increase From " + Faneia.Defense + " To " + (Faneia.Defense + MissionHolder.NumberOfWaves);
                Faneia.Defense += MissionHolder.NumberOfWaves;
                break;
            case "Avatar":
                combatUI.healthIncrease.text =
                    "Avatar Max Health Increase From " + Avatar.MaxHealth + " To " + (Avatar.MaxHealth + MissionHolder.NumberOfWaves);
                Avatar.MaxHealth += MissionHolder.NumberOfWaves;
                combatUI.strengthIncrease.text =
                     "Avatar Strength Increase From " + Avatar.Strengh + " To " + (Avatar.Strengh + MissionHolder.NumberOfWaves);
                Avatar.Strengh += MissionHolder.NumberOfWaves;
                combatUI.salvageIncrease.text =
                     "Avatar Slavage Increase From " + Avatar.Slavage + " To " + (Avatar.Slavage + MissionHolder.NumberOfWaves);
                Avatar.Slavage += MissionHolder.NumberOfWaves;
                combatUI.knowledgeIncrease.text =
                    "Avatar Knowledge Increase From " + Avatar.Knowledge + " To " + (Avatar.Knowledge + MissionHolder.NumberOfWaves);
                Avatar.Knowledge += MissionHolder.NumberOfWaves;
                combatUI.defenseIncrease.text =
                    "Avatar Defense Increase From " + Avatar.Defense + " To " + (Avatar.Defense + MissionHolder.NumberOfWaves);
                Avatar.Defense += MissionHolder.NumberOfWaves;
                break;
        }
        displayHero3 = false;
        if(Training.whosTraining != null)
        {
            combatUI.Next.RegisterCallback<ClickEvent>(TrainingR);
        }
        else
        {
            combatUI.Next.RegisterCallback<ClickEvent>(ReturnToBase);
        }
        
    }
    void TrainingR(ClickEvent evt)
    {
        combatUI.combatResluts.style.display = DisplayStyle.None;
        combatUI.trainingIncrease.style.display = DisplayStyle.Flex;
        if (Training.groundTraining)
        {
            switch (Training.whosTraining)
            {
                case "Medusa":
                    combatUI.trainingIncrease.text = "Medusa Strength Increase From " + Medusa.Strengh + " To " + (Medusa.Strengh + MissionHolder.NumberOfWaves);
                    Medusa.Strengh += MissionHolder.NumberOfWaves;
                    break;
                case "Griffin":
                    combatUI.trainingIncrease.text = "Griffin Strength Increase From " + Griffin.Strengh + " To " + (Griffin.Strengh + MissionHolder.NumberOfWaves);
                    Griffin.Strengh += MissionHolder.NumberOfWaves;
                    break;
                case "Harpie":
                    combatUI.trainingIncrease.text = "Harpie Strength Increase From " + Harpie.Strengh + " To " + (Harpie.Strengh + MissionHolder.NumberOfWaves);
                    Harpie.Strengh += MissionHolder.NumberOfWaves;
                    break;
                case "Cyclops":
                    combatUI.trainingIncrease.text = "Cyclops Strength Increase From " + Cyclops.Strengh + " To " + (Cyclops.Strengh + MissionHolder.NumberOfWaves);
                    Cyclops.Strengh += MissionHolder.NumberOfWaves;
                    break;
                case "Prodo":
                    combatUI.trainingIncrease.text = "Prodo Strength Increase From " + Prodo.Strength + " To " + (Prodo.Strength + MissionHolder.NumberOfWaves);
                    Prodo.Strength += MissionHolder.NumberOfWaves;
                    break;
                case "Faneia":
                    combatUI.trainingIncrease.text = "Faneia Strength Increase From " + Faneia.Strengh + " To " + (Faneia.Strengh + MissionHolder.NumberOfWaves);
                    Faneia.Strengh += MissionHolder.NumberOfWaves;
                    break;
                case "Avatar":
                    combatUI.trainingIncrease.text = "Avatar Strength Increase From " + Avatar.Strengh + " To " + (Avatar.Strengh + MissionHolder.NumberOfWaves);
                    Avatar.Strengh += MissionHolder.NumberOfWaves;
                    break;

            }
        }
        else if (Training.researchTraining)
        {
            switch (Training.whosTraining)
            {
                case "Medusa":
                    combatUI.trainingIncrease.text = "Medusa Knowledge Increase From " + Medusa.Knowledge + " To " + (Medusa.Knowledge + MissionHolder.NumberOfWaves);
                    Medusa.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Griffin":
                    combatUI.trainingIncrease.text = "Griffin Knowledge Increase From " + Griffin.Knowledge + " To " + (Griffin.Knowledge + MissionHolder.NumberOfWaves);
                    Griffin.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Cyclops":
                    combatUI.trainingIncrease.text = "Cyclops Knowledge Increase From " + Cyclops.Knowledge + " To " + (Cyclops.Knowledge + MissionHolder.NumberOfWaves);
                    Cyclops.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Harpie":
                    combatUI.trainingIncrease.text = "Harpie Knowledge Increase From " + Harpie.Knowledge + " To " + (Harpie.Knowledge + MissionHolder.NumberOfWaves);
                    Harpie.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Prodo":
                    combatUI.trainingIncrease.text = "Prodo Knowledge Increase From " + Prodo.Knowledge + " To " + (Prodo.Knowledge + MissionHolder.NumberOfWaves);
                    Prodo.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Faneia":
                    combatUI.trainingIncrease.text = "Faneia Knowledge Increase From " + Faneia.Knowledge + " To " + (Faneia.Knowledge + MissionHolder.NumberOfWaves);
                    Faneia.Knowledge += MissionHolder.NumberOfWaves;
                    break;
                case "Avatar":
                    combatUI.trainingIncrease.text = "Avatar Knowledge Increase From " + Avatar.Knowledge + " To " + (Avatar.Knowledge + MissionHolder.NumberOfWaves);
                    Avatar.Knowledge += MissionHolder.NumberOfWaves;
                    break;
            }
        }
        else if(Training.poolTraining)
        {
            switch (Training.whosTraining)
            {
                case "Medusa":
                    combatUI.trainingIncrease.text = "Medusa Max Health Increase From " + Medusa.MaxHealth + " To " + (Medusa.MaxHealth + MissionHolder.NumberOfWaves);
                    Medusa.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Griffin":
                    combatUI.trainingIncrease.text = "Griffin Max Health Increase From " + Griffin.MaxHealth + " To " + (Griffin.MaxHealth + MissionHolder.NumberOfWaves);
                    Griffin.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Cyclops":
                    combatUI.trainingIncrease.text = "Cyclops Max Health Increase From " + Cyclops.MaxHealth + " To " + (Cyclops.MaxHealth + MissionHolder.NumberOfWaves);
                    Cyclops.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Harpie":
                    combatUI.trainingIncrease.text = "Harpie Max Health Increase From " + Harpie.MaxHealth + " To " + (Harpie.MaxHealth + MissionHolder.NumberOfWaves);
                    Harpie.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Prodo":
                    combatUI.trainingIncrease.text = "Prodo Max Health Increase From " + Prodo.MaxHealth + " To " + (Prodo.MaxHealth + MissionHolder.NumberOfWaves);
                    Prodo.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Faneia":
                    combatUI.trainingIncrease.text = "Faneia Max Health Increase From " + Faneia.MaxHealth + " To " + (Faneia.MaxHealth + MissionHolder.NumberOfWaves);
                    Faneia.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
                case "Avatar":
                    combatUI.trainingIncrease.text = "Avatar Max Health Increase From " + Avatar.MaxHealth + " To " + (Avatar.MaxHealth + MissionHolder.NumberOfWaves);
                    Avatar.MaxHealth += MissionHolder.NumberOfWaves;
                    break;
            }
        }
        else
        {
            
        }
        combatUI.Next.RegisterCallback<ClickEvent>(ReturnToBase);
    }

    void ReturnToBase(ClickEvent evt)
    {
        TP.allowSceneActivation = true;
        UI.dayNightCycle += 1;
        Debug.Log(UI.dayNightCycle);
        UI.mutantNumber -= MissionHolder.NumberOfWaves * 3;
        Debug.Log(UI.mutantNumber);
    }
}
