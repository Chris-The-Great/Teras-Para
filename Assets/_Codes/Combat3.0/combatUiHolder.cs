using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class combatUiHolder : MonoBehaviour
{
    public VisualElement Root;
    public VisualElement Background;
    public VisualElement combatViewer;
    public Label waveNumber;
    public VisualElement heroHolder;
    public VisualElement heroMember1;
    public VisualElement heroMember2;
    public VisualElement heroMember3;
    public VisualElement mutantHolder;
    public VisualElement mutantMember1;
    public VisualElement mutantMember2;
    public VisualElement mutantMember3;
    public VisualElement combatControls;
    public VisualElement heroInfo;
    public VisualElement healthBarDisplay;
    public Label displayHealth;
    public VisualElement attackCommands;
    public Button attack;
    public Button skills;
    public Button heal;
    public Button defend;
    public VisualElement moveInfo;
    public Label moveName;
    public Label moveDes;
    public VisualElement mutantSelectHolder;
    public Button mutant1;
    public Button mutant2;
    public Button mutant3;
    public VisualElement skillsHolder;
    public Button skills1;
    public Button skills2;
    public Button skills3;
    public Button skills4;

    public VisualElement combatStatHolder;
    public VisualElement combatResluts;
    public Label healthIncrease;
    public Label strengthIncrease;
    public Label knowledgeIncrease;
    public Label salvageIncrease;
    public Label defenseIncrease;
    public Label trainingIncrease;
    public Button Next;


    public void Awake()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        Background = Root.Q<VisualElement>("Background");
        combatViewer = Background.Q<VisualElement>("combatViewer");
        waveNumber = Root.Q<Label>("waveNumber");
        heroHolder = combatViewer.Q<VisualElement>("heroHolder");
        heroMember1 = heroHolder.Q<VisualElement>("heroMember1");
        heroMember2 = heroHolder.Q<VisualElement>("heroMember2");
        heroMember3 = heroHolder.Q<VisualElement>("heroMember3");
        mutantHolder = combatViewer.Q<VisualElement>("mutantHolder");
        mutantMember1 = mutantHolder.Q<VisualElement>("mutantMember1");
        mutantMember2 = mutantHolder.Q<VisualElement>("mutantMember2");
        mutantMember3 = mutantHolder.Q<VisualElement>("mutantMember3");
        combatControls = Background.Q<VisualElement>("combatControls");
        heroInfo = combatControls.Q<VisualElement>("heroInfo");
        healthBarDisplay = heroInfo.Q<VisualElement>("healthBarDisplay");
        displayHealth = healthBarDisplay.Q<Label>("displayHealth");
        attackCommands = combatControls.Q<VisualElement>("attackCommands");
        attack = attackCommands.Q<Button>("attack");
        skills = attackCommands.Q<Button>("skills");
        heal = attackCommands.Q<Button>("heal");
        defend = attackCommands.Q<Button>("defend");
        moveInfo = combatControls.Q<VisualElement>("moveInfo");
        moveName = moveInfo.Q<Label>("moveName");
        moveDes = moveInfo.Q<Label>("moveDes");
        mutantSelectHolder = combatControls.Q<VisualElement>("mutantSelectHolder");
        mutant1 = mutantSelectHolder.Q<Button>("mutant1");
        mutant2 = mutantSelectHolder.Q<Button>("mutant2");
        mutant3 = mutantSelectHolder.Q<Button>("mutant3");
        skillsHolder = combatControls.Q<VisualElement>("skillsHolder");
        skills1 = skillsHolder.Q<Button>("skills1");
        skills2 = skillsHolder.Q<Button>("skills2");
        skills3 = skillsHolder.Q<Button>("skills3");
        skills4 = skillsHolder.Q<Button>("skills4");

        combatStatHolder = Root.Q<VisualElement>("combatStatHolder");
        combatResluts = combatStatHolder.Q<VisualElement>("CombatResluts");
        healthIncrease = combatResluts.Q<Label>("healthIncrease");
        strengthIncrease = combatResluts.Q<Label>("strengthIncrease");
        knowledgeIncrease = combatResluts.Q<Label>("knowledgeIncrease");
        salvageIncrease = combatResluts.Q<Label>("salvageIncrease");
        defenseIncrease = combatResluts.Q<Label>("defenseIncrease");
        trainingIncrease = combatStatHolder.Q<Label>("trainingIncrease");
        Next = combatStatHolder.Q<Button>("Next");

    }
}
