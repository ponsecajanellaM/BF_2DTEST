using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUNDSWRAPPER : MonoBehaviour
{
    [SerializeField]
    private SCREENBUNDS screenBounds;

    public void TestColliderForWrapping(Collider2D collider)
    {
        if (collider.GetComponent<WrapTrigger>())
        {
            Vector3 newPosition = screenBounds
                .CalculateWrappedPosition(collider.transform.position);
            collider.gameObject.transform.position = newPosition;
        }
    }
}
