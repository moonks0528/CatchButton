
버튼잡기게임(C# 코딩)

개요- C# 프로그래밍 학습 (마우스 이벤트를 이용한 게임 프로그램 구현)
- 핵심기능
    1. 버튼 랜덤 이동
       
        마우스가 버튼 위로 올라오면(MouseEnter 이벤트) 버튼이 폼 내부의 임의의 위치로 이동
        사용자가 버튼을 클릭하는데 난이도 부여
  
    2. 점수 시스템
       
        버튼을 성공적으로 클릭할때마다 점수 100점을 부여하고
        버튼을 클릭하지 못하고 놓치면 점수가 감소
  
    3. 난이도 조절
       
        버튼을 성공적으로 클릭하면 초기 버튼 사이즈에서 10%씩 줄여나가
        버튼 클릭에 난이도를 부여
  
    4. 게임 오버 기능
       
        점수시스템에 의거해 버튼을 클릭하지 못하고 놓혀서 -50점 (5회)이 되면 "게임오버"
  
    5. 게임 재시작 기능
       
        "게임 오버"시 숨겨져 있던 재시작 버튼이 나타남 (Visible 항목 사용

       
- - 화면구성:<img width="1109" height="780" alt="스크린샷 2026-03-12 173917" src="https://github.com/user-attachments/assets/2a126527-5645-4572-b0f9-bec44e7abc53" />

  - 
    초기화면
## 실행화면- 1단계 코드의 실행 스크린샷
1단계: 기본도망기능구현

    <img width="1101" height="793" alt="스크린샷 2026-03-12 174355" src="https://github.com/user-attachments/assets/87d6edf8-132d-453a-9a02-5469c94ed249" />

<img width="1101" height="790" alt="스크린샷 2026-03-12 174403" src="https://github.com/user-attachments/assets/f57250bf-5f41-4b03-b7bd-e9af350c8b26" />
1단계 코드의 실행 스크린샷
초기 화면에서 mouseEnter로 게임이 시작되면 1000ms(1초) 마다 버튼이 폼 내부 임의의 위치로 이동

2단계: 시각적/청각적피드백추가

<img width="1255" height="815" alt="스크린샷 2026-03-12 162114" src="https://github.com/user-attachments/assets/759c45a3-0ba6-48f5-a4d7-009ed959fd3d" />
- 2단계 코드의 실행 스크린샷
<img width="469" height="64" alt="스크린샷 2026-03-12 174737" src="https://github.com/user-attachments/assets/77ed46a0-5707-459c-9f8a-caf439764abe" />
- 클릭 성공시 청각적 피드백(btnCatch_Click)
<img width="503" height="69" alt="스크린샷 2026-03-12 174745" src="https://github.com/user-attachments/assets/62b94145-8927-4a0f-93dc-87b15ae38c7f" />
- 클릭 실패시 청각적 피드백(btnCatch_MouseEnter)
3단계: 점수표시와점수별난이도조정
<img width="1103" height="785" alt="스크린샷 2026-03-12 171846" src="https://github.com/user-attachments/assets/269ace2e-ab23-4015-b322-4cc908e0c7d7" />
-초기 점수 0점 설정(배너 고정)
<img width="1099" height="800" alt="스크린샷 2026-03-12 170302" src="https://github.com/user-attachments/assets/ba81db15-0e27-4fc7-83c6-a2cde0d4feac" />
-난이도 조정(성공시 마다 버튼 크기 10%씩 감소)

4단계: 게임오버및리셋기능추가
<img width="1367" height="899" alt="스크린샷 2026-03-12 171821" src="https://github.com/user-attachments/assets/367cec73-f2b6-420b-8692-8d5d7eda1c2b" />
- 게임 오버 구현(-50 점이 되면 " 게임오버"창이 뜨며 게임이 중단됨
- <img width="1106" height="770" alt="스크린샷 2026-03-12 171829" src="https://github.com/user-attachments/assets/f1e8f8cc-b657-4f5b-9a54-8a2cfe94bf84" />
재시작 버튼이 "게임오버" 전까진 visible:false로 지정되어 보이지 않다가 "게임오버"가 될경우
visible:true로 설정되어 재시작 버튼이 보이게 됨
<img width="1108" height="772" alt="스크린샷 2026-03-12 175839" src="https://github.com/user-attachments/assets/2ce6d086-0cee-42b2-8037-5e1662996fa1" />
-재시작 버튼을 누르면 점수와 좌표가 초기값으로 바뀌고 다시 mouseEnter가 될때 까지 게임이 시작되지 않는다
- 4단계 코드의 실행 스크린샷

- 구현시어려웠던점
      - 초기에 mouseEnter하면 즉각적으로 버튼이 이동하여 클릭하기가 불가능해
      잠시후 이동하게 만들기위해 Thread.Sleep(500)를 사용하였지만
      잠시후 이동은 하지만 버튼 클릭이 안되어 copilot등을 이용해 찾아보니 기존 private void는       일반함수로 Thread.Sleep()사용시 프로그램이 멈췄지만
      비동기 함수 private async void로 바꾸고 await Task.Delay()사용하니
      "기다리지만 프로그램 계속 실행으로 정상적으로 클릭되고 성공알림창이 뜨게 수정하였다
