namespace Points
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point (int _x, int _y, char _sym){
            x = _x;
            y = _y;
            sym = _sym;

        }
         public Point(Point p){
            x = p.x;
            y = p.y;
            sym = p.sym;
         }

        public void Move(int offset, string direction){

            if (direction == "right") x += offset;
            else if (direction == "left") x -= offset;
            else if (direction == "up") y -= offset;
            else if (direction == "down") y += offset;

        }
        
        public void Draw(){

            Console.SetCursorPosition(x,y);
            Console.WriteLine(sym);

        }

        public void Clear(){
            sym = ' ';
            Draw();
        }

        public bool Ishit(Point p){
            return p.x == this.x && p.y == this.y;
        }
    }

    class HorizpnalLin : Figura
    {
        public HorizpnalLin(int y, char sym = '+', int xLeft = 0, int xRight = 140){

            pList = new List<Point>();
            
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }

        }
    }

    class VerticalLin : Figura
    {
        public VerticalLin(int x, int yTop = 0, int yDown = 10, char ch = '+'){

            pList = new List<Point>();
            
            for (int i = yTop; i <= yDown; i++)
            {
                var p = new Point(x, i, ch);
                pList.Add(p);
            }
        }
    }

    class Figura
    {
        protected List<Point> pList;

        public void Draw(){

            foreach (var p in pList)
            {
                p.Draw();
            }
        }
        
    }

    class Snake : Figura
    {
         string direction;

        public Snake(Point tail, int length, string _direction){

            direction = _direction;
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);   
            }

        }

        public void Move(){
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint(){
            var head = pList.Last();
            var nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }

        public void HandleKey(ConsoleKey key){

            if (key == ConsoleKey.LeftArrow) direction = "left";
            else if (key == ConsoleKey.RightArrow) direction = "right";
            else if (key == ConsoleKey.UpArrow) direction = "up";
            else if (key == ConsoleKey.DownArrow) direction = "down";   

        }

        public bool Eat(Point food){

            Point head = GetNextPoint();
            if (head.Ishit(food)){
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }else return false;

        }

    }

    class FoodCrator
    {
        int mapWidth;
        int mapHeight;
        char sym;
        Random random = new Random();

        public FoodCrator(int mapWidth, int mapHeight, char sym ){

            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood(){
            int x = random.Next(5,mapWidth);
            int y = random.Next(1,mapHeight);
            return new Point(x,y,sym);
        } 
    }
}