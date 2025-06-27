using UnityEngine;

public class PipwSpwanerScript : MonoBehaviour
{

    public GameObject pipe;
    
    public float timer = 0;
    public float pipeOffSet = 10;
    private LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanPipe();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < logic.spwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpwanPipe();
            timer = 0;
        }

    }

    void SpwanPipe()
    {
        float lowestHight = transform.position.y - pipeOffSet;
        float highestHight = transform.position.y + pipeOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestHight,highestHight), 0), transform.rotation);
    }
}
