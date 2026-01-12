#Pannatorn Srita #683450056-9

classDiagram
    class Form1 {
        +Main()
    }

    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +MakeBlackCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
    }

    Form1 --> CoffeeMachine
