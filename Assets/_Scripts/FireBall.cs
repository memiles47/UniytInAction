using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour
{
    // Declaration of private reference variables

    // Declaration of private misc variables

    // Declaration of public reference variables

    // Declaration of public misc variables
    public float speed;
    public int damage;

    // Declaration of public static variables

    // Use this for initialization of reference variables that do not change during game play
    void Awake()
    {
        speed = 10.0f;
        damage = 1;
    }

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
