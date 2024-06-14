using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class reslutsUiHolder : MonoBehaviour
{
    public VisualElement Root;
    public VisualElement combatStatHolder;
    public Label healthIncrease;
    public Label strengthIncrease;
    public Label knowledgeIncrease;
    public Label slavageIncrease;
    public Label defenseIncrease;
    public Button Next;

    public void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        combatStatHolder = Root.Q<VisualElement>("combatStatHolder");
        healthIncrease = combatStatHolder.Q<Label>("healthIncrease");
        strengthIncrease = combatStatHolder.Q<Label>("strengthIncrease");
        knowledgeIncrease = combatStatHolder.Q<Label>("knowledgeIncrease");
        slavageIncrease = combatStatHolder.Q<Label>("slavageIncrease");
        defenseIncrease = combatStatHolder.Q<Label>("defenseIncrease");
        Next = combatStatHolder.Q<Button>("Next");
    }
}
