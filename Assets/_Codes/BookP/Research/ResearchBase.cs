using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResearchBase : MonoBehaviour
{

    public static bool PRBP;
    public static GameObject ResearchPage;

    public int pageNumber;
    public static string MutantPicked;

    public int ResearchPoints;
    public int CurrentResearchPoints;

    private void Awake()
    {
        ResearchPage = GameObject.Find("ResearchP");
        ResearchPage.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPage();
        DisplayInfo();
    }

    void DisplayPage()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && PRBP == true)
        {
            pageNumber += 1;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && PRBP == true)
        {
            pageNumber -= 1;
        }
        if(pageNumber <=1 && PRBP)
        {
            pageNumber = 1;
        }
        if(pageNumber >=6 && PRBP)
        {
            pageNumber = 6;
        }
    }

    void DisplayInfo()
    {
        switch(pageNumber)
        {
            case 1:
                LoveKillerInfo();
                break;
            case 2:
                RedBlockerInfo();
                break;
            case 3:
                QueensInfo();
                break;
            case 4:
                SlothInfo();
                break;
            case 5:
                ShapeShifterInfo();
                break;
            case 6:
                MachineInfo();
                break;
        }

    }

   void Unlock()
    {
        int RandomMutant = Random.Range(1, 7);
        int RandomUnlock = Random.Range(1, 7);
        switch(RandomMutant)
        {
            case 1:
                 switch (RandomUnlock)
                {
                    case 1:
                        if(ErastisDolofonos.UnlockName == false)
                        {
                            ErastisDolofonos.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (ErastisDolofonos.UnlockHealth == false)
                        {
                            ErastisDolofonos.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (ErastisDolofonos.UnlockStrength == false)
                        {
                            ErastisDolofonos.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (ErastisDolofonos.UnlockDefense == false)
                        {
                            ErastisDolofonos.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (ErastisDolofonos.UnlockRace == false)
                        {
                            ErastisDolofonos.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (ErastisDolofonos.UnlockTeam == false)
                        {
                            ErastisDolofonos.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                } //Medusa
                break;
            case 2:
                switch (RandomUnlock)
                {
                    case 1:
                        if (Diamorfot�sMorf�s.UnlockName == false)
                        {
                            Diamorfot�sMorf�s.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (Diamorfot�sMorf�s.UnlockHealth == false)
                        {
                            Diamorfot�sMorf�s.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (Diamorfot�sMorf�s.UnlockStrength == false)
                        {
                            Diamorfot�sMorf�s.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (Diamorfot�sMorf�s.UnlockDefense == false)
                        {
                            Diamorfot�sMorf�s.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (Diamorfot�sMorf�s.UnlockRace == false)
                        {
                            Diamorfot�sMorf�s.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (Diamorfot�sMorf�s.UnlockTeam == false)
                        {
                            Diamorfot�sMorf�s.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                }//Prodo
                break;
            case 3:
                switch (RandomUnlock)
                {
                    case 1:
                        if (Vas�lisses.UnlockName == false)
                        {
                            Vas�lisses.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (Vas�lisses.UnlockHealth == false)
                        {
                            Vas�lisses.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (Vas�lisses.UnlockStrength == false)
                        {
                            Vas�lisses.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (Vas�lisses.UnlockDefense == false)
                        {
                            Vas�lisses.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (Vas�lisses.UnlockRace == false)
                        {
                            Vas�lisses.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (Vas�lisses.UnlockTeam == false)
                        {
                            Vas�lisses.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                }//Harpy
                break;
            case 4:
                switch (RandomUnlock)
                {
                    case 1:
                        if (KokkinoBlok.UnlockName == false)
                        {
                            KokkinoBlok.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (KokkinoBlok.UnlockHealth == false)
                        {
                            KokkinoBlok.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (KokkinoBlok.UnlockStrength == false)
                        {
                            KokkinoBlok.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (KokkinoBlok.UnlockDefense == false)
                        {
                            KokkinoBlok.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (KokkinoBlok.UnlockRace == false)
                        {
                            KokkinoBlok.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (KokkinoBlok.UnlockTeam == false)
                        {
                            KokkinoBlok.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                }//Griffin
                break;
            case 5:
                switch (RandomUnlock)
                {
                    case 1:
                        if (Nothrotita.UnlockName == false)
                        {
                            Nothrotita.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (Nothrotita.UnlockHealth == false)
                        {
                            Nothrotita.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (Nothrotita.UnlockStrength == false)
                        {
                            Nothrotita.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (Nothrotita.UnlockDefense == false)
                        {
                            Nothrotita.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (Nothrotita.UnlockRace == false)
                        {
                            Nothrotita.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (Nothrotita.UnlockTeam == false)
                        {
                            Nothrotita.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                }//Cyclops
                break;
            case 6:
                switch (RandomUnlock)
                {
                    case 1:
                        if (Michani.UnlockName == false)
                        {
                            Michani.UnlockName = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 2:
                        if (Michani.UnlockHealth == false)
                        {
                            Michani.UnlockHealth = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 3:
                        if (Michani.UnlockStrength == false)
                        {
                            Michani.UnlockStrength = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 4:
                        if (Michani.UnlockDefense == false)
                        {
                            Michani.UnlockDefense = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 5:
                        if (Michani.UnlockRace == false)
                        {
                            Michani.UnlockRace = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                    case 6:
                        if (Michani.UnlockTeam == false)
                        {
                            Michani.UnlockTeam = true;
                        }
                        else
                        {
                            RandomUnlock = Random.Range(1, 7);
                        }
                        break;
                }//Faniea
                break;
        }
    }

    void LoveKillerInfo()
    {
        if (ErastisDolofonos.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (ErastisDolofonos.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (ErastisDolofonos.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (ErastisDolofonos.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (ErastisDolofonos.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (ErastisDolofonos.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = ErastisDolofonos.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }
       
    }

    void RedBlockerInfo()
    {
        if (KokkinoBlok.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (KokkinoBlok.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (KokkinoBlok.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (KokkinoBlok.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (KokkinoBlok.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (KokkinoBlok.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = KokkinoBlok.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }

    }

    void QueensInfo()
    {
        if (Vas�lisses.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Vas�lisses.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Vas�lisses.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Vas�lisses.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Vas�lisses.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Vas�lisses.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = Vas�lisses.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }

    }

    void SlothInfo()
    {
        if (Nothrotita.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = Nothrotita.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Nothrotita.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = Nothrotita.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Nothrotita.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = Nothrotita.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Nothrotita.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = Nothrotita.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Nothrotita.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = Nothrotita.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Nothrotita.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = Nothrotita.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }

    }

    void ShapeShifterInfo()
    {
        if (Diamorfot�sMorf�s.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Diamorfot�sMorf�s.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Diamorfot�sMorf�s.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Diamorfot�sMorf�s.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Diamorfot�sMorf�s.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Diamorfot�sMorf�s.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = Diamorfot�sMorf�s.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }
    }

    void MachineInfo()
    {
        if (Michani.UnlockName)
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = Michani.Name;
        }
        else
        {
            GameObject.Find("MutantName").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Michani.UnlockHealth)
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = Michani.Health;
        }
        else
        {
            GameObject.Find("MutantHealth").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Michani.UnlockRace)
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = Michani.Race;
        }
        else
        {
            GameObject.Find("MutantRace").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Michani.UnlockStrength)
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = Michani.Strength;
        }
        else
        {
            GameObject.Find("MutantStrength").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Michani.UnlockTeam)
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = Michani.Team;
        }
        else
        {
            GameObject.Find("MutantHunter").GetComponent<TextMeshProUGUI>().text = "????";
        }
        if (Michani.UnlockDefense)
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = Michani.Defense;
        }
        else
        {
            GameObject.Find("MutantDefense").GetComponent<TextMeshProUGUI>().text = "????";
        }
    }

    void selectResearch()
    {
        switch (pageNumber)
        {
            case 1:
                MutantPicked = "Erastis Dolofonos";
                break;
            case 2:
                MutantPicked = "Kokkino Blok";
                break;
            case 3:
                MutantPicked = "Vas�lisses";
                break;
            case 4:
                MutantPicked = "Nothrotita";
                break;
            case 5:
                MutantPicked = "Diamorfot�s Morf�s";
                break;
            case 6:
                MutantPicked = "Michani";
                break;
        }
        ResearchPage.SetActive(false);
        CPagesC.PageNumber = 1;
        CPagesC.PCPU = true;
        CPagesC.IsPickingMission = false;
        CPagesC.IsPickingResource = false;
        CPagesC.IsPickingTraining = false;
    }
}
