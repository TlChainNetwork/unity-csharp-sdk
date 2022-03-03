using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL721OwnerOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "tlchain";
        string network = "mainnet";
        string contract = "0xcB0cbcE06860f6C30C62560f5eFBF918150e056E";
        string tokenId = "1";

        string ownerOf = await TL721.OwnerOf(chain, network, contract, tokenId);
        print(ownerOf);
    }
}
