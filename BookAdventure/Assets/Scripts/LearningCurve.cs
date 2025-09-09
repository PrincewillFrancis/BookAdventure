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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //<- void start is a method, same with void ComputeAge

    {
        //Debug.Log(30 + 1);
        //Debug.Log(CurrentAge + 1);

        //ComputeAge();
       // Debug.Log($"A string can have variables like {FirstName} inserted directly!");
        int characterLevel = 32;
        //GenerateCharacter("Spike", characterLevel);

        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
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
