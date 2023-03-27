using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float WaitTime;
    public static bool ısReaddy ;


    private void Start()
    {
        ısReaddy = true;
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && ısReaddy == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(Delay(WaitTime));
        }
    }


    IEnumerator Delay(float waittime)
    {
        ısReaddy = false;
        Debug.Log("spaceye bastım");
        yield return new WaitForSeconds(waittime);
        Debug.Log("2 saniye geçti");
        ısReaddy = true;
    }
}
