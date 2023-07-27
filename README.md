<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
  </a>

  <h1 align="center">🎵 Feel My Rhythm Project</h1>

  <p align="center">
    KAIST 2023 여름 몰입캠프 4주차 과제 (2분반 김창완, 이선규)  
  <br />
  <br />
  <br />
  </p>
</div>

## :pushpin: 몰입캠프 4주차 과제 (자유주제)

둘 다 게임 개발을 해 본 적이 없고, Unity를 이번 기회에 한 번 배우고 싶었다.  
공통 관심사인 음악을 즐길 수 있는 게임 프로젝트인 "리듬 게임" 개발을 이번 주차 주제로 삼았다.  

## :pushpin: 개발 환경

- Unity(C#) + Vscode

## :pushpin: 역할 분담

- 공통: 디테일한 버그 수정
- 김창완: 리듬게임 씬, 파일선택 씬 구현
- 이선규: 홈 화면 씬, 음악선택 씬 구현

## :pushpin: 서비스 설명
![캡처](https://github.com/changwann/madcamp_week4_2/assets/122224659/a14329a5-6dd3-4b27-bc6b-a9fd3a016778)  
시작화면은 위와 같다. 현재는 PLAY 버튼만 구현이 되어 있다.  
   
![캡처2](https://github.com/changwann/madcamp_week4_2/assets/122224659/1272d738-b7e7-41d7-bd28-6c5b5d699e8a)  
PLAY 버튼을 누를 경우 위 화면으로 전환이 된다.  
이 화면에서는 미리 준비된 노래 리스트 중 플레이하고 싶은 노래를 미리 들어보고, 선택한 후 GO 버튼을 눌러 리듬게임을 진행할 수 있다.
MAIN 버튼을 누를 경우 처음 화면으로 다시 돌아간다.   
  
![Animation1](https://github.com/changwann/madcamp_week4_2/assets/122224659/9bcca8a9-120a-47ba-b23d-053049dab106)  
위와 같이 노래를 선택할 경우, 해당하는 노래 제목이 상단에 뜨면서 자동으로 노래가 재생된다.  
오른쪽의 슬라이더를 통해 볼륨을 조절하고자 했다. 
FILE.. 버튼을 누르면 로컬 환경에서 원하는 노래 파일을 선택할 수 있는 창으로 이동한다.   
  
![Animation2](https://github.com/changwann/madcamp_week4_2/assets/122224659/968d13c6-7fe3-4cc8-8233-002ca9418dc3)  
기본적으로 바탕화면에서 파일 탐색이 시작되며, 자유로운 폴더 이동이 가능하다.  
mp3 파일을 누를 경우 미리 들어볼 수 있는 플레이어가 나타나게 되며, 재생/일시정지/정지 기능이 모두 정상 작동한다.  
마음에 드는 경우 PLAY 버튼을 눌러 해당 노래로 리듬게임을 즐길 수 있게 만들고자 했다.   
  
![Animation3](https://github.com/changwann/madcamp_week4_2/assets/122224659/c79d08c3-3373-4c63-841e-078855ae5851)  
아래는 게임을 플레이했을 때 보이는 화면이며, 노래의 bpm에 맞게 큐브가 떨어지지 않도록 도착지점까지 WASD로 조작하는 것이 게임의 목표이다.  
박자에 맞게 나오는 노트(세로로 긴 흰색 바)의 타이밍에 맞게 키보드를 누를수록 점수가 크게 쌓이며, 연속으로 성공할수록 콤보가 쌓여 보너스 점수를 얻을 수 있다.  
   
![Animation4](https://github.com/changwann/madcamp_week4_2/assets/122224659/30790d35-81dc-4b5b-8cb4-72989b45edc8)  
5콤보를 쌓일 때마다, 하트보다 우선적으로 소모되는 쉴드를 하나 얻을 수 있다. 최대 3개까지 얻을 수 있다.   
  
![Animation5](https://github.com/changwann/madcamp_week4_2/assets/122224659/780be57f-58c5-4c55-ba92-592fece00801)  
떨어질 때마다 하트가 하나씩 소모되는데, 이 하트를 모두 소모하게 될 경우 게임이 종료되고 결과창이 뜨게 된다.   
  
![Animation6](https://github.com/changwann/madcamp_week4_2/assets/122224659/f910695f-4c83-4d1c-bfb3-6ea40b36789a)  
또는 게임의 골지점으로 도착하게 돼도 결과창이 뜨게 된다. 이 결과창에서는 정확도 개수와 최대 콤보 개수, 최종 점수 및 획득 코인(1코인/50점)을 볼 수 있다.  
Retry 버튼을 누를 경우 게임을 재시작하게 되며, Home 버튼을 누를 경우 맨 처음 화면으로 돌아가게 된다.   
  

## :pushpin: 느낀 점

김창완: *

이선규: *

## :pushpin: 팀원 연락처

김창완 GIST - changwan@gm.gist.ac.kr  
이선규 KAIST - sean617@kaist.ac.kr
