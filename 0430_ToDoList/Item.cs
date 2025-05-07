using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0430_ToDoList
{
    class Item
    {
        public static int TotalCount { get; set; } = 0; // 총 Item 수
        public static int CompletedCount { get; set; } = 0; // 완료 Item 수
        public static int IncompletedCount { get; set; } = 0;  // 미완료 Item 수

        public string Name { get; set; }   // 이름
        public string Memo { get; set; }   // 메모 내용
        public DayOfWeek Day { get; }  // 설정 요일
        public DateTime CreatedAt { get; }  // 생성 날짜
        public DateTime? CompletedAt { get; set; }   // 완료 날짜
        public Boolean IsCompleted { get; set; }   // 완료 여부

        public Item(DayOfWeek day, string name)
        {
            this.Name = name;
            this.CreatedAt = DateTime.Now;
            this.IsCompleted = false;
            this.Day = day;
            TotalCount++;
            IncompletedCount++;
        }

        public void ToggleCompleted()
        {
            if (this.IsCompleted == false)
            {
                this.IsCompleted = true;
                CompletedCount++;
                IncompletedCount--;
                this.CompletedAt = DateTime.Now;
            }
            else
            {
                this.IsCompleted = false;
                CompletedCount--;
                IncompletedCount++;
                this.CompletedAt = null;
            }
        }
    }
}
