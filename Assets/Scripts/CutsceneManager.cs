using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{

    public PlayableDirector timeline;
    public GameObject vampire;
    public GameObject mutant1Light;
    public GameObject mutant2Light;
    public GameObject mutant1;
    public GameObject mutant2;
    public TextMeshProUGUI ST1;
    public TextMeshProUGUI ST2;
    public TextMeshProUGUI ST3;
    public TextMeshProUGUI ST4;
    public Button skip;

    void Update()
    {
        if(timeline.time >= 21)
        {
            Destroy(vampire);
        }
        if(timeline.time == timeline.duration) {
            SceneManager.LoadScene("MainMenu");
        }
        if (timeline.time >= 26)
        {
            mutant1Light.SetActive(false);
            mutant2Light.SetActive(false);
        }
        else if (Time.time >= 25)
        {
            Destroy(mutant1);
            Destroy(mutant2);
        }
        else if (timeline.time >= 23) 
        { 
            mutant1Light.SetActive(true);
            mutant2Light.SetActive(true);
        }

        if(timeline.time > 0.6064853f && timeline.time < 6.5f)
        {
            setSubtitles(true, false, false, false);
        }
        else if(timeline.time > 6.5f && timeline.time < 11.765f)
        {
            setSubtitles(false, true, false, false);
        }
        else if(timeline.time > 11.765f && timeline.time < 14.63851f)
        {
            setSubtitles(false, false, true, false);
        } 
        else if(timeline.time > 21.51667f && timeline.time < 24.23018f)
        {
            setSubtitles(false, false, false, true);
        } else
        {
            setSubtitles(false, false, false, false);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            skip.gameObject.SetActive(true);
        } 
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            skip.gameObject.SetActive(false);
        }
    }

    private void setSubtitles(bool s1, bool s2, bool s3, bool s4)
    {
        ST1.gameObject.SetActive(s1);
        ST2.gameObject.SetActive(s2);
        ST3.gameObject.SetActive(s3);
        ST4.gameObject.SetActive(s4);
    } 

    public void loadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
