using UnityEngine;

public class PipwSpwanerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spwanRate = 4;
    public float timer = 0;
    public float pipeOffSet = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
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
