using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool locked;
    public bool opening;
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
    // Create a boolean value called "opening" that can be checked in Update() 
    public AudioClip lockedSoundClip;
    public AudioClip openSoundClip;
    private AudioSource audioSource;


    void Update() {
        // If the door is opening and it is not fully raised
        if (opening & (transform.position.y < 7.85f) == true)
        {
            transform.Translate(0, 0.5f * Time.deltaTime, 0, Space.World);
        }
            // Animate the door raising up
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        if(!locked)
        {
            opening = true;
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = openSoundClip;
            audioSource.Play();
        }
        else
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = lockedSoundClip;
            audioSource.Play();
            print("Door is locked!");
        }
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
        print("Key Picked Up!");
        if (!locked)
        {
            print("Door is unlocked");
        }
    }
}
