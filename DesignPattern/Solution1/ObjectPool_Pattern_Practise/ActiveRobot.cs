using System;
using System.Collections.Generic;
using System.Collections;

namespace ObjectPool_Pattern_Practise
{
    class ActiveRobot
    {
        static void Main(string[] args)
        {
            //Tạo ra 2 picker khác nhau 
            AutomatedPicker picker1 = PickerPool.GetPicker();
            AutomatedPicker picker2 = PickerPool.GetPicker();
            //AutomatedPicker picker3 = PickerPool.GetPicker();
            //AutomatedPicker picker4 = PickerPool.GetPicker();
            //AutomatedPicker picker5 = PickerPool.GetPicker();
            //AutomatedPicker picker6 = PickerPool.GetPicker();
            //AutomatedPicker picker7 = PickerPool.GetPicker();
            //AutomatedPicker picker8 = PickerPool.GetPicker();

            //Đặt tên cho 2 picker là Picker 1 và Picker 2 
            picker1.Identify("Megatron");
            picker2.Identify("Optimus");

            //Di chuyển 2 picker đến các vị trí khác nhau 
            picker1.GoToLocation("Moon");
            picker2.GoToLocation("Earth");

            //yêu cầu 2 picker nhận vật phẩm và chuyển đến vị trí yêu cầu, sau đó trả vật phẩm.
            picker1.Pick("Gun");
            picker2.Pick("Sword");

            picker1.GoToLocation("Earth");
            picker2.GoToLocation("Moon");

            picker1.Drop();
            picker2.Drop();

            //Sau khi đã trả vật phẩm, giải phóng các picker 
            PickerPool.ReleasePicker(picker1);
            PickerPool.ReleasePicker(picker2);
        }
    }
    /* Bước 1: Thiết lập lớp AutomatedPicker, chính là các robot với các thuộc tính PickerId,
     * CurrentLocation (vị trí hiện tại), Carrying (vật phẩm
     * mang theo) cùng với 1 constructor chứa 1 tham số, là ID của robot*/
    public class AutomatedPicker
    {
        public int PickerId { get; private set; }
        public string CurrentLocation { get; private set; }
        public string Carrying { get; private set; }
        public AutomatedPicker(int pickerId)
        {
            PickerId = pickerId;
            CurrentLocation = "Recharging Station";
        }
        /*Bước 2: Xây dựng các phương thức cho robot gồm có:
         * ShowMessage() để hiển thị thông báo
         * Identify() để định danh robot
         * GoToLocation() để di chuyển
         * Pick() để nhận vật phẩm
         * Drop() để thả vật phẩm*/
        private void ShowMessage(string msg)
        {
            Console.WriteLine("Picker {0} : {1}", PickerId, msg);
        }
        public void Identify(string code)
        {
            ShowMessage("Identify as" + code);
        }
        public void GoToLocation(string location)
        {
            CurrentLocation = location;
            ShowMessage("At" + location);
        }
        public void Pick(string item)
        {
            Carrying = item;
            ShowMessage("Picked up " + item);
        }
        public void Drop()
        {
            Console.WriteLine("Dropped"+ Carrying);
            Carrying = null;            
        }       
    }
    /*Bước 3: xây dựng lớp PickerPool. Vì bài toán chỉ cần 1 pool, do vậy có thể xây dựng lớp static. 
     * Lớp này gồm các thuộc tính: PickerCount (số lượng robot), 
     * available (list các robot chưa được sử dụng) và inUse (list các robot đang được sử dụng) cùng 1 constructor được sử dụng để
     * thêm các robot vào danh sách available.*/
    public static class PickerPool
    {
        const int PICKERCOUNT = 5;
        private static List<AutomatedPicker> available = new List<AutomatedPicker>();
        private static List<AutomatedPicker> inUse = new List<AutomatedPicker>();
        static PickerPool()
        {
            for (int i = 1; i < PICKERCOUNT; i++)
            {
                available.Add(new AutomatedPicker(i));
            }
        }
        public static AutomatedPicker GetPicker()
        {
            lock (available)
            {
                if (available.Count > 0)
                {
                    AutomatedPicker picker = available[0];
                    inUse.Add(picker);
                    available.RemoveAt(0);
                    return picker;
                }
                else
                {
                    throw new InvalidOperationException("No available picker");
                }
            }
        }
        private static void Reset(AutomatedPicker picker)
        {
            if(picker.Carrying != null)
            {
                picker.Drop();
            }
            picker.GoToLocation("Recharging Location");
        }
        public static void ReleasePicker(AutomatedPicker picker)
        {
            Reset(picker);
        }
    }
}
