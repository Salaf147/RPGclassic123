using UnityEngine;

public class QuanLyMau : MonoBehaviour
{
    public float diemMauToiDa = 100f; // Điểm máu tối đa của đối tượng
    private float diemMauHienTai;

    void Start()
    {
        // Khởi tạo điểm máu hiện tại bằng điểm máu tối đa
        diemMauHienTai = diemMauToiDa;
    }

    // Hàm để đối tượng mất máu
    public void MatMau(float luongMau)
    {
        diemMauHienTai -= luongMau;

        // Kiểm tra nếu điểm máu về 0 hoặc thấp hơn
        if (diemMauHienTai <= 0)
        {
            Chet();
        }
    }

    // Hàm xử lý khi đối tượng chết
    private void Chet()
    {
        // Có thể thêm hiệu ứng, âm thanh, hoặc hành động khác ở đây
        Destroy(gameObject);
    }
}
