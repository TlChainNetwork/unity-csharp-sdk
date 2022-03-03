using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL721URIExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "tlchain";
        string network = "mainnet";
        string contract = "0xbCCaa7ACb552A2c7eb27C7eb77c2CC99580735b9";
        string tokenId = "1";

        string uri = await TL721.URI(chain, network, contract, tokenId);
        print(uri);
    }
}
