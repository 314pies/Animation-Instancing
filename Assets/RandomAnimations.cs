using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimations : MonoBehaviour
{
    public Vector2 RandomTimeGap = new Vector2(1,5);
    private AnimationInstancing.AnimationInstancing instancing;
    // Start is called before the first frame update
    void Start()
    {
        instancing = GetComponent<AnimationInstancing.AnimationInstancing>();
        Invoke("RndAnim",Random.Range(RandomTimeGap.x, RandomTimeGap.y));
    }

    public int AnimationCount = 2;
    void RndAnim()
    {
        index = Random.Range(0, AnimationCount);
        instancing.CrossFade(index, crossFadeDur);
        Invoke("RndAnim", Random.Range(RandomTimeGap.x,RandomTimeGap.y));
    }

    public int index = 1;
    public float crossFadeDur = 0.3f;

}
