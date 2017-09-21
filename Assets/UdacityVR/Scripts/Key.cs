using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoofEffect;
    public GameObject openDoor;
    public bool keyCollected = false;
    //Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        Vector3 keyLoc = gameObject.transform.position;
        // Instatiate the KeyPoof Prefab where this key is located
        Object.Instantiate(keyPoofEffect, new Vector3(keyLoc.x, keyLoc.y, keyLoc.z), transform.rotation);
        // Make sure the poof animates vertically
        openDoor.GetComponent<Door>().Unlock();
        // Call the Unlock() method on the Door
        keyCollected = true;
        // Set the Key Collected Variable to true
        Destroy(gameObject);
        // Destroy the key. Check the Unity documentation on how to use Destroy

    }

}
