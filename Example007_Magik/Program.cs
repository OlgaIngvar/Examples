Console.Clear();//очищение тарминала
/*Console.SetCursorPosition(10, 4);//рисование 10 - отступ слева, 4 - отступ сверху
System.Console.WriteLine("+");//показываем, чем хотим рисовать*/

int xa = 10, ya = 1,
    xb = 1, yb = 10,
    xc = 20, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");   
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+"); 
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);// полуинтервал [0;3) выдаются числа 0,1,2
    if(what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    } 
    if(what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    } 
    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    } 
    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("+");
    count = count + 1;// можно писать так count += 1 или так count ++
}



