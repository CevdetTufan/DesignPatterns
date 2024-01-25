/*
 * Singleton Design Pattern is a Creational Design Pattern.
 * 
 * Design Patterns are three kind:
 * 1.) Behavioral -- (Command, Strategy) : It is about responsibilities and communication between objects.
 * 2.) Creational -- (Singleton, Factories) : Instantiation of objects.
 * 3.) Structural -- (Adapter, Decorator, Façade) : Composition and Relations.
 */

/*
 * Singleton Design Pattern restricts the instantiotion of a class to one instance and privides global access to that instance.
 * DI frameworks provide
 * singleton support.
 */

using SingletonDesignPattern;

//Private constructior prevents instantiation from outsite the class.
//Singleton singleton = new Singleton();

//Singleton singletonOb1 = Singleton.Instance;
//Singleton singletonOb2 = Singleton.Instance;


//Not thread safe singleton
Task[] singletonTasks = new Task[5];

for (int i = 0; i < singletonTasks.Length; i++)
{
	singletonTasks[i] = Task.Run(() =>
	{
		Singleton singleton = Singleton.Instance;

		Console.WriteLine($"Instance hash code: {singleton.GetHashCode()} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
	});
}

//thread safe singleton 
Task[] threadSafeSingTasks = new Task[5];

for (int i = 0; i < threadSafeSingTasks.Length; i++)
{
	threadSafeSingTasks[i] = Task.Run(() =>
	{
		ThreadSafeSingleton singleton = ThreadSafeSingleton.Instance;

		Console.WriteLine($"Thread Safe Instance hash code: {singleton.GetHashCode()} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
	});
}

/*
Instance hash code: 37916227 - Thread ID: 12
Instance hash code: 17653682 - Thread ID: 6
Instance hash code: 11404313 - Thread ID: 9
Instance hash code: 11404313 - Thread ID: 10
Instance hash code: 36181605 - Thread ID: 11
*/

/*
Thread Safe Instance hash code: 37916227 - Thread ID: 14
Thread Safe Instance hash code: 37916227 - Thread ID: 15
Thread Safe Instance hash code: 37916227 - Thread ID: 12
Thread Safe Instance hash code: 37916227 - Thread ID: 4
 */

Task.WaitAll(singletonTasks);
Task.WaitAll(threadSafeSingTasks);


Console.ReadLine();