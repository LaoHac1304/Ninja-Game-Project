using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    public float scrollSpeed;  // Tốc độ cuộn ban đầu
    public float jumpScrollSpeed;  // Tốc độ cuộn khi nhảy lên
    private float originalScrollSpeed;  // Giữ tốc độ cuộn ban đầu
    private bool isJumping;  // Trạng thái nhảy
    Vector2 GerakTexture;
	Renderer gambar;

	// Use this for initialization
	void Start () {
        gambar = GetComponent<Renderer>();
        originalScrollSpeed = scrollSpeed;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        GerakTexture = new Vector2(Time.time * scrollSpeed, 0);

        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            gambar.sharedMaterial.SetTextureOffset("_MainTex", GerakTexture);
        }

        // Kiểm tra trạng thái nhảy
        if (isJumping)
        {
            scrollSpeed = jumpScrollSpeed;  // Sử dụng tốc độ cuộn khi nhảy
        }
        else
        {
            scrollSpeed = originalScrollSpeed;  // Sử dụng tốc độ cuộn ban đầu
        }
    }

}
