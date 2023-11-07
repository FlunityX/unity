using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.SceneManagement;

public class finishlevel : MonoBehaviour
{
    [SerializeField]private AudioSource finishsound;
    // Start is called before the first frame update
    void Start()
    {
        finishsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)

    {
    if (collision.gameObject.name == "dog")
    {
        finishsound.Play();
        Invoke("Completelevel",2f);
        Completelevel();
    }    
    }
    private void Completelevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
