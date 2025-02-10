using UnityEngine;

public class BombSite : MonoBehaviour
{
    private Background bgScript;
    private PlayerWalk pwScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bgScript = GameObject.Find("Background").GetComponent<Background>();
        pwScript = GameObject.Find("Player").GetComponent<PlayerWalk>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bgScript.currentBg == 4)
        {
            pwScript.PlantBomb();
        }
    }
}
