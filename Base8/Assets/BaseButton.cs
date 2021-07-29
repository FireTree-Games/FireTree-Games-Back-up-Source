#define DEBUG
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BaseButton : MonoBehaviour
{
    [SerializeField] KeyCode keyToPress;
    [SerializeField] float ScoreTotal;
    SpriteRenderer basbutton;
    public bool NoteOn;
    GameObject CurNote;
    public bool ISDEBUG;
    float heldTime;
    #if (DEBUG)
        [SerializeField]GameObject Note;
    #endif
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        basbutton = this.gameObject.GetComponent<SpriteRenderer>();
        score = Camera.main.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(NoteOn)
            {
                CurNote.SetActive(false);
                NoteOn = false;
                Debug.Log("Note Hit");
                score.score += 1f * score.Combo;
                score.totalNotes += 1;
                score.Combo += 1;
                basbutton.color = Color.black;
            }
            else if(!NoteOn)
            {
                score.score -= 1f;
                score.Combo = 0;
                score.Misses += 1;
                basbutton.color = Color.red;
            }
        }
        else if(Input.GetKeyUp(keyToPress))
        {
            basbutton.color = Color.white;
        }
        if(ISDEBUG && Input.GetKeyDown(keyToPress))
        {
            CREATENOTE(Note);
        }
    }
    void OnCollisionStay2D(Collision2D other) 
    {
        if(other.gameObject.name.Contains("Note"))
        {
            CurNote = other.gameObject;
            NoteOn = true;
            Debug.Log("Note In");
        }    
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.name.Contains("Note"))
        {
            CurNote = null;
            NoteOn = false;
            Debug.Log("Note Not Hit");
        }   
    }
    void CREATENOTE(GameObject notePREFAB)
    {
        GameObject note = Instantiate(notePREFAB);
        note.GetComponent<note>().DEBUG = true;
        note.GetComponent<note>().ONDEBUGADD();
        note.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 10);
    }
    void CalcHit(float AC, GameObject button, GameObject CurNote)
    {
        //Debug.Log(Vector3.Distance(button.transform.position, CurNote.transform.position));
        if(Vector3.Distance(button.transform.position, CurNote.transform.position) >= 1 && Vector3.Distance(button.transform.position, CurNote.transform.position) <= -1)
        {
            Debug.Log("Bad Hit");
            AC -= 5;
        }
        else
        {   
            Debug.Log("Good Hit");
            AC += 5;
        }   
    }
}
