using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class GamePurchase : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
	}

    private void PurchaseManager_OnPurchaseNonConsumable(PurchaseEventArgs args)
    {
        Debug.Log("your purchese" + args.purchasedProduct.definition.id);
    }
}
