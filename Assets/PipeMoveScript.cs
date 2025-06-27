using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float killZone = -35;
    public float scaler = 2;

    public int increment = 5;

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < killZone)
        {
            Destroy(gameObject);
        }

        if (logic.score == increment)
        {

            IncreseSpeed();
            increment += increment;
        }


        void IncreseSpeed()
        {
            moveSpeed += scaler;
        }
    
    }

   
}
