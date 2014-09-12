using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    //An animal shelter holds only dogs and cats, and operates on a strictly "first in, first out" basis.
    //People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, 
    //or they can select whether they would prefer a dog or a cat (and will receive the oldest animal of that type). 
    //They cannot select which specific animal they would like. Create the data structures to maintain this system and 
    //implement operations such as enqueue, dequeueAny, dequeueDog and dequeueCat.You may use the built-in LinkedList data structure.

    public class AnimalShelter
    {
        public LinkedList<Animal> animals;

        // Enqueue newer animal to the end
        public void enqueue (Animal animal)
        {
            LinkedListNode<Animal> tail = animals.Last;
            LinkedListNode<Animal> newAnimal = new LinkedListNode<Animal>(animal);
            animals.AddAfter(tail, newAnimal);
        }

        public Animal dequeueAny()
        {
            LinkedListNode<Animal> head = animals.First;
            Animal oldest = head.Value;
            animals.RemoveFirst();
            return oldest;
        }

        public Dog dequequeDog()
        {
            LinkedListNode<Animal> head = animals.First;
            while (head.Next != null && head.Value is Cat)
            {
                head = head.Next;
            }
            return head.Value as Dog;
        }

        public Cat dequeueCat()
        {
            LinkedListNode<Animal> head = animals.First;
            while (head.Next != null && head.Value is Dog)
            {
                head = head.Next;
            }
            return head.Value as Cat;
        }
    }

    public class Animal
    {
        public DateTime ArrivalTime { get; set; }
    }

    public class Dog : Animal
    { }

    public class Cat: Animal
    { }
}
