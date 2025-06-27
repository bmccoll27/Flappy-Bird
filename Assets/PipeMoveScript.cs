using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PipeMoveScript : MonoBehaviour
{

    public float killZone = -35;

   

    private LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * logic.pipeSpeed * Time.deltaTime;

        if (transform.position.x < killZone)
        {
            Destroy(gameObject);
        }

    
    }

   
}
