#Pannatorn Srita #683450056-9

## Class Diagram

```mermaid
classDiagram
    class Program {
        +Main()
    }

    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +CoffeeMachine()
        +MakeBlackCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
    }

    Program --> CoffeeMachine



> โปรแกรมนี้ประกอบด้วย 2 คลาสหลัก ได้แก่ Program และ CoffeeMachine  
> คลาส Program ทำหน้าที่เป็นเมนูหลักและรับค่าจากผู้ใช้  
> คลาส CoffeeMachine ทำหน้าที่จัดการวัตถุดิบ ตรวจสอบปริมาณวัตถุดิบ และชงเครื่องดื่มแต่ละชนิด  
> Program มีความสัมพันธ์กับ CoffeeMachine ในลักษณะการเรียกใช้งาน (association)

---

## ถ้าอาจารย์อยากได้ละเอียดขึ้น (ตัวเลือก)
สามารถเพิ่ม method `Refill()` ลงใน diagram ได้ เช่น

```mermaid
+Refill()



