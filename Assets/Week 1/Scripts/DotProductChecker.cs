using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductChecker : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check directions of both characters to see if they are facing the same way
        //if Dot product is 1, 
        //they are facing the same way
        if(Vector3.Dot(Player.transform.forward, Enemy.transform.forward) > 0.5)
        {
            Debug.Log("Facing the same way!");
        }
        //if it is -1 they are facing opposite directons
        if (Vector3.Dot(Player.transform.forward, Enemy.transform.forward) < -0.5)
        {
            Debug.Log("Facing the opposite way!");
        }
        //if it is 0 they are facing perpindicular to eachother
        // That is... between 0.5 and  -0.5
        if (Vector3.Dot(Player.transform.forward, Enemy.transform.forward) < 0.5 && Vector3.Dot(Player.transform.forward, Enemy.transform.forward) > -0.5)
        {
            Debug.Log("Facing perpindicular!");
        }


    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Player.transform.position, Player.transform.position + Player.transform.forward);
        Gizmos.DrawLine(Enemy.transform.position, Enemy.transform.position + Enemy.transform.forward);
    }
}
