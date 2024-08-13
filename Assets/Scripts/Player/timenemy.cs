using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float phamViPhatHien = 5f;
    public LayerMask lopKeDich;
    public GameObject danPrefab;
    public float tocDoBan = 1f;
    private float thoiGianBanTiepTheo = 0f;
    public PlayerMove play;

    void Update()
    {
        if (play.dangdi == true)
            return;
        //check di thi ko ban
        PhatHienVaBanKeDich();
    }

    void PhatHienVaBanKeDich()
    {
        Collider2D[] keDichTrongPhamVi = Physics2D.OverlapCircleAll(transform.position, phamViPhatHien, lopKeDich);

        if (keDichTrongPhamVi.Length > 0)
        {
            Transform keDichGanNhat = TimKeDichGanNhat(keDichTrongPhamVi);
            if (keDichGanNhat != null && Time.time > thoiGianBanTiepTheo)
            {
                BanVeKeDich(keDichGanNhat);
                thoiGianBanTiepTheo = Time.time + 1f / tocDoBan;
            }
        }
    }

    Transform TimKeDichGanNhat(Collider2D[] keDich)
    {
        Transform keDichGanNhat = null;
        float khoangCachNganNhat = Mathf.Infinity;

        foreach (Collider2D keDichHienTai in keDich)
        {
            float khoangCachDenKeDich = Vector2.Distance(transform.position, keDichHienTai.transform.position);
            if (khoangCachDenKeDich < khoangCachNganNhat)
            {
                khoangCachNganNhat = khoangCachDenKeDich;
                keDichGanNhat = keDichHienTai.transform;
            }
        }

        return keDichGanNhat;
    }

    void BanVeKeDich(Transform keDich)
    {
        Vector2 huong = (keDich.position - transform.position).normalized;
        GameObject dan = Instantiate(danPrefab, transform.position, Quaternion.identity);
        dan.GetComponent<Dan>().CaiDatHuong(huong);
    }
}
