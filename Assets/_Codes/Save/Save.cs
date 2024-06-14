using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Save : MonoBehaviour
{
    [Header("GameMaster")]

    [Header("Codes")]
    public GameMaster GM;
    public _CutsceneT CST;

    static string destination;
    BinaryFormatter bf;
    FileStream file;
    // Start is called before the first frame update
    private void Awake()
    {
        GM = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        CST = GameObject.Find("GameMaster").GetComponent<_CutsceneT>();
    }
    void Start()
    {
        destination = Application.persistentDataPath + "/save.txt";
        bf = new BinaryFormatter();
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void SaveData()
    {



        if (File.Exists(destination))
        {
            file = File.OpenWrite(destination);

        }
        else
        {
            file = File.Create(destination);
        }
        CSS();
        file.Close();

    }
    public void LoadData()
    {

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return;
        }
        LoadCSSS();
        file.Close();
        return;
    }

    public void CSS()
    {
        CST.save();
        bf.Serialize(file, ThingsSaved.TPSS);
    }
    public void LoadCSSS()
    {
        ThingsSaved.TPSS = (bool)bf.Deserialize(file);
        CST.load();
    }
}
