using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMonkey : MonoBehaviour
{
    public GameObject game;
    private Animator anim;
    public GameObject gameO;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressed()
    {
        
        StartCoroutine(IdleCo());
        StartCoroutine(ExplosionCo());
       
    }

    public IEnumerator IdleCo()
    {
        yield return new WaitForSeconds(1.10f);

        game.SetActive(true);
        gameObject.SetActive(false);
    }

    public IEnumerator ExplosionCo()
    {
        yield return new WaitForSeconds(0.11f);
        gameO.SetActive(true);
    }
}
