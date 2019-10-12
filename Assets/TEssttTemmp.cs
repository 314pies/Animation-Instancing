using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEssttTemmp : MonoBehaviour
{

    private AnimationInstancing.AnimationInstancing instancing;
    // Start is called before the first frame update
    void Start()
    {
        instancing = GetComponent<AnimationInstancing.AnimationInstancing>();
    }

    public int index = 1;
    public float crossFadeDur = 0.3f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
		    instancing.CrossFade(index, crossFadeDur);
        if (Input.GetKeyDown(KeyCode.S))
            instancing.PlayAnimation(index);
    }
}
