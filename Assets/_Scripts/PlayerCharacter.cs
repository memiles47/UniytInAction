using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour
{
    // Declaration of private reference variables

    // Declaration of private misc variables
    private int health;

    // Declaration of public reference variables

    // Declaration of public misc variables

    // Declaration of public static variables

    // Use this for initialization of reference variables that do not change during game play
    void Awake()
    {
        health = 5;
    }

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Hurt(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
    }
}
