using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    // gene for colour
    public float r;
    public float g;
    public float b;

    bool dead = false;
    public float timeToDie = 0;

    // 　使用できるようにする
    SpriteRenderer sRenderer;
    Collider2D sCollider;

    void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead at：" + timeToDie);　//clickしたかチェック

        sRenderer.enabled = false;
        sCollider.enabled = false;
    }

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
    }

    void Update()
    {

    }

}
