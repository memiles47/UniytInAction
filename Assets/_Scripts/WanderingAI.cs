using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour
{
    [SerializeField] private GameObject fireBallPrefab;

    // Declaration of private reference variables
    private GameObject fireBall;

    // Declaration of private misc variables
    private bool alive;

    // Declaration of public reference variables

    // Declaration of public misc variables
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    // Declaration of public static variables

    // Use this for initialization of reference variables that do not change during game play
    void Awake()
    {
        
    }

    // Use this for initialization
    void Start ()
    {
        alive = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if (hitObject.GetComponent<PlayerCharacter>())
                {
                    if (fireBall == null)
                    {
                        fireBall = Instantiate(fireBallPrefab) as GameObject;
                        fireBall.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        fireBall.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    public void SetAlive(bool aliveChg)
    {
        alive = aliveChg;
    }
}
