# (C# 코딩) 에코 메신저


## 개요
- C# 프로그래밍 학습
- 1줄 소개: WinForms 기반으로 사용자 입력 데이터를 실시간으로 처리하고 관리하는 메신저 애플리케이션
- 사용한 플랫폼:
- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
- Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
- 


## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
- ![과제1 실행화면](img/screenshot1.png)

![과제1 실행화면]
- 과제 내용
- Label, TextBox, Button, ListBox의 적절한 배치 및 네이밍 적용
- Button의 Click 이벤트와 ListBox의 Items 속성을 연동하여 데이터 전달
- 메시지 전송 직후 입력창(TextBox)의 상태를 초기화하여 연속적인 사용자 입력을 지원

- 구현 내용과 기능 설명
- **데이터 흐름 제어:** 사용자가 `txtMessage`(입력창)에 텍스트를 입력하고 `btnsend`(전송 버튼)를 클릭하면, 해당 텍스트 데이터가 `lstMsgWindow`(리스트 박스)의 Items에 추가되어 화면에 즉시 렌더링됨.
- **UX 초기화:** 텍스트가 대화창으로 전달된 직후, `txtMessage.Clear()` 메서드가 호출되어 입력창의 텍스트가 지워지며 다음 입력을 대기 상태로 만듦.
- **자동 스크롤 지원:** 대화가 누적되어 ListBox의 표시 범위를 초과할 경우, 내장된 기능에 의해 세로 스크롤바가 자동으로 생성되어 이전 대화 기록을 확인할 수 있음.