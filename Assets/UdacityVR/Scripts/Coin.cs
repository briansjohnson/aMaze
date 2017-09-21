using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoofEffect;//Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {
        Vector3 coinLoc = gameObject.transform.position;
        // Instantiate the CoinPoof Prefab where this coin is located                    
        Object.Instantiate(coinPoofEffect, new Vector3(coinLoc.x, coinLoc.y, coinLoc.z), transform.rotation);
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
