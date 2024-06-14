using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UIElements.Button;

public class Training : MonoBehaviour
{
    public static VisualElement Root;
    VisualElement trainingPageHolder;
    VisualElement trainingPage;
    VisualElement pageBackground;
    Button groundButton;
    Button researchButton;
    Button poolButton;

    public static bool groundTraining;
    public static bool researchTraining;
    public static bool poolTraining;

    public static bool pageDisplay;
    public static bool PersonPicked;
    public static string whosTraining;

    public void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        trainingPageHolder = Root.Q<VisualElement>("trainingPageHolder");
        pageBackground = trainingPageHolder.Q<VisualElement>("pageBackGround");
        trainingPage = pageBackground.Q<VisualElement>("trainingPage");
        groundButton = trainingPage.Q<Button>("groundButton");
        researchButton = trainingPage.Q<Button>("researchButton");
        poolButton = trainingPage.Q<Button>("poolButton");

        Root.style.display = DisplayStyle.None;
        pageDisplay = false;

        groundButton.RegisterCallback<ClickEvent>(GroundSelectTraining);
        researchButton.RegisterCallback<ClickEvent>(ResearchSelectTraining);
        poolButton.RegisterCallback<ClickEvent>(PoolSelectTraining);

    }
    private void Update()
    {

    }

    public void GroundSelectTraining(ClickEvent evt)
    {
        groundTraining = true;
        PageSystem.IsPickingMission = false;
        PageSystem.IsPickingResource = false;
        PageSystem.IsPickingTraining = true;
        Root.style.display = DisplayStyle.None;
        PageSystem.Root.style.display = DisplayStyle.Flex;
    }
    public void ResearchSelectTraining(ClickEvent evt)
    {
        researchTraining = true;
        CPagesC.PageNumber = 1;
        CPagesC.PCPU = true;
        PageSystem.IsPickingMission = false;
        PageSystem.IsPickingResource = false;
        PageSystem.IsPickingTraining = true;
        Root.style.display = DisplayStyle.None;
        PageSystem.Root.style.display = DisplayStyle.Flex;
    }
    public void PoolSelectTraining(ClickEvent evt)
    {
        poolTraining = true;
        CPagesC.PageNumber = 1;
        CPagesC.PCPU = true;
        PageSystem.IsPickingMission = false;
        PageSystem.IsPickingResource = false;
        PageSystem.IsPickingTraining = true;
        Root.style.display = DisplayStyle.None;
        PageSystem.Root.style.display = DisplayStyle.Flex;
    }

}
