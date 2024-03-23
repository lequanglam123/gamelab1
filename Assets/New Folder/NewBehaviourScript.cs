using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi, _fa, _sol, _la, _si;
    void Start() 
    {
        Debug.Log("Bat dau");
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("Sol").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Debug.Log("Ban nhan phim A");
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        { 
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _re.Play();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.M)) 
        {
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _sol.Play();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            _si.Play();
        }
    }
}
