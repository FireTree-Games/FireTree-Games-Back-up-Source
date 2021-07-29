using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SongSelect : MonoBehaviour
{
    [SerializeField] bool song;
    [SerializeField]GameObject[] songs;
    [SerializeField]AudioSource audioS;
    [SerializeField]AudioClip[] audioC;
    [SerializeField]TextMeshProUGUI text;
    [SerializeField]Slider slider;
    [SerializeField]Conductor conductor;
    float length;
    // Start is called before the first frame update
    void Start()
    {
        if(song)
        {
            songs[0].SetActive(song);
            songs[1].SetActive(!song);
            audioS.clip = audioC[0];
        }
        if(!song)
        {
            songs[1].SetActive(!song);
            songs[0].SetActive(song);
            audioS.clip = audioC[1];
        }
        length = audioS.clip.length;
        slider.maxValue = length;
    }

    // Update is called once per frame
    void Update()
    {
        string[] cursong = audioS.clip.ToString().Split((char)32);
        text.text = "Current Song: "+cursong[0] + "\nLength: ";
        if(conductor.StartSong)
        {
            slider.value += Time.deltaTime;
        }
    }
    public void lol()
    {
        song = !song;
        if(song)
        {
            songs[0].SetActive(song);
            songs[1].SetActive(!song);
            audioS.clip = audioC[0];
        }
        if(!song)
        {
            songs[1].SetActive(!song);
            songs[0].SetActive(song);
            audioS.clip = audioC[1];
        }
        length = audioS.clip.length;
        slider.maxValue = length;
    }
    public void GoBack()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}
