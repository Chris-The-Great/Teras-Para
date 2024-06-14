using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class PageSystem : MonoBehaviour
{
    //Page Data
    public static VisualElement Root;
    VisualElement pageHolder;
    VisualElement PageBackground;
    VisualElement Page;
    VisualElement nameHolder;
    Label Name;
    Label Health;
    Label Strength;
    Label Knowledge;
    Label Salvage;
    Label Defense;
    Label Status;
    Button Accpet;

    //PageSystem
    public int pageNumber;
    string pageDisplay;
    public static bool IsPickingMission;
    public static bool IsPickingResource;
    public static bool IsPickingTraining;
    public static bool IsPickingPool;
    public static bool IsPickingResearch;


    private void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        pageHolder = Root.Q<VisualElement>("pageHolder");
        PageBackground = pageHolder.Q<VisualElement>("pageBackground");
        Page = PageBackground.Q<VisualElement>("page");
        nameHolder = Page.Q<VisualElement>("NameHolder");
        Name = nameHolder.Q<Label>("Name");
        Health = PageBackground.Q<Label>("Health");
        Strength = PageBackground.Q<Label>("Strength");
        Knowledge = PageBackground.Q<Label>("Knowledge");
        Salvage = PageBackground.Q<Label>("Salvage");
        Defense = PageBackground.Q<Label>("Defense");
        Status = PageBackground.Q<Label>("Status");
        Accpet = PageBackground.Q<Button>("Accpet");

        pageDisplay = "false";
        Root.style.display = DisplayStyle.None;
    }

    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (pageDisplay)
            {
                case "false":
                    Root.style.display = DisplayStyle.Flex;
                    pageDisplay = "true";
                    break;
                case "true":
                    Root.style.display = DisplayStyle.None;
                    pageDisplay = "false";
                    Time.timeScale = 1f;
                    break;

            }

        }

        DisplayPage();
    }

    void DisplayPage()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) pageNumber += 1;
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) pageNumber -= 1;
        switch (pageNumber)
        {
            case 0:
                pageNumber = 1;
                break;
            case 1:
                MedusaPage();
                break;
            case 2:
                GriffinPage();
                break;
            case 3:
                CyclopsPage();
                break;
            case 4:
                HarpiePage();
                break;
            case 5:
                ProdoPage();
                break;
            case 6:
                FaneiaPage();
                break;
            case 7:
                AvatarPage();
                break;
            case 8:
                pageNumber = 7;
                break;
        }
    }

    void MedusaPage()
    {
        Name.text = "Medusa";
        Health.text = "Health: " + Medusa.Health + " / " + Medusa.MaxHealth;
        Strength.text = "Strength: " + Medusa.Strengh;
        Knowledge.text = "Knowledge: " + Medusa.Knowledge;
        Salvage.text = "Salvage: " + Medusa.Slavage;
        Defense.text = "Defense: " + Medusa.Defense;
        Status.text = "Status : " + Medusa.Status;
        Accpet.RegisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void GriffinPage()
    {
        Name.text = "Griffin";
        Health.text = "Health: " + Griffin.Health + " / " + Griffin.MaxHealth;
        Strength.text = "Strength: " + Griffin.Strengh;
        Knowledge.text = "Knowledge: " + Griffin.Knowledge;
        Salvage.text = "Salvage: " + Griffin.Slavage;
        Defense.text = "Defense: " + Griffin.Defense;
        Status.text = "Status : " + Griffin.Status;
        Accpet.RegisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void CyclopsPage()
    {
        Name.text = "Cyclops";
        Health.text = "Health: " + Cyclops.Health + " / " + Cyclops.MaxHealth;
        Strength.text = "Strength: " + Cyclops.Strengh;
        Knowledge.text = "Knowledge: " + Cyclops.Knowledge;
        Salvage.text = "Salvage: " + Cyclops.Slavage;
        Defense.text = "Defense: " + Cyclops.Defense;
        Status.text = "Status : " + Cyclops.Status;
        Accpet.RegisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void HarpiePage()
    {
        Name.text = "Harpie";
        Health.text = "Health: " + Harpie.Health + " / " + Harpie.MaxHealth;
        Strength.text = "Strength: " + Harpie.Strengh;
        Knowledge.text = "Knowledge: " + Harpie.Knowledge;
        Salvage.text = "Salvage: " + Harpie.Slavage;
        Defense.text = "Defense: " + Harpie.Defense;
        Status.text = "Status : " + Harpie.Status;
        Accpet.RegisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void ProdoPage()
    {
        Name.text = "Prodo";
        Health.text = "Health: " + Prodo.Health + " / " + Prodo.MaxHealth;
        Strength.text = "Strength: " + Prodo.Strength;
        Knowledge.text = "Knowledge: " + Prodo.Knowledge;
        Salvage.text = "Salvage: " + Prodo.Slavage;
        Defense.text = "Defense: " + Prodo.Defense;
        Status.text = "Status : " + Prodo.Status;
        Accpet.RegisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void FaneiaPage()
    {
        Name.text = "Faneia";
        Health.text = "Health: " + Faneia.Health + " / " + Faneia.MaxHealth;
        Strength.text = "Strength: " + Faneia.Strengh;
        Knowledge.text = "Knowledge: " + Faneia.Knowledge;
        Salvage.text = "Salvage: " + Faneia.Slavage;
        Defense.text = "Defense: " + Faneia.Defense;
        Status.text = "Status : " + Faneia.Status;
        Accpet.RegisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(AvatarAccpect);
    }
    void AvatarPage()
    {
        Name.text = "Avatar";
        Health.text = "Health: " + Avatar.Health + " / " + Avatar.MaxHealth;
        Strength.text = "Strength: " + Avatar.Strengh;
        Knowledge.text = "Knowledge: " + Avatar.Knowledge;
        Salvage.text = "Salvage: " + Avatar.Slavage;
        Defense.text = "Defense: " + Avatar.Defense;
        Status.text = "Status : " + Avatar.Status;
        Accpet.RegisterCallback<ClickEvent>(AvatarAccpect);
        Accpet.UnregisterCallback<ClickEvent>(GriffinAccpet);
        Accpet.UnregisterCallback<ClickEvent>(CyclopsAccpet);
        Accpet.UnregisterCallback<ClickEvent>(HarpieAccpet);
        Accpet.UnregisterCallback<ClickEvent>(ProdoAccpet);
        Accpet.UnregisterCallback<ClickEvent>(FaneiaAccpet);
        Accpet.UnregisterCallback<ClickEvent>(MedusaAccpet);
    }

    void MedusaAccpet(ClickEvent evt)
    {
        switch (Medusa.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Medusa.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Medusa.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Medusa.Status = "Base";
                break;
            case " Pool":
                Pool.PersonPicked = false;
                Medusa.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Medusa.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Medusa.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Medusa";
                    Medusa.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Medusa.Status = "Pool";
                }
                break;
        }
    }
    void GriffinAccpet(ClickEvent evt)
    {
        switch (Griffin.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Griffin.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Griffin.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Griffin.Status = "Base";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Griffin.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Griffin.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Griffin.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Griffin";
                    Griffin.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Griffin.Status = "Pool";
                }
                break;
        }
    }
    void CyclopsAccpet(ClickEvent evt)
    {
        switch (Cyclops.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Cyclops.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Cyclops.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Cyclops.Status = "Base";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Cyclops.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Cyclops.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Cyclops.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Cyclops";
                    Cyclops.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Cyclops.Status = "Pool";
                }
                break;

        }
    }
    void HarpieAccpet(ClickEvent evt)
    {
        switch (Harpie.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Harpie.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Harpie.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Harpie.Status = "Base";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Harpie.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Harpie.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Training.whosTraining = "Harpie";
                    Harpie.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Harpie.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Harpie.Status = "Pool";
                }
                break;

        }
    }
    void ProdoAccpet(ClickEvent evt)
    {
        switch (Prodo.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Prodo.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Prodo.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Prodo.Status = "Base";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Prodo.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Prodo.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Prodo.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Prodo";
                    Prodo.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Prodo.Status = "Pool";
                }
                break;

        }
    }
    void FaneiaAccpet(ClickEvent evt)
    {
        switch (Faneia.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Faneia.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Faneia.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Faneia.Status = "Base";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Faneia.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Faneia.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Faneia.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Faneia";
                    Faneia.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Faneia.Status = "Pool";
                }
                break;

        }
    }
    void AvatarAccpect(ClickEvent evt)
    {
        switch (Avatar.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Avatar.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Avatar.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Avatar.Status = "Base";
                break;
            case " Pool":
                Pool.PersonPicked = false;
                Avatar.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Debug.Log(Mission.NM);
                    Mission.NM += 1;
                    Avatar.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Avatar.Status = "Hunting";
                }
                else if (!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Training.whosTraining = "Avatar";
                    Avatar.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Avatar.Status = "Pool";
                }
                break;

        }
    }
}
