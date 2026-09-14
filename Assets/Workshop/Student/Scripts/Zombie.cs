using UnityEngine;
namespace Solution
{
    public class Zombie : Character
    {
        // กำหนดสเตตัสเฉพาะตัวของซอมบี้
        [Header("Zombie Settings")]
        public float attackRange = 1.5f;

        // ตัวอย่างการOverride ฟังก์ชันเมื่อซอมบี้ถูกโจมตี หรือทำแอ็กชัน
        public override bool Hit()
        {
            // เรียกการทำงานหลักจาก Character Class (ถ้ามี)
            base.Hit();

            Debug.Log(Name + " (Zombie) ถูกโจมตี!");

            // สามารถใส่โค้ดเล่นเสียงหรือแอนิเมชันเมื่อถูกตีได้ที่นี่

            return true;
        }

        // ตัวอย่างฟังก์ชันการโจมตีผู้เล่น
        public void AttackPlayer()
        {
            if (mapGenerator != null && mapGenerator.player != null)
            {
                // โค้ดสร้างความเสียหายใส่ player
                Debug.Log(Name + " เข้าโจมตีผู้เล่น!");
            }
        }
    }
}