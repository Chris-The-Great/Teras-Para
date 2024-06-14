using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Mission : MonoBehaviour
{
    //page data
    public static VisualElement Root1;
    VisualElement pageHolder;
    VisualElement pageBackground;
    VisualElement missionPage;
    public static Label missionName;
    public static Label missionDes;
    public static Label numberofWaves;
    Button Accpet;

    //page system
    public static int pageNumber;
    public static string pageDisplay;

    //mission system
    public static int missionPicked;
    List<int> SelectedMission = new List<int>();
    public static int NM;

    private void Start()
    {
        //Getting all elements of the UI Mission Page
        Root1 = GetComponent<UIDocument>().rootVisualElement;
        pageHolder = Root1.Q<VisualElement>("missionPageHolder");
        pageBackground = pageHolder.Q<VisualElement>("pageBackGround");
        missionPage = pageBackground.Q<VisualElement>("missionPage");
        missionName = missionPage.Q<Label>("missionName");
        missionDes = missionPage.Q<Label>("missionDes");
        numberofWaves = missionPage.Q<Label>("numberofWaves");
        Accpet = missionPage.Q<Button>("Accpet");

        pageDisplay = "false";
        Root1.style.display = DisplayStyle.None;
        Debug.Log(numberofWaves);


    }

    void Update()
    {
        //Flips though the different pages 
        if (Input.GetKeyDown(KeyCode.LeftArrow)) pageNumber -= 1;
        if (Input.GetKeyDown(KeyCode.RightArrow)) pageNumber += 1;
        Debug.Log(SelectedMission.Count);
        ChoiceMission();
        SelectMission();
        Debug.Log(MissionHolder.MissionSet1.Length);

        //switch statement to follow which mission is selected 
        switch (pageNumber)
        {
            case 0:
                pageNumber = 1;
                break;
            case 1:
                missionPicked = SelectedMission[0];
                MissionHolder.MS1();
                break;
            case 2:
                missionPicked = SelectedMission[1];
                MissionHolder.MS1();
                break;
            case 3:
                missionPicked = SelectedMission[2];
                MissionHolder.MS1();
                break;
            case 4:
                pageNumber = 3;
                break;

        }



    }
    //method for selecting a mission
    void SelectMission()
    {
        Accpet.RegisterCallback<ClickEvent>(SendOnMission);
    }
    
    //A click event to change to the character select page
    void SendOnMission(ClickEvent evt)
    {
        PageSystem.Root.style.display = DisplayStyle.Flex;
        Root1.style.display = DisplayStyle.None;
        PageSystem.IsPickingMission = true;
        MissionHolder.WaveSetter();

    }

    //Method for choosing which mission to pick from the array to present to the player to pick from
    void ChoiceMission()
    {
        int selectIndex = -1;
        while (SelectedMission.Count < 3)
        {
            selectIndex = Random.Range(0, MissionHolder.MissionSet1.Length);
            if (!SelectedMission.Contains(MissionHolder.MissionSet1[selectIndex]))
            {
                SelectedMission.Add(MissionHolder.MissionSet1[selectIndex]);
            }

            if (SelectedMission.Count >= 3)
            {
                break;
            }
        }
    }
}

