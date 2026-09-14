using UnityEngine;

namespace Solution
{
    public class CollectAbleItem : Identity
    {
        public override bool Hit()
        {
            // ตรวจสอบว่ามี Reference ของ Inventory อยู่จริงก่อนเพิ่มไอเท็ม
            if (mapGenerator != null && mapGenerator.player != null && mapGenerator.player.inventory != null)
            {
                mapGenerator.player.inventory.AddItem(Name, 1);
            }
            else
            {
                Debug.LogWarning("ไม่สามารถเพิ่มไอเท็มลง Inventory ได้ เนื่องจากอ้างอิงข้อมูลไม่พบ");
            }

            // ทำลาย GameObject นี้ออกจากฉาก
            Destroy(gameObject);

            return true;
        }
    }
}

