#Pannatorn Srita #683450056-9

## Class Diagram

```mermaid
class Form1 {
        +Main()

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





