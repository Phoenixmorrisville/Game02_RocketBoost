using UnityEngine;

public class StateFXPractice : MonoBehaviour
{
    [SerializeField] ParticleSystem practiceFX;
    [SerializeField] Light practiceLight;

    //effect active is to stop the particle system from constantly getting turned on when its not turned off
    bool effectActive = false;

    void Start()
    {
        practiceLight.enabled = false;
    }

    void Update()
    {
        RespondToDebugKeys();
    }
    void RespondToDebugKeys()
    {
        // P: start the effect only if it is not already active
        if (Input.GetKeyDown(KeyCode.P) && effectActive == false)
        {
            ActivateEffect();
        }
        // R: reset the practice state and stop the particles
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetEffect();
        }
    }
    void ActivateEffect()
    {

        // set the state
        effectActive = true;
        // play the particles
        practiceFX.Play();
        practiceLight.enabled = true;
        // print a useful Console message
        Debug.Log("Practice effect activated.");
    }
    void ResetEffect()
    {
        // reset the state
        effectActive = false;
        // stop the particles
        practiceFX.Stop();
        practiceLight.enabled = false;
        // print a useful Console message
        Debug.Log("Practice effect reset.");
    }
}
