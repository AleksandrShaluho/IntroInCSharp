double Distance = new Random().Next(100, 1000);
int MinDistance = new Random().Next(2,20);
double Friend1Speed = new Random().Next(2,8);
int Friend2Speed = new Random().Next(2,8);
int DogSpeed = new Random().Next(5,15);
bool  RunTo2Friend = true;

int count = 0;

Console.WriteLine("Расстояние между друзьями " + Distance);
Console.WriteLine("Минимальное расстояние до встречи " + MinDistance);
Console.WriteLine("Скорость первого друга " + Friend1Speed);
Console.WriteLine("Скорость второго друга " + Friend2Speed);
Console.WriteLine("Скорость собаки " + DogSpeed);

while (Distance > MinDistance)
{
    count++;
    if (RunTo2Friend == true)
    {
        Distance = Distance * (1-(Friend1Speed+Friend2Speed)/(DogSpeed+Friend2Speed));
    }
    else 
    {
        Distance = Distance * (1-(Friend1Speed+Friend2Speed)/(DogSpeed+Friend1Speed));
    }
}

Console.WriteLine("Собака пробежала " + count + " раз");
