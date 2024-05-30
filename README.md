# 3D-Survival
 내일배움캠프 Chaper 3-2 게임개발 숙련과정 

 ### 개요
 3D로 플레이어가 움직이는 월드입니다.
 ### 구현사항
 1. 플레이어의 이동 및 점프
 2. 체력바 UI
 3. 동적 환경 조사 (장비/아이템에 타겟 시 설명 문구 표시)
 4. 점프대 (플레이어가 밟으면 높이 튀어오름)
 5. 아이템 데이터의 ScriptableObject화
 6. 아이템 사용 - 플레이어가 사용하면 순간 가속하는 아이템 구현
  - 선택요구사항
 7. 추가 UI - 아이템을 사용했을 때 가속의 UI가 표시됩니다.
 8. 움직이는 플랫폼 구현 - 플레이어가 발판 위에서도 자연스럽게 걸어다니고, 발판을 따라갑니다
 9. 다양한 아이템 구현
 10. 추가 장비 장착 - 방패를 추가하였고, 방패을 착용한 상태에서 공격버튼(마우스 좌클릭)을 누르면 돌진합니다.

###선택요구사항 설명
####1. 음료 아이템(가속 소모성 아이템), 추가UI
![image](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/eb0fea60-b1c8-4d22-a6ee-c3da44d96985)
UIInventory.cs파일에서 Speed Enum Type의 아이템을 판정하고, 이에 따른 UI가 표시됩니다

####<시연영상>
![giphy (2)](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/0dbaaaa6-4460-4751-8c41-7e62a54b4542)



####2. 움직이는 플랫폼
![image](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/9a5dd7bb-5931-4429-b6c3-71c4f08a96c3)
MovingPlate.cs파일에서 플레이트의 프레임별 변화량을 계산하고, 이를 각 프레임마다 collisionStay상태의 오브젝트 position에 더해줍니다.


####<시연영상>
![giphy](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/2572425a-e684-44bb-bd9a-04d51f1f6fdc)

####3. 추가 장착 아이템(방패
![image](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/dd7e6ce4-e14c-4d57-9d68-5957201ec6a4)
EquipTool.cs파일에서 무기 공격시, 해당 아이템의 속도증가 옵션 판정. 이후 속도를 증가시킵니다.

####<시연영상>
![giphy (5)](https://github.com/Kaldorei00910/3D-Survival/assets/117884183/6ff01b9c-5c80-44de-8e9a-244629668fd4)
