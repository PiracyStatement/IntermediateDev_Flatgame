using UnityEngine;

public class Background : MonoBehaviour
{
    private BoxCollider2D bc;
    private SpriteRenderer sr;

    private PlayerWalk pw;

    public Sprite bg_1;
    public Sprite bg_2;
    public Sprite bg_3;
    public Sprite bg_4;

    public int currentBg = 1;

    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();

        pw = GameObject.Find("Player").GetComponent<PlayerWalk>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (currentBg)
        {
            case 1:
                sr.sprite = bg_2;
                currentBg++;
                pw.MoveTo(-3);

                Vector3 loc2 = transform.localPosition;
                loc2.y = -1.5f;
                transform.localPosition = loc2;

                break;

            case 2:
                sr.sprite = bg_3;
                currentBg++;
                pw.MoveTo(-3);
                break;

            case 3:
                sr.sprite = bg_4;
                currentBg++;
                pw.MoveTo(4);

                Vector3 loc4 = transform.localPosition;
                loc4.y = 0;
                transform.localPosition = loc4;
                break;
        }
    }
}
