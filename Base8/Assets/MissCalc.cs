using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissCalc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name.Contains("Note"))
        {
            Camera.main.GetComponent<Score>().score -= 1f;
            Camera.main.GetComponent<Score>().Combo = 0;
            Camera.main.GetComponent<Score>().Misses += 1;
        }
    }
}
