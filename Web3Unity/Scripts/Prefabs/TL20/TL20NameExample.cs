using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL20NameExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "tlchain";
        string network = "mainnet";
        string contract = "0xa106739de31fa7a9df4a93c9bea3e1bade0924e2";

        string name = await TL20.Name(chain, network, contract);
        print(name); 
    }
}
