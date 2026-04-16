using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Car_Crash_Logic : MonoBehaviour
{

    public float carTimerMax;
    public float carTimerCurrent;
    public float violenceTimingMax;
    public float violenceTimingCurrent;

    public bool violenceTime;

    Player player;

    public AudioSource carSource;
    //public AudioClip carHorns;

    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<Player>();
        carTimerCurrent = carTimerMax;
        violenceTimingCurrent = violenceTimingMax;
        violenceTime = false;
        carSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (carTimerCurrent > 0) 
        { 
            carTimerCurrent -= Time.deltaTime;
        }
        if (carTimerCurrent <= 0) 
        {
            violenceTimingCurrent -= Time.deltaTime;
            violenceTime = true;
            //carSource.PlayOneShot(carHorns);
            carSource.Play();
        }
        if (violenceTimingCurrent <= 0)
        {
            carTimerCurrent = carTimerMax;
            violenceTimingCurrent = violenceTimingMax;
            violenceTime = false;
        }
    }
}
