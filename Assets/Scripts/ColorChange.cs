using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer Sprite;
    public GameObject Player;
    private void Update()
    {
       

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        if (hit)
        {
            Platform hitPlat = hit.collider.GetComponent<Platform>();
            Moving hitPlayer = hit.collider.GetComponent<Moving>();
            if (hitPlat)
            {
                Sprite.color = hitPlat.Sprite.color;
            }
            if (hitPlayer)
            {
                Destroy(Player);
            }
        }
    }
}
