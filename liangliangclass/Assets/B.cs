using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public int Bint;
    // Start is called before the first frame update
    void Start()
    {
        Bint = GameObject.Find("A").GetComponent<A>().Aint;
        GetComponent<A>().GetComponent<A>().Afunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
