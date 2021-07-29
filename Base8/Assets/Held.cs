using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Held : MonoBehaviour
{
    [SerializeField] Conductor conductor;
    public float NoteSpeed;
    public bool DEBUG;
    public float Score = 1f;
    public float HeldTime;
    // Start is called before the first frame update
    void Start()
    {
        if(!DEBUG)
        {
            NoteSpeed = conductor.songBpm / 20f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(conductor.StartSong)
        {
            this.gameObject.transform.Translate(Vector3.down * NoteSpeed * Time.deltaTime);
        }
    }
}
