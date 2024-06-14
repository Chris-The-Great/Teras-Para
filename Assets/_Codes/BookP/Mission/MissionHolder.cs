using UnityEngine;

public class MissionHolder : MonoBehaviour
{
    //side quest
    public static int[] MissionSet1;
    public int element = 0;
    public static int NumberOfWaves;

    //main story
    public static int[] storyMissionSet2;
    // Start is called before the first frame update
    void Start()
    {
        MissionSet1 = new int[4];
        MS1ArraySet();
        foreach (int value in MissionSet1)
        {

            Debug.Log(value);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void SMS()
    {
         
    }
    void SMSArraySet()
    {
        storyMissionSet2[0] = 1;  //Day 7 Mission
    }
    public static void MS1()
    {
        switch (Mission.missionPicked)
        {
            case 1:
                Mission.missionName.text = "Prodo Supply Run";
                Mission.missionDes.text = " Prodo has a spot he wants to clear mutants out of and gather some supplies there.";
                Mission.numberofWaves.text = "Number of expected waves : 4";
                break;
            case 2:
                Mission.missionName.text = "Medusa Vs Harpies";
                Mission.missionDes.text = "Medusa spotted a new camp of harpies before I got here, she of course wants to clear it out.";
                Mission.numberofWaves.text = "Number of expected waves : 7";
                break;
            case 3:
                Mission.missionName.text = "Fáneia Hunt For Poeple";
                Mission.missionDes.text = " Fáneia wants to launch a party to find more survivors. Medusa and Prodo are all in agreement.";
                Mission.numberofWaves.text = "Number of expected waves : 5";
                break;
            case 4:
                Mission.missionName.text = "Strongest Mutant";
                Mission.missionDes.text = "Griffin, Harpy, and Cyclops are having a competition to see what races are the strongest among them.";
                Mission.numberofWaves.text = "Number of expected waves : 8";
                break;

        }
    }
    
    void MS1ArraySet()
    {
        MissionSet1[0] = 1;
        MissionSet1[1] = 2;
        MissionSet1[2] = 3;
        MissionSet1[3] = 4;
    }
    public static void WaveSetter()
    {
        switch (Mission.missionPicked)
        {
            case 1:
                NumberOfWaves = 4;
                break;
            case 2:
                NumberOfWaves = 7;
                break;
            case 3:
                NumberOfWaves = 5;
                break;
            case 4:
                NumberOfWaves = 8;
                break;
        }
    }
}
