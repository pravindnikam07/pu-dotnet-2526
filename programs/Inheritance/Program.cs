
class Program
{
  static void Main(string[] args)
  {
    Dog dog1 = new Dog();
    dog1.typeOfAnimal = "Dog";
    dog1.name = "Buddy";
    dog1.Speak();
    dog1.Bark();

  }
}

class Animal
{
  public String typeOfAnimal;
  public virtual void Speak()
  {
    Console.WriteLine("Animal is speaking from Animal class... " + this.typeOfAnimal);
  }
}

class Dog : Animal
{
  public string name;
  public void Bark()
  {
    Console.WriteLine("Dog is barking from Dog class..." + this.name);
  }

  public override void Speak()
  {
    Console.WriteLine("Dog is speaking from Dog class... " + base.typeOfAnimal);
  }

}


