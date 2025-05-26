# 🍹 Drink Machine

<img src="" width="1000">

이 프로젝트는 간단한 음료수 자판기 시스템을 구현한 것입니다.
클래스를 활용하여 자판기, 음료수, 이용자를 구현하였습니다.

##### 제작날짜 : 2025.05.25

<br>

## 📌 프로젝트 개요

- **플랫폼** : C# (WindowsForms)
- **주요 기능** : 
    - 현금 투입
    - 음료수 구입
    - 잔돈 반환
- **UI** : 간단한 버튼 기반의 이동, 클릭 기반의 자판기 제어

<br>

## 🗂️ 파일 구조

📁 0525_DrinkMachine  
├── Form1.cs   &nbsp;&nbsp;&nbsp; # 초기 화면 Form  
├── Form2.cs   &nbsp;&nbsp;&nbsp; # 자판기 Form  
├── Human.cs   &nbsp;&nbsp;&nbsp; # 사용자 Class  
├── Machine.cs   &nbsp;&nbsp; # 자판기 Class  
├── Drink.cs   &nbsp;&nbsp;&nbsp; # 음료수 Class  
├── 📁 Properties  
└── 📁 images

<br>

## 주요 클래스

### **`Human`**
- 개요 :  자판기 이용자
- 클래스 변수 : 이름, 현금, 인벤토리
- 메서드 : 음료수 획득

### **`Machine`**
- 게요 : 자판기
- 클래스 변수 : 이름, 투입된 현금, 금고, 음료수 재고
- 메서드 : 현금 처리 메서드, 음료 제공 메서드

### **`Human`**
- 개요 : 음료수
- 클래스 변수 : 번호, 이름, 가격, 수량

<br>

## 📃 라이선스
본 프로젝트는 자유롭게 수정/재배포할 수 있습니다. 학습 및 개인 포트폴리오 용도로 사용 가능합니다.