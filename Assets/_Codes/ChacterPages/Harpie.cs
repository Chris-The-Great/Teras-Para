using TMPro;
using UnityEngine;

public class Harpie : MonoBehaviour
{
    public GameObject PageOpen;

    [Header("Stats")]
    public static int MaxHealth = 40;
    public static int Health = 40;
    public static int Knowledge = 10;
    public static int Strengh = 30;
    public static int Slavage = 10;
    public static int Bond = 10;
    public static int Defense = 0;
    public static string Status = "Base";

    public static bool isDefending;
    public static int HealRate = 3;


    private void Awake()
    {
        GameObject.Find("HarpyN").GetComponent<TextMeshProUGUI>().text = "Harpy";
        GameObject.Find("HarpyH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("HarpyS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("HarpyK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("HarpyST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
        GameObject.Find("HarpyD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("HarpyStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;




    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("HarpyP");
        if (PageOpen.gameObject.activeSelf == true)
        {


            GameObject.Find("HarpyN").GetComponent<TextMeshProUGUI>().text = "Harpie";
            GameObject.Find("HarpyH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("HarpyS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("HarpyK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("HarpyST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("HarpyD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("HarpyStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
