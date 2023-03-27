using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Horizontalinpýt;
    public float Verticalinp;
    public float speed;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);

        }
        Horizontalinpýt = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * Horizontalinpýt);
        Verticalinp = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Verticalinp);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
