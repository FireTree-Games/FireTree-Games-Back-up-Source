using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Finish : MonoBehaviour
{
    [SerializeField] Conductor conductor;
    float Speed;
    public GameObject FinishPanel;
    public TextMeshProUGUI fullText;
    // Start is called before the first frame update
    void Start()
    {
        Speed = conductor.songBpm / 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(conductor.StartSong)
            this.gameObject.transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name.Contains("Button"))
        {
            FinishPanel.SetActive(true);
            if(Camera.main.GetComponent<Score>().Misses == 0)
            {
                fullText.text = "Complete! \n +Full Combo!";
            }
        }
    }
}
