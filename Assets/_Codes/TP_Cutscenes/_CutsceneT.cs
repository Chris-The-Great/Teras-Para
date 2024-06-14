using UnityEngine;

public class _CutsceneT : MonoBehaviour
{
    public static bool TPSS;//Teras Para opening scene

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void save()
    {
        ThingsSaved.TPSS = TPSS;

    }
    public void load()
    {
        TPSS = ThingsSaved.TPSS;
    }
}
