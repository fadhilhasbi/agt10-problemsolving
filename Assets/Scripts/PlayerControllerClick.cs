using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Problem 5
public class PlayerControllerClick : MonoBehaviour
{
    // Mengatur kecepatan awal, inisiasi Vector2, dan buat sebuah nilai bool untuk menyimpan kondisi gerakan/moving
    [SerializeField]
    private float speed = 10f;
    Vector2 lastClickedPos;

    bool moving;

    private void Update()
    {
        // Jika left click ditekan/ditahan maka ambil nilai dari posisi input mouse tersebut dan nyatakan moving = true
        if (Input.GetMouseButton(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        // Jika moving true dan letak posisi mouse tidak pada posisi vector position maka jalankan object player
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        }
        else
        {
            // Jika tidak maka moving false artinya player tidak dijalankan
            moving = false;
        }
    }
}
