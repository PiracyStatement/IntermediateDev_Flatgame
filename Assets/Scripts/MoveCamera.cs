using System.Collections;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDelay()
    {
        StartCoroutine(MoveCameraGameOver(3.5f));
    }

    public IEnumerator MoveCameraGameOver(float delay)
    {
        yield return new WaitForSeconds(delay);
        Vector3 loc = transform.localPosition;
        loc.x = 50f;
        transform.localPosition = loc;
    }
}
