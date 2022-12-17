using MyLibrary;
using Points;


void Task(){
    // змейка

    Console.Clear();
    var p1 = new Point(10,5,'*'); // точка начала змейки 
    var snake = new Snake(p1,4,"right");
    snake.Draw();

    // спавн еды
    FoodCrator foodCreator = new FoodCrator(50,5,'$');
    Point food = foodCreator.CreateFood();
    food.Draw();

// рамки 
    var horL1 = new HorizpnalLin(0);    
    var horL2 = new HorizpnalLin(10);
    horL1.Draw();
    horL2.Draw();
    
    var vert1 = new VerticalLin(0);
    var vert2 = new VerticalLin(140);
    vert1.Draw();
    vert2.Draw();

    // движение змейки
    while (true)  
    {
        if (snake.Eat(food)){
            food = foodCreator.CreateFood();
            food.Draw();
        } 
        snake.Move();
        Thread.Sleep(150);

        if (Console.KeyAvailable){
            var key = Console.ReadKey();
            snake.HandleKey(key.Key);
        }
    }
}
Task();



