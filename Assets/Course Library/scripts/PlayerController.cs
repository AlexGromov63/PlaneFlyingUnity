using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    public float speed = 20.0f;
    public float turnspeed = 30.0f;

    public Animator anim;

    //опнбепйю ярнкймнбемхъ я опеоърярбхел
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "obstacle")
        {
            Destroy(player);
            //Application.Quit();
            //anim.SetBool("ifWin", false);
            SceneManager.LoadScene("Lose");
            

        }
        else if (col.gameObject.tag == "Finishe")
        {
            Destroy(player);
            //Application.Quit();
            
            SceneManager.LoadScene("Victory");
            //anim.SetBool("ifWin", true);

        }
    }

    void Update()
    {
        ///бшгнд хг хцпш я онлныэч ESCAPE
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        //оепелеыемхе
        var varticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.right, turnspeed * Time.deltaTime * varticalInput);
    }
}
