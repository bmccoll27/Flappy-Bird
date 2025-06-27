using UnityEngine;

public class ParticleContorolSystem : MonoBehaviour
{
    public ParticleSystem particles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        particles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
