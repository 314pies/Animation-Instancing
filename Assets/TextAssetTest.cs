using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAssetTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset asset = Resources.Load("Dude_low_instancing") as TextAsset;
        Debug.Log(asset.bytes.Length);
    }
}
