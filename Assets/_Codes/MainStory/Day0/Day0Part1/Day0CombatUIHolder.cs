using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Day0CombatUIHolder : MonoBehaviour
{
    public VisualElement Root;
    public VisualElement Background;
    public VisualElement combatViewer;
    public VisualElement heroHolder;
    public VisualElement Prodo;
    public VisualElement Faneia;
    public VisualElement Avatar;
    public VisualElement mutantHolder;
    public VisualElement Griffin1;
    public VisualElement Griffin2;
    public VisualElement Griffin3;
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

    // sprtie Holder
    public Sprite prodoHealthIcon;
    public Sprite FaneiaHealthIcon;
    public Sprite AvatarHealthIcon;
    public Sprite CyclopsBossHealthIcon;

    public void Awake()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        Background = Root.Q<VisualElement>("Background");
        combatViewer = Background.Q<VisualElement>("combatViewer");
        heroHolder = combatViewer.Q<VisualElement>("heroHolder");
        Prodo = heroHolder.Q<VisualElement>("Prodo");
        Faneia = heroHolder.Q<VisualElement>("Faneia");
        Avatar = heroHolder.Q<VisualElement>("Avatar");
        mutantHolder = combatViewer.Q<VisualElement>("mutantHolder");
        Griffin1 = mutantHolder.Q<VisualElement>("Griffin1");
        Griffin2 = mutantHolder.Q<VisualElement>("Griffin2");
        Griffin3 = mutantHolder.Q<VisualElement>("Griffin3");
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
    }
}
