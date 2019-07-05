using UnityEngine;

public class EyeTarget : MonoBehaviour
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

        Vector3 touchScreenPosition = Input.mousePosition;

        // 10.0fに深い意味は無い。画面に表示したいので適当な値を入れてカメラから離そうとしているだけ.
        touchScreenPosition.z = 10.0f;

        Camera gameCamera = Camera.main;
        Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);

        m_object.transform.position = touchWorldPosition;

    }
}