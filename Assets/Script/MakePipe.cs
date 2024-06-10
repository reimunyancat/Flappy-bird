using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float counter = 0;
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > timer) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(0, Random.Range(-1.4f, 5.5f), 0);
            counter = 0;
            Destroy(newpipe, 2.5f);
        }
    }
}
