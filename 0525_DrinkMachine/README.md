# 🍹 Drink Machine

<img src="https://github.com/user-attachments/assets/1e43154b-cff0-4f67-bfc1-1d819b641f8a" width="500">

이 프로젝트는 간단한 음료수 자판기 시스템을 구현한 것입니다.  
클래스를 활용하여 자판기, 음료수, 사용자를 구현하였습니다.

##### 제작날짜 : 2025.05.25

<br>

## 📌 프로젝트 개요

- **언어** : C#
- **프레임워크** : Windows Forms (.NET Framework)
- **주요 기능** : 
    - 현금 투입
    - 음료수 구입
    - 잔돈 반환
- **UI** : 간단한 버튼 기반의 이동, 클릭 기반의 자판기 제어

<br>

## 📸 실행 화면 예시

|Description|Images|
|:--:|:--:|
|첫 실행 화면|<img src="https://github.com/user-attachments/assets/47090ab0-3bd0-4a19-9a65-4c18fc4d0964" width="500">|
|자판기|<img src="https://github.com/user-attachments/assets/41cc1227-6448-4530-ad9c-e874be6851f4" width="500">|

<br>

## 🗂️ 파일 구조

📁 0525_DrinkMachine  
├── Form1.cs   &nbsp;&nbsp;&nbsp; # 초기 화면 Form  
├── Form2.cs   &nbsp;&nbsp;&nbsp; # 자판기 Form  
├── Human.cs   &nbsp;&nbsp;&nbsp; # 사용자 Class  
├── Machine.cs   &nbsp;&nbsp; # 자판기 Class  
├── Drink.cs   &nbsp;&nbsp;&nbsp; # 음료수 Class  
├── 📁 Properties  &nbsp;&nbsp;&nbsp; # 프로젝트 설정 및 리소스 파일  
└── 📁 images  &nbsp;&nbsp;&nbsp; # UI에서 사용하는 이미지 리소스

<br>

⚠️ .sln, .csproj, .resx, .config 등 Visual Studio에서 자동 생성된 파일은 생략하였습니다.

<br>

## 주요 클래스

### **`Human`**
- 개요 :  자판기 이용자
- 클래스 변수 : 이름, 현금, 인벤토리
- 메서드 : 음료수 획득

### **`Machine`**
- 요 : 자판기
- 클래스 변수 : 이름, 투입된 현금, 금고, 음료수 재고
- 메서드 : 현금 처리 메서드, 음료 제공 메서드

### **`Drink`**
- 개요 : 음료수
- 클래스 변수 : 번호, 이름, 가격, 수량

<br>

## 📃 라이선스
이 프로젝트는 학습 및 개인 포트폴리오 용도로 자유롭게 사용할 수 있습니다.  
별도의 라이선스는 적용되지 않았습니다.
