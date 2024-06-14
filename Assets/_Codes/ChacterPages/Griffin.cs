using TMPro;
using UnityEngine;
public class Griffin : MonoBehaviour
{
    public GameObject PageOpen;

    [Header("Stats")]
    public static int MaxHealth = 40;
    public static int Health = 40;
    public static int Knowledge = 10;
    public static int Strengh = 30;
    public static int Slavage = 10;
    public static int Bond = 0;
    public static int Defense = 0;
    public static string Status = "Base";

    public static bool isDefending;
    public static int HealRate =3;

    private void Awake()
    {
        GameObject.Find("GriffinN").GetComponent<TextMeshProUGUI>().text = "Griffin";
        GameObject.Find("GriffinH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("GriffinS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("GriffinK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("GriffinST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
        GameObject.Find("GriffinD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("GriffinStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;




    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("GriffinP");
        if (PageOpen.gameObject.activeSelf == true)
        {


            GameObject.Find("GriffinN").GetComponent<TextMeshProUGUI>().text = "Griffin";
            GameObject.Find("GriffinH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("GriffinS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("GriffinK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("GriffinST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("GriffinD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("GriffinStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
