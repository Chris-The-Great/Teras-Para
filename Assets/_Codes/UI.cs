using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public VisualElement Root;
    VisualElement UIHolder;
    VisualElement infoHolder;
    VisualElement mutantIcon;
    Label mutantNumberDisplay;
    VisualElement dayNightCycleIcon;
    Label dayNightNumberDisplay;

    public static int mutantNumber = 10000;
    public static float dayNightCycle = 001;
    public static bool display;

    private void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        UIHolder = Root.Q<VisualElement>("uiHolder");
        infoHolder = UIHolder.Q<VisualElement>("InfoHolder");
        mutantIcon = infoHolder.Q<VisualElement>("mutantIcon");
        mutantNumberDisplay = infoHolder.Q<Label>("mutantNumber");
        dayNightCycleIcon = infoHolder.Q<VisualElement>("sunIcon");
        dayNightNumberDisplay = infoHolder.Q<Label>("dayNumber");

        dayTracker();


    }

    private void Update()
    {
        dayNightNumberDisplay.text = dayNightCycle.ToString();
        mutantNumberDisplay.text = "X" + mutantNumber.ToString();
    }
    void dayTracker()
    {
        if(dayNightCycle == 2)
        {
            Root.style.display = DisplayStyle.None;
        }
    }

    void MutantTracking()
    {

    }

    static void updateUI()
    {

    }
}
