using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL20SymbolExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "tlchain";
        string network = "mainnet";
        string contract = "0xdac17f958d2ee523a2206206994597c13d831ec7";

        string symbol = await TL20.Symbol(chain, network, contract);
        print(symbol);  
    }
}
