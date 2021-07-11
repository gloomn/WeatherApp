# WeatherApp
![GitHub](https://img.shields.io/badge/developer-gloomn-blue)
![GitHub](https://img.shields.io/github/license/gloomn/WeatherApp)
![GitHub](https://img.shields.io/github/languages/top/gloomn/WeatherApp)
![GitHub](https://img.shields.io/github/languages/code-size/gloomn/WeatherApp)

---
### 소개
* [**CSharp**] 기반의 날씨 정보 프로그램입니다.
* 다음 날의 날씨 정보를 기반으로 원하는 시간에 날씨를 문자로 받을 수 있습니다.
* 한국천문연구원과 기상청 API를 이용하였습니다.
* 아직 미완성된 프로그램이며 계속 개발중입니다.

---
### 사용한 레퍼런스
* 프로그램을 제작하실 때 이 프로그램을 참고하신다면 아래 레퍼런스가 들어갔는지 확인해주시기 바랍니다.
* ```Guna.UI2,WinForms.2.0.2.1```
* ```System.IO;```
* ```System.Net```
* ```System.Xml```
* ```WeatherApp.apiKey``` ->이 레퍼런스는 꼭 들어가야지 api가 정상적으로 작동합니다.(자체적으로 api를 보관한다면 작성하신 파일을 넣어주셔야겠죠?)

---
### 사용방법
* 코드를 수정하시고 사용하실 때는 공공데이터 포털에서 직접 API 키를 발급 받으셔서 ```apiKey.cs```파일에 넣으셔야합니다.
* ```apiKey.cs```에 3가지 키를 입력하는 공간이 있는데 ```sunStatusApiKey```와 ```moonStatusApiKey```키에는 일출/일몰 & 월출/월몰 api 키를 넣으셔야 합니다.
* ```weatherApiKey```에는 기상청 API를 넣으셔야 합니다.
* 일출/일몰 & 월출/월몰 API: ```https://www.data.go.kr/data/15012688/openapi.do```
* 기상청 API: ```https://www.data.go.kr/data/15084084/openapi.do```

---
### 주의사항
* 프로그램이 조금 느릴 수 있습니다.
* 이 프로그램의 리소스를 이용하실 때는 라이센스를 꼭 유의해주시기 바랍니다.

---
### 개발현황
![image](https://user-images.githubusercontent.com/86612194/125200557-a70c9400-e2a6-11eb-9d6b-a4b55c7039ef.png)
![image](https://user-images.githubusercontent.com/86612194/125200572-b25fbf80-e2a6-11eb-9754-ee07afc744b0.png)

* 일출 & 일몰 api 연결함
* 월출 & 월몰 api 연결함
* UI 업데이트해야합(제가 디자인 감각이 안 좋아서 좋은 디자인 있으시면 메일이나 issue 남겨주세요ㅠ)

---
### 이메일
* hexahedron74@naver.com

