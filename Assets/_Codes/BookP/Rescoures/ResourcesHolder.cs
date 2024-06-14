using UnityEngine;
using UnityEngine.UIElements;

public class ResourcesHolder : MonoBehaviour
{

    public static float MutantBlood = 10;
    public static float MutantBones = 10;
    public static float MutantSouls = 10;

    public static bool pageDisplay;
    public static GameObject RP;

    public static bool PersonPicked;

    //Resource Page UI
    public static VisualElement Root;
    VisualElement pageBackground;
    VisualElement resourcePage;
    Label mutantBloodDisplay;
    Label mutantBonesDisplay;
    Label mutantSoulsDispaly;
    Button Accpet;


    private void Awake()
    {
        pageDisplay = false;
        Root = GetComponent<UIDocument>().rootVisualElement;
        pageBackground = Root.Q<VisualElement>("pageBackground");
        resourcePage = Root.Q<VisualElement>("resourcePage");
        mutantBloodDisplay = resourcePage.Q<Label>("mutantBlood");
        mutantBonesDisplay = resourcePage.Q<Label>("mutantBones");
        mutantSoulsDispaly = resourcePage.Q<Label>("mutantSouls");
        Accpet = resourcePage.Q<Button>("Accpet");
        Root.style.display = DisplayStyle.None;
    }
    public void Start()
    {
        Accpet.RegisterCallback<ClickEvent>(SendForResources);
        mutantBloodDisplay.text = "Mutant Blood : " + MutantBlood;
        mutantBonesDisplay.text = "Mutant Bones : " + MutantBones;
        mutantSoulsDispaly.text = "Mutant Souls : " + MutantSouls;
    }
    private void Update()
    {

    }
    void DisplayResources()
    {

    }

    public void SendForResources(ClickEvent evt)
    {
        pageDisplay = false;
        RP.SetActive(false);
        CPagesC.PageNumber = 1;
        CPagesC.PCPU = true;
        CPagesC.IsPickingMission = false;
        CPagesC.IsPickingResource = true;
    }
}
