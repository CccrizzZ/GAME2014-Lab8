using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LOSscript : MonoBehaviour
{
    public Collider2D collideWith;
    public ContactFilter2D contactFiler;
    public List<Collider2D> colliders;

    private PolygonCollider2D LOSCollider;

    // Start is called before the first frame update
    void Start()
    {
        LOSCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Physics2D.GetContacts(LOSCollider, contactFiler, colliders);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        collideWith = other;
          
    }

    void OnTriggerStay2D(Collider2D other)
    {
        collideWith = other;
        
    }
}
