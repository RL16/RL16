using UnityEngine;

public class Handle : MonoBehaviour
{

    [SerializeField]
    private GameObject m_object = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (m_object.transform.position.x < transform.position.x)
        {
            if (transform.position.x >= -1)
            {
                transform.position -= new Vector3(0.1f, 0f, 0f);
            }
        }
        else
        {
            if (transform.position.x <= 1)
            {
                transform.position += new Vector3(0.1f, 0f, 0f);
            }
        }

    }
}