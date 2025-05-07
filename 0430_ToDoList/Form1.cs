using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// O 요일을 바꿔도 그룹박스는 기존 요일의 할 일 정보를 보여주는 문제 해결해야함
// O 할 일 만들면 요일 밑 라벨 숫자도 올라가도록
// 상세 정보 부분부터 작업 시작
namespace _0430_ToDoList
{
    public partial class Form1 : Form
    {
        // item이 저장될 List
        BindingList<Item> sunItems = new BindingList<Item>();
        BindingList<Item> monItems = new BindingList<Item>();
        BindingList<Item> tueItems = new BindingList<Item>();
        BindingList<Item> wedItems = new BindingList<Item>();
        BindingList<Item> thuItems = new BindingList<Item>();
        BindingList<Item> friItems = new BindingList<Item>();
        BindingList<Item> satItems = new BindingList<Item>();
        BindingList<Item> doneItems = new BindingList<Item>();
        // List를 DayOfWeek와 묶어 Dictionary에 저장
        Dictionary<DayOfWeek, BindingList<Item>> weekDic = new Dictionary<DayOfWeek, BindingList<Item>>();
        // 바인딩소스 생성
        BindingSource bs = new BindingSource();
        // 요일 밑 Label들 담아둘 Dictionary
        Dictionary<DayOfWeek, Label> dayLbls = new Dictionary<DayOfWeek, Label>();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(716, 250);
            listBox.DataSource = bs;
            // item List들 Dictionary에 삽입
            weekDic.Add(DayOfWeek.Sunday, sunItems);
            weekDic.Add(DayOfWeek.Monday, monItems);
            weekDic.Add(DayOfWeek.Tuesday, tueItems);
            weekDic.Add(DayOfWeek.Wednesday, wedItems);
            weekDic.Add(DayOfWeek.Thursday, thuItems);
            weekDic.Add(DayOfWeek.Friday, friItems);
            weekDic.Add(DayOfWeek.Saturday, satItems);
            // 요소 밑 Label들 Dictionary에 삽입
            dayLbls.Add(DayOfWeek.Sunday, lblSunCount);
            dayLbls.Add(DayOfWeek.Monday, lblMonCount);
            dayLbls.Add(DayOfWeek.Tuesday, lblTueCount);
            dayLbls.Add(DayOfWeek.Wednesday, lblWedCount);
            dayLbls.Add(DayOfWeek.Thursday, lblThuCount);
            dayLbls.Add(DayOfWeek.Friday, lblFriCount);
            dayLbls.Add(DayOfWeek.Saturday, lblSatCount);
        }

        // Item 생성 버튼 클릭 이벤트 메서드
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (sender == tbInputName && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;   // 엔터키 눌렀을 때도 작동하도록 함
            // 요일 지정하지 않았으면 return
            if (btnCreateItem.Tag == null)
            {
                MessageBox.Show("요일을 선택해주세요.");
                return;
            }
            // 이름을 입력하지 않았으면 return
            if (tbInputName.Text == "") return;
            // item 등록
            if (weekDic.ContainsKey((DayOfWeek)btnCreateItem.Tag))  // 이럴 일은 없겠지만 습관을 들이기 위해 사용함
            {
                // 객체 생성 & 리스트에 삽입
                Item item = new Item((DayOfWeek)btnCreateItem.Tag, tbInputName.Text);
                weekDic[item.Day].Add(item);
                tbInputName.Text = "";  // 입력창 clear
                lblIncompletedCount.Text = "미완료 : " + Item.IncompletedCount;    // 미완료 개수 표시
                // 요일 밑 라벨에 숫자 표시
                dayLbls[item.Day].Text = weekDic[item.Day].Count.ToString();
                dayLbls[item.Day].Visible = true;
            }
        }

        // 선택한 Item 변경 시 Group 내용도 바뀌게 하는 메서드
        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                pnlInfo.Visible = false;
                lblInfo.Visible = false;
                return;
            }
            Item item = (Item)listBox.SelectedItem;
            pnlInfo.Visible = true;
            lblInfo.Visible = true;
            tbEditName.Text = item.Name;
            lblCreatedAt.Text = "생성날짜 : " + item.CreatedAt;
            lblCompletedAt.Text = "완료날짜 : " + item.CompletedAt;
            tbMemo.Text = item.Memo;
            if (item.IsCompleted == true) btnToggleComplete.Text = "✔";
            else btnToggleComplete.Text = "";
        }

        // 요일 버튼 클릭 이벤트 메서드
        private void dayBtn_Clicked(object sender, EventArgs e)
        {
            changeSIze();
            btnCreateItem.Tag = ((Button)sender).Tag;
            bs.DataSource = weekDic[(DayOfWeek)((Button)sender).Tag];
            listBox.DisplayMember = "Name";
        }

        // 이름 수정 버튼 클릭 이벤트
        private void btnEditName_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            ((Item)listBox.SelectedItem).Name = tbEditName.Text;
            bs.ResetBindings(false);
        }

        // 메모 저장 버튼 클릭 이벤트
        private void btnMemo_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            ((Item)listBox.SelectedItem).Memo = tbMemo.Text;
        }
        // item 완료 버튼 클릭 이벤트
        private void btnToggleComplete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            Item item = (Item)listBox.SelectedItem;
            if (item.IsCompleted == false)
            {
                item.ToggleCompleted();
                btnToggleComplete.Text = "✔";
                doneItems.Add(item);
                weekDic[item.Day].Remove(item);
                if (weekDic[item.Day].Count == 0) dayLbls[item.Day].Text = "😎";
                else dayLbls[item.Day].Text = weekDic[item.Day].Count.ToString();
            }
            else
            {
                item.ToggleCompleted();
                btnToggleComplete.Text = "";
                doneItems.Remove(item);
                weekDic[item.Day].Add(item);
                dayLbls[item.Day].Text = weekDic[item.Day].Count.ToString();
            }
            lblCompletedCount.Text = "완료 : " + Item.CompletedCount;
            lblIncompletedCount.Text = "미완료 : " + Item.IncompletedCount;

        }

        // 완료한 목록 버튼 클릭 이벤트
        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (doneItems.Count == 0)
            {
                MessageBox.Show("완료한 할 일이 없습니다.");
                return;
            }
            bs.DataSource = doneItems;
            this.Size = new Size(716, 510);
            listBox.Visible = true;
            lblItemList.Visible = true;
            tbInputName.Visible = true;
            btnCreateItem.Visible = true;
        }

        // 삭제 버튼 클릭 이벤트
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            DialogResult result = MessageBox.Show("할 일을 삭제하시겠습니까?", "할 일 삭제", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Item item = (Item)listBox.SelectedItem;
                if (item.IsCompleted == true)
                {
                    bs.Remove(item);
                Item.CompletedCount--;
                }
                else
                {
                    weekDic[item.Day].Remove(item);
                    if (weekDic[item.Day].Count == 0) dayLbls[item.Day].Text = "😎";
                    else dayLbls[item.Day].Text = weekDic[item.Day].Count.ToString();
                    Item.IncompletedCount--;
                }
                Item.TotalCount--;
                lblCompletedCount.Text = "완료 : " + Item.CompletedCount;
                lblIncompletedCount.Text = "미완료 : " + Item.IncompletedCount;
            }



        }

        // 폼 크기 전환
        public void changeSIze()
        {
            this.Size = new Size(716, 510);
            listBox.Visible = true;
            lblItemList.Visible = true;
            tbInputName.Visible = true;
            btnCreateItem.Visible = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 510)
            {
                this.Size = new Size(716, 250);
                lblInfo.Visible = false;
                listBox.Visible = false;
                lblItemList.Visible = false;
                tbInputName.Visible = false;
                btnCreateItem.Visible = false;
            }
        }
    }
}
