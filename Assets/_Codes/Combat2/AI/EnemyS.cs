using UnityEngine;

public class EnemyS : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject playerChose;
    public static GameObject EnemySelect;
    public static GameObject SkillSelect;

    private void Awake()
    {
        playerChose = GameObject.Find("playerChose");
        EnemySelect = GameObject.Find("EnemySelect");
        SkillSelect = GameObject.Find("SkillSelect");
        playerChose.SetActive(true);
        EnemySelect.SetActive(false);
        SkillSelect.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackE()
    {
        playerChose.SetActive(false);
        EnemySelect.SetActive(true);
    }
}
