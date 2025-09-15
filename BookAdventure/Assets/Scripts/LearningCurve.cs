using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //accessModifier dataType UniqueName = value;
    //example -> public int CurrentAge = 99;
    public int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Prince";
    public string FullName = "Princewill" + "Francis";
    public bool IsCreator = true;
    public int CurrentGold = 32;
    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";
    public string CharacterAction = "Attack";
    public int Dice = 7;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //<- void start is a method, same with void ComputeAge

    {
        //if (IsCreator = true)
        //{

        //    Debug.Log("You are not the Creator, get out!");
        //  }

        //Debug.Log(30 + 1);
        //Debug.Log(CurrentAge + 1);

        //ComputeAge();
        // Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        //int characterLevel = 32;
        //GenerateCharacter("Spike", characterLevel);

        //int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        // Debug.Log(nextSkillLevel);
        // Debug.Log(GenerateCharacter("Faye", characterLevel));

        Thievery();
        OpenTreasureChamber();
        PrintCharacterAction();
        RollDice();
    }

    public void RollDice() //<-- switch
    {
        switch (Dice)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
         }
     }

    public void PrintCharacterAction() //<-- switch
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    
    public void Thievery() //<--if else
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }


    // <summary>
    // Computes a modified age by adding two variables together
    /// </summary>

    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public void OpenTreasureChamber() //<--- nested if else
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
         }
     }

    
    // Update is called once per frame
    void Update()
    {

    }
    // variables are containers for storing data values
    //methods are blocks of code which only run when its called
    //methods also store and execute instructions

    // method Without parameters example below
    // UniqueName();
    // With parameters below 
    // UniqueName(parameterVariable);

}
