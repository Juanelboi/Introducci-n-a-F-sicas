using UnityEngine;

public class CubosCambiaColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.name;
        this.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Colision con: " + tag);
    }
}
