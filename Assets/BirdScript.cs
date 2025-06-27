using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D bridRigidBody;
    public float FlabStreagth;

    public LogicScript logic;
    public bool isBirdAlive = true;
    public float bottomKillZone = -11;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            bridRigidBody.linearVelocity = Vector2.up * FlabStreagth;
        }
        if (bridRigidBody.position.y < bottomKillZone)
        {
            isBirdAlive = false;
            logic.GameOver();
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        transform.Rotate(new Vector3(0, 0, 90));
        logic.GameOver();
        isBirdAlive = false;
    }
}
