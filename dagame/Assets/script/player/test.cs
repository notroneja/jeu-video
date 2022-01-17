using UnityEngine;

public class test : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
        //transform.position = player.transform.rotation;
    }
}
