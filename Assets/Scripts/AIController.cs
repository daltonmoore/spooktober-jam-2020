using UnityEngine;
using System.Collections;
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Threading;

public class AIController : MonoBehaviour
{
    public int moveSpeed;
    public int maxDistance;
    public Transform target;
    public bool trigger;
    private Transform myTransform;
    Animator anim;

    void Awake()
    {

        myTransform = transform;
    
    }

        void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.tag == "Player")
        {
            target = other.transform;

            maxDistance = 0;
            trigger = true;
        }
    }
   


    void Update()
    {
       
        if (trigger == true)
        {
            Debug.DrawLine(target.position, myTransform.position, Color.yellow);

            if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
            {
                myTransform.position = Vector3.MoveTowards(myTransform.position, target.position, moveSpeed * Time.deltaTime);
                anim.SetTrigger("startWalk");
            }
        }
       
    }
}
