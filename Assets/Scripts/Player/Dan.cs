using UnityEngine;

public class Dan : MonoBehaviour
{
    public float tocDo = 10f;
    private Vector2 huong;

    void Update()
    {
        DiChuyenDan();
    }

    public void CaiDatHuong(Vector2 huongMoi)
    {
        huong = huongMoi;
        XoayTheoHuong();
    }

    void DiChuyenDan()
    {
        transform.Translate(huong * tocDo * Time.deltaTime, Space.World);
    }

    void XoayTheoHuong()
    {
        float goc = Mathf.Atan2(huong.y, huong.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(goc, Vector3.forward);
    }

   
}
