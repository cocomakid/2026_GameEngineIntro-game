using UnityEngine;

public class TilemapDisabler : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<TilemapDisabler>().enabled = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
